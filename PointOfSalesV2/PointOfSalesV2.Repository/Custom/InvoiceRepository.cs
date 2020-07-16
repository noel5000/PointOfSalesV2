using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PointOfSalesV2.Common;
using PointOfSalesV2.Repository.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static PointOfSalesV2.Common.Enums;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;

namespace PointOfSalesV2.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private readonly IDataRepositoryFactory dataRepositoryFactory;

        public InvoiceRepository(MainDataContext context, IDataRepositoryFactory newDataRepo) : base(context)
        {
            dataRepositoryFactory = newDataRepo;
        }

        public override IQueryable<TResult> GetAll<TResult>(Func<IQueryable<Invoice>, IQueryable<TResult>> transform, Expression<Func<Invoice, bool>> filter = null, string sortExpression = null)
        {
            var _DbSet = _Context.Set<Invoice>();
            var query = filter == null ? _DbSet.AsNoTracking().Include(x => x.Currency).Include(x => x.Customer)
                .Include(x => x.BranchOffice).Include(x => x.TRNControl).Include(x => x.Seller)
                .OrderBy(sortExpression) : _DbSet.AsNoTracking().Include(x => x.Currency).Include(x => x.Customer)
                .Include(x => x.BranchOffice).Include(x => x.TRNControl).Include(x => x.Seller).Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.AsQueryable();
        }
        public IEnumerable<Invoice> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId, long? branchOfficeId)
        {

            return this.GetAll<Invoice>(y => y, x =>
             x.Active == true && (startDate.HasValue ? x.BillingDate >= startDate.Value : x.BillingDate > DateTime.MinValue) &&
            (endDate.HasValue ? x.BillingDate <= endDate.Value : x.BillingDate < DateTime.Now) &&
            (customerId.HasValue && customerId.Value > 0 ? x.CustomerId == customerId.Value : x.CustomerId > 0) &&
            (currencyId.HasValue && currencyId.Value > 0 ? x.CurrencyId == currencyId.Value : x.CurrencyId > 0) &&
            (sellerId.HasValue && sellerId.Value > 0 ? x.SellerId == sellerId.Value : x.SellerId > 0 || x.SellerId == null) &&
            (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? x.BranchOfficeId == branchOfficeId.Value : x.BranchOfficeId > 0) &&
            x.OwedAmount > 0 && ((x.State == (char)Enums.BillingStates.Billed) || (x.State == (char)Enums.BillingStates.Paid))
            );
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

        public IEnumerable<Invoice> GetSales(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId, long? branchOfficeId)
        {
            Func<Invoice, bool> func = invoice => invoice.Active == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
             (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? invoice.BranchOfficeId == branchOfficeId.Value : invoice.BranchOfficeId > 0) &&
         (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) && (customerId.HasValue && customerId.Value > 0 ? invoice.CustomerId == customerId.Value : invoice.Id > 0) &&
         (currencyId.HasValue && currencyId.Value > 0 ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) && (sellerId.HasValue && sellerId.Value > 0 ? invoice.SellerId == sellerId.Value : invoice.Id > 0)
         && (invoice.State != (char)Enums.BillingStates.Nulled);
            return _Context.Invoices.AsNoTracking().Include(x => x.Customer).Include(x => x.BranchOffice)
                .Include(x => x.Seller).Include(x => x.Currency).Include(x => x.Currency).Where(func);
        }

        public IEnumerable<Invoice> GetInvoicesToPay(long branchOfficeId = 0, long currencyId = 0, long customerId = 0)
        {
            Func<Invoice, bool> func = invoice => invoice.Active == true &&
          (customerId > 0 ? invoice.CustomerId == customerId : invoice.CustomerId > 0) &&
         (currencyId > 0 ? invoice.CurrencyId == currencyId : invoice.CurrencyId > 0) && (branchOfficeId > 0 ? invoice.BranchOfficeId == branchOfficeId : invoice.BranchOfficeId > 0)
         && (invoice.State != (char)Enums.BillingStates.Nulled) && (invoice.OwedAmount > 0) && (invoice.PaidAmount < invoice.TotalAmount);
            return _Context.Invoices.AsNoTracking().Include(x => x.Customer).Include(x => x.BranchOffice)
                .Include(x => x.Seller).Include(x => x.Currency).Include(x => x.Currency).Where(func);
        }

        public override Result<Invoice> Add(Invoice entity)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    entity.Customer = entity.Customer != null && entity.Customer.Id > 0 ? entity.Customer : _Context.Customers.Find(entity.CustomerId);
                    entity.Currency = entity.Currency != null && entity.Currency.Id > 0 ? entity.Currency : _Context.Currencies.Find(entity.CurrencyId);
                    _Context.Entry<Customer>(entity.Customer).State = EntityState.Detached;
                    _Context.Entry<Currency>(entity.Currency).State = EntityState.Detached;
                    entity.TRNType = entity.Customer.TRNType;
                    entity.TRNControlId = entity.Customer.TRNControlId;
                    var trnResult = CreateTRN(entity);

                    if (trnResult.Status < 0)
                    {
                        transaction.Rollback();
                        return trnResult;
                    }
                    entity = trnResult.Data.FirstOrDefault();
                    entity.Seller = entity.Seller == null && entity.SellerId.HasValue && entity.SellerId.Value > 0 ?
                        _Context.Sellers.Find(entity.SellerId.Value) : entity.Seller;
                    if (entity.Seller != null)
                        _Context.Entry<Seller>(entity.Seller).State = EntityState.Detached;
                    CreditNote appliedCreditNote = new CreditNote();
                    if (!string.IsNullOrEmpty(entity.AppliedCreditNote))
                        appliedCreditNote = _Context.CreditNotes.AsNoTracking().FirstOrDefault(x => x.Sequence == entity.AppliedCreditNote);

                    if (entity.InvoiceLeads.Count <= 0)
                    {
                        transaction.Rollback();
                        return new Result<Invoice>(-1, -1, "emptyInvoice_msg");
                    }
                   

                    List<InvoiceLead> details = entity.InvoiceLeads;

                    if (entity.Seller != null && entity.Seller.Id > 0)
                    {
                        details.ForEach(d => {
                            d.LeadDetails = d.LeadDetails == null ? _Context.LeadsDetails.AsNoTracking().Include(x=>x.Product).Where(x => x.Active == true && x.InvoiceLeadId == d.Id).ToList():d.LeadDetails;
                            decimal comision = entity.Seller.FixedComission ? ((d.BeforeTaxesAmount) * entity.Seller.ComissionRate) : 0;
                            if (entity.Seller.ComissionByProduct)
                            {
                                d.LeadDetails.ForEach(detail => {
                                    detail.Product = detail.Product ?? _Context.Products.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Id == detail.ProductId);
                                    comision += (detail.Product?.SellerRate * detail.BeforeTaxesAmount).Value;
                                });
                            }
                            d.SellerRate = comision;
                        });
                        entity.SellerRate = details.Sum(x => x.SellerRate);

                    }


                    entity.BeforeTaxesAmount = details.Sum(x => x.BeforeTaxesAmount);
                    entity.DiscountAmount = details.Sum(x => x.DiscountAmount);
                    entity.TaxesAmount = details.Sum(x => x.TaxesAmount);
                    entity.TotalAmount = entity.BeforeTaxesAmount + entity.TaxesAmount - entity.DiscountAmount;
                    entity.DiscountRate = details.Average(x => x.DiscountAmount / x.BeforeTaxesAmount);
                    entity.ReturnedAmount = entity.PaidAmount - entity.TotalAmount;
                    entity.ExchangeRate = entity.Currency.ExchangeRate;
                    entity.OwedAmount = entity.ReturnedAmount < 0 ? Math.Abs(entity.PaidAmount - entity.TotalAmount) : 0;
                    entity.InvoiceNumber = SequencesHelper.CreateSequenceControl(dataRepositoryFactory, Enums.SequenceTypes.Invoices);
                    entity.BillingDate = DateTime.Now;
                    var tempBranchOfiice = entity.BranchOffice ?? _Context.BranchOffices.Find(entity.BranchOfficeId);
                    _Context.Entry<BranchOffice>(tempBranchOfiice).State = EntityState.Detached;
                    entity.State = (entity.PaidAmount == entity.TotalAmount && entity.OwedAmount == 0) ? (char)Enums.BillingStates.FullPaid : (entity.PaidAmount > 0) ? (char)Enums.BillingStates.Paid : (char)Enums.BillingStates.Billed;
                    var creditNoteResult = InvoiceHelper.ApplyCreditNote(entity, appliedCreditNote, out appliedCreditNote);
                    if (creditNoteResult.Status < 0)
                    {
                        transaction.Rollback();
                        return creditNoteResult;
                    }
                    else
                        entity = creditNoteResult.Data.FirstOrDefault();
                    if (entity.OwedAmount > 0)
                    {
                        var balance = _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x => x.CustomerId == entity.CustomerId && x.CurrencyId == entity.CurrencyId && x.Active == true) ??
                            new CustomerBalance() { CustomerId = entity.CustomerId, CurrencyId = entity.CurrencyId, Id = 0, Active = true };

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
                    entity.Customer = null;
                    entity.Currency = null;
                    entity.BranchOffice = null;
                    entity.Payments = new List<CustomerPayment>();
                    entity.Seller = null;
                    entity.Taxes = new List<InvoiceTax>();
                    entity.TRNControl = null;
                    entity.Month = entity.BillingDate.HasValue ? (Enums.Month)entity.BillingDate.Value.Month : (Enums.Month.NotSet);
                    entity.InvoiceLeads = null;
                    var invoice = base.Add(entity).Data.FirstOrDefault();
                    if (!string.IsNullOrEmpty(appliedCreditNote.Sequence))
                    {
                        _Context.CreditNotes.Update(appliedCreditNote);
                        _Context.SaveChanges();
                    }

                    details.ForEach(d =>
                    {
                        d.Customer = null;
                        d.BillingDate = entity.BillingDate;
                        d.State = entity.State;
                        d.Zone = null;
                        d.BranchOffice = null;
                        d.Currency = null;
                        d.InvoiceNumber = entity.InvoiceNumber;
                        d.InvoiceId = entity.Id;
                        d.LeadDetails = null;
                        d.Menu = null;
                        d.School = null;
                        d.TRN = entity.TRN;
                        d.Seller = null;
                        InvoiceDetailsHelper.UpdateInvoiceTaxes(d, dataRepositoryFactory);
                        d.LeadDetails.ForEach(l => {
                            l.Product = null;
                            l.Lead = null;
                            l.Unit = null;
                        });
                    });
                    invoice.BranchOffice = tempBranchOfiice;
                    _Context.InvoicesLeads.UpdateRange(details);
                    _Context.SaveChanges();
                    if (entity.PaidAmount > 0 && entity.Payments != null && entity.Payments.Count > 0)
                    {
                        string sequencePayment = SequencesHelper.CreatePaymentControl(this.dataRepositoryFactory);
                        foreach (var payment in entity.Payments)
                        {
                            payment.InvoiceNumber = entity.InvoiceNumber;
                            payment.CreatedBy = entity.CreatedBy;
                            payment.CreatedDate = entity.CreatedDate;
                            payment.CurrentOwedAmount = payment.OutstandingAmount;
                            payment.Sequence = sequencePayment;
                            InvoiceHelper.ApplyInvoicePayment(payment, this.dataRepositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>());
                        }
                    }


                    transaction.Commit();
                    result = new Result<Invoice>(entity.Id, 0, "ok_msg", new List<Invoice>() { invoice });

                    return result;
                }
                catch (Exception ex)
                {
                    result = new Result<Invoice>(-1, -1, "error_msg", null, new Exception(ex.Message));
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

        public override Result<Invoice> Update(Invoice entity, bool getFromDb = true)
        {
            return new Result<Invoice>(-1, -1, "cannotUpdateInvoice_msg");
        }

        public override Result<Invoice> Remove(long id)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            var entity = _Context.Invoices.AsNoTracking().Include(x => x.Customer).ThenInclude(x => x.Currency).Include(x => x.InvoiceLeads).FirstOrDefault(x => x.Active == true && x.Id == id);
            if (entity.BillingState != Enums.BillingStates.Billed || entity.PaidAmount > 0)
            {
                result = new Result<Invoice>(-1, -1, "alreadyPaid_msg");
                return result;
            }
            else
            {
                using (var trans = _Context.Database.BeginTransaction())
                {
                    try
                    {
                        entity.State = (char)Enums.BillingStates.Nulled;
                        entity.InvoiceLeads.ForEach(l =>
                        {
                            l.InvoiceId = null;
                            l.State = (char)Enums.BillingStates.Delivered;
                            l.BillingDate = null;
                            l.InvoiceNumber = null;
                        });
                        _Context.InvoicesLeads.UpdateRange(entity.InvoiceLeads);
                        _Context.SaveChanges();
                        var taxes = _Context.InvoicesTaxes.AsNoTracking().Where(t => t.Active == true && t.InvoiceId == id).ToList();
                        _Context.InvoicesTaxes.RemoveRange(taxes);
                        _Context.SaveChanges();
                        entity.InvoiceLeads = null;
                        _Context.Invoices.Update(entity);
                        _Context.SaveChanges();
                        result = new Result<Invoice>(id, 0, "ok_msg");
                        trans.Commit();


                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        result = new Result<Invoice>(-1, -1, "error_msg", null, new Exception(ex.Message));
                    }
                }
            }
            return result;
        }

        public List<CompanyStateModel> GetCompanyStatus(DateTime? initialDate, DateTime? endDate)
        {
            
            List<CompanyStateModel> result = new List<CompanyStateModel>();
            var expenses = _Context.Expenses.Include(x => x.Payments).ThenInclude(p => p.Currency)
                .Include(x=>x.Supplier)
                .Include(x => x.Currency).AsNoTracking().Where(x => x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid)
                && x.Date>=(initialDate.HasValue?initialDate.Value:DateTime.MinValue) && x.Date<=(endDate.HasValue?endDate.Value:DateTime.Now)).ToList();
           
            var invoices = _Context.Invoices.Include(x => x.Payments).ThenInclude(p => p.Currency)
                .Include(x=>x.Customer)
                .Include(x => x.Currency).AsNoTracking().Where(x => x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid)
                  && x.BillingDate >= (initialDate.HasValue ? initialDate.Value : DateTime.MinValue) && x.BillingDate <= (endDate.HasValue ? endDate.Value : DateTime.Now)).ToList();

            expenses.ForEach(expense => {
                result.Add(new CompanyStateModel()
                {
                    CompanyOwedAmount = expense.TotalAmount,
                    CustomersOwedAmount = 0,
                    IncomeAmount = 0,
                    OutcomeAmount = 0,
                    CurrencyCode = expense.Currency.Code,
                    CurrencyId = expense.CurrencyId,
                    CurrencyName = expense.Currency.Name,
                    CustomerName = string.Empty,
                    Date = expense.Date,
                    Reference = expense.Sequence,
                    Details = $"{expense.Supplier.Name}",
                    ExchangeRate = expense.ExchangeRate,
                    SellerName = string.Empty
                });
                expense.Payments.Where(x => x.Active == true && x.State == (char)Enums.BillingStates.Paid).ToList().ForEach(payment => {
                    result.Add(new CompanyStateModel() {
                    CompanyOwedAmount=0,
                    CustomersOwedAmount=0,
                    IncomeAmount=0,
                    OutcomeAmount=payment.PaidAmount,
                    CurrencyCode=payment.Currency.Code,
                    CurrencyId=payment.CurrencyId,
                    CurrencyName=payment.Currency.Name,
                    CustomerName="",
                    Date=payment.Date,
                    Details=$"{expense.Supplier.Name}",
                    ExchangeRate=payment.ExchangeRate,
                    Reference=payment.Sequence,
                    SellerName=string.Empty
                    });
                });
            });


            invoices.ForEach(invoice => {
                result.Add(new CompanyStateModel()
                {
                    CompanyOwedAmount = 0,
                    CustomersOwedAmount = invoice.TotalAmount,
                    IncomeAmount = 0,
                    OutcomeAmount =invoice.Cost,
                    CurrencyCode = invoice.Currency.Code,
                    CurrencyId = invoice.CurrencyId,
                    CurrencyName = invoice.Currency.Name,
                    CustomerName = invoice.Customer.NameAndCode,
                    Date = invoice.BillingDate.Value,
                    Reference = invoice.InvoiceNumber,
                    Details = $"{invoice.Customer.NameAndCode}",
                    ExchangeRate = invoice.ExchangeRate,
                    SellerName = string.Empty
                });
                invoice.Payments.Where(x => x.Active == true).ToList().ForEach(payment => {
                    result.Add(new CompanyStateModel()
                    {
                        CompanyOwedAmount = 0,
                        CustomersOwedAmount = 0,
                        IncomeAmount = payment.PaidAmount,
                        OutcomeAmount =0,
                        CurrencyCode = payment.Currency.Code,
                        CurrencyId = payment.CurrencyId,
                        CurrencyName = payment.Currency.Name,
                        CustomerName = "",
                        Date = payment.Date,
                        Details = $"{invoice.Customer.NameAndCode}",
                        ExchangeRate = payment.ExchangeRate,
                        Reference = payment.Sequence,
                        SellerName = string.Empty
                    });
                });
            });



            return result;
        }
    }
}
