using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PointOfSalesV2.Common;
using PointOfSalesV2.Repository.Helpers;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private readonly IDataRepositoryFactory dataRepositoryFactory;

        public InvoiceRepository(MainDataContext context, IDataRepositoryFactory newDataRepo) : base(context)
        {
            dataRepositoryFactory = newDataRepo;
        }

        public IEnumerable<Invoice> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId)
        {

            Func<Invoice, bool> func = invoice => invoice.Active == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
            (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) && (customerId.HasValue ? invoice.CustomerId == customerId.Value : invoice.Id > 0) &&
            (currencyId.HasValue ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) && (sellerId.HasValue ? invoice.SellerId == sellerId.Value : invoice.Id > 0) &&
            invoice.OwedAmount > 0 && (invoice.State == (char)Enums.BillingStates.Billed);
            return _Context.Invoices.AsNoTracking().Where(func);
        }

        public IEnumerable<object> GetAccountStatus(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId)
        {
            throw new NotImplementedException();
        }

        public Invoice GetByInvoiceNumber(string invoiceNumber)
        {
            return _Context.Invoices.AsNoTracking().FirstOrDefault(x => x.Active == true && x.InvoiceNumber.ToLower() == invoiceNumber.ToLower());
        }

        public PagedList<Invoice> GetPagedQuotes(int page, int size)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetSales(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId)
        {
            Func<Invoice, bool> func = invoice => invoice.Active == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
         (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) && (customerId.HasValue ? invoice.CustomerId == customerId.Value : invoice.Id > 0) &&
         (currencyId.HasValue ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) && (sellerId.HasValue ? invoice.SellerId == sellerId.Value : invoice.Id > 0) 
         && (invoice.State != (char)Enums.BillingStates.Nulled);
            return _Context.Invoices.AsNoTracking().Where(func);
        }

        public override Result<Invoice> Add(Invoice entity)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction()) 
            {
                try
                {
                    var trnResult = CreateTRN(entity);

                    if (trnResult.Status < 0) 
                    {
                        transaction.Rollback();
                        return trnResult;
                    }
                    entity = trnResult.Data.FirstOrDefault();
                    entity.Seller = entity.Seller == null && entity.SellerId.HasValue && entity.SellerId.Value > 0 ?
                        _Context.Sellers.Find(entity.SellerId.Value) : entity.Seller;
                    _Context.Entry<Seller>(entity.Seller).State = EntityState.Detached;
                    // entity.ZoneId = entity.Seller != null ? (entity.Seller.ZoneId.HasValue ? entity.Seller.ZoneId.Value : 0) : 0;
                    CreditNote appliedCreditNote = new CreditNote();
                    if (!string.IsNullOrEmpty(entity.AppliedCreditNote))
                        appliedCreditNote = _Context.CreditNotes.AsNoTracking().FirstOrDefault(x => x.Sequence == entity.AppliedCreditNote);

                    if (entity.InvoiceLeads.Count <= 0)
                    {
                        transaction.Rollback();
                        return new Result<Invoice>(-1, -1, "emptyInvoice_msg");
                    }
                    List<InvoiceLead> details = entity.InvoiceLeads;

                    //if (entity.Seller != null && entity.Seller.Id > 0)
                    //{
                    //    details.ForEach(d => {
                    //        decimal comission = entity.Seller.FixedComission ? ((d.BeforeTaxesAmount) * entity.Seller.ComissionRate) : 0;
                    //        comission += entity.Seller.ComissionByProduct ? ((d.BeforeTaxesAmount) * d.Product?.SellerRate).Value : 0;
                    //        d.SellerRate = comission;
                    //    });
                    //    entity.SellerRate = details.Sum(x => x.SellerRate);

                    //}

                    entity.InvoiceNumber = SequencesHelper.CreateInvoiceControl(this.dataRepositoryFactory);
                    entity.BillingDate = DateTime.Now;
                    var tempBranchOfiice = entity.BranchOffice??_Context.BranchOffices.Find(entity.BranchOfficeId);
                    _Context.Entry<BranchOffice>(tempBranchOfiice).State = EntityState.Detached;
                    entity.State = (entity.PaidAmount == entity.TotalAmount && entity.OwedAmount == 0) ? (char)Enums.BillingStates.Paid : (char)Enums.BillingStates.Billed;
                    var creditNoteResult = InvoiceHelper.ApplyCreditNote (entity, appliedCreditNote, out appliedCreditNote);
                    if (creditNoteResult.Status < 0)
                        return creditNoteResult;
                    else
                        entity = creditNoteResult.Data.FirstOrDefault();
                    if (entity.OwedAmount > 0)
                    {
                        var balance = _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x=> x.CustomerId==entity.CustomerId && x.CurrencyId==entity.CurrencyId && x.Active==true) ??
                            new CustomerBalance() { CustomerId = entity.CustomerId, CurrencyId = entity.CurrencyId, Id = 0, Active = true };
                        entity.Customer = entity.Customer != null && entity.Customer.Id > 0 ? entity.Customer :_Context.Customers.Find(entity.CustomerId);
                        _Context.Entry<Customer>(entity.Customer).State = EntityState.Detached;
                        balance.OwedAmount += entity.OwedAmount;
                        if (balance.CurrencyId == entity.Customer.CurrencyId && entity.Customer.CreditAmountLimit > 0 && balance.OwedAmount > entity.Customer.CreditAmountLimit)
                        {
                            transaction.Rollback();
                            return new Result<Invoice>(-1, -1, "creditLimitReached_msg");
                        }
                        if (balance.Id > 0)
                            _Context.CustomersBalance.Update(balance);
                        else
                            _Context.CustomersBalance.Add(balance);

                        _Context.SaveChanges();

                    }
                    entity.ReturnedAmount = entity.ReturnedAmount < 0 ? 0 : entity.ReturnedAmount;

                    var invoice = base.Add(entity).Data.FirstOrDefault();
                    if (!string.IsNullOrEmpty(appliedCreditNote.Sequence)) 
                    {
                        _Context.CreditNotes.Update(appliedCreditNote);
                        _Context.SaveChanges();
                    }

                    invoice.InvoiceLeads = details;
                    invoice.BranchOffice = tempBranchOfiice;
                 //   InvoiceDetailsHelper.AddDetails(invoice,this.dataRepositoryFactory);
                    if (entity.PaidAmount > 0 && entity.Payments != null && entity.Payments.Count > 0)
                    {
                        string sequencePayment = SequencesHelper.CreatePaymentControl(this.dataRepositoryFactory);
                        foreach (var payment in entity.Payments)
                        {
                            payment.InvoiceNumber = entity.InvoiceNumber ;
                            payment.CreatedBy = entity.CreatedBy;
                            payment.CreatedDate = entity.CreatedDate;
                            payment.CurrentOwedAmount = payment.OutstandingAmount;
                            payment.Sequence = sequencePayment;
                            InvoiceHelper.ApplyInvoicePayment(payment,this.dataRepositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>());
                        }
                    }

                    // return invoice;
                    transaction.Commit();
                    result = new Result<Invoice>(entity.Id, 0, "ok_msg", new List<Invoice>() { invoice });

                    return result;
                }
                catch (Exception ex)
                {
                    result = new Result<Invoice>(-1, -1, "error_msg", null, ex);
                    transaction.Rollback();
                    return result;
                }
            }
        

        }

        private Result<Invoice> CreateTRN(Invoice obj)
        {
            if (!string.IsNullOrEmpty(obj.TRNType) && obj.TRNType != "N/A")
            {
                
                var trnControl = _Context.TRNsControl.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Type == obj.TRNType);
                if (trnControl == null || trnControl.Quantity <= 0)
                    return new Result<Invoice>(-1, -1, "trnNotAvailable_msg");

                obj.TRN = $"{trnControl.Series}{trnControl.Type}{string.Format("{0:00000000}", trnControl.Sequence)}";
                trnControl.Sequence++;
                trnControl.Quantity--;
                trnControl.NumericControl++;
                _Context.TRNsControl.Update(trnControl);
                _Context.SaveChanges();
                return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
            }
            return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
        }
    }
}
