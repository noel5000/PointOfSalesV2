using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public class CustomerPaymentRepository : Repository<CustomerPayment>, ICustomerPaymentRepository
    {
        readonly IDataRepositoryFactory dataRepositoryFactory;
        public CustomerPaymentRepository(MainDataContext context, IDataRepositoryFactory repoFactory) : base(context)
        {
            this.dataRepositoryFactory = repoFactory;
        }

        public CustomerPayment ApplyInvoicePayment(CustomerPayment payment)
        {
            var result = _Context.CustomersPayments.Add(payment).Entity;
            _Context.SaveChanges();
            return result;
        }

        public object CommisionsReport(object searchParams)
        {
            throw new NotImplementedException();
        }

        public List<CustomerPayment> IncomesReport(long branchOfficeId, long customerId, long currencyId, long paymentTypeId, DateTime? initialDate, DateTime? endDate)
        {
            return _Context.CustomersPayments.Include(x=>x.Invoice)
                .Include(x=>x.Customer)
                .Include(x => x.Currency)
                .Include(x => x.Seller)
                .AsNoTracking().Where(x => x.Active == true &&
            (branchOfficeId>0?x.Invoice.BranchOfficeId==branchOfficeId:x.Id>0) &&
            (customerId>0?x.CustomerId==customerId:x.CustomerId>0) &&
            (currencyId>0?x.CurrencyId==currencyId:x.CurrencyId>0) &&
            (paymentTypeId>0?x.PaymentTypeId==paymentTypeId:x.PaymentTypeId>0) &&
            (initialDate.HasValue?x.Date>=initialDate.Value:x.Date>DateTime.MinValue) &&
            (endDate.HasValue?x.Date<=endDate:x.Date<=DateTime.Now)
            ).ToList();
        }
        public override Result<CustomerPayment> Update(CustomerPayment entity, bool fromDb = true)
        {
            return new Result<CustomerPayment>(-1, -1, "cannotUpdatePayment_msg");
        }

        public override Result<CustomerPayment> Add(CustomerPayment entity)
        {
            var result = new Result<CustomerPayment>(-1, -1, "error_msg");
           
            using (var transaction = _Context.Database.BeginTransaction()) 
            {
                try
                {
                    var invoice = _Context.Invoices.AsNoTracking().FirstOrDefault(x => x.InvoiceNumber.ToLower() == entity.InvoiceNumber.ToLower() && x.Active==true);
                    if (invoice == null)
                        return new Result<CustomerPayment>(-1,-1,"invalidInvoice_msg");
                    if(invoice.OwedAmount != entity.OutstandingAmount)
                        return new Result<CustomerPayment>(-1, -1, "owedAmountOutdated_msg");
                    if(invoice.OwedAmount<=0)
                        return new Result<CustomerPayment>(-1, -1, "invoicePaid_msg");
                    var previousPayments = _Context.CustomersPayments.AsNoTracking().Where(x => x.InvoiceNumber.ToLower() == entity.InvoiceNumber.ToLower()&& x.Active==true).ToList();
                    invoice.PaidAmount += invoice.PaidAmount;
                    entity.TotalAmount = invoice.TotalAmount;
                    decimal comissionRate = invoice.SellerRate / invoice.BeforeTaxesAmount;

                    invoice.PaidAmount = invoice.PaidAmount > invoice.TotalAmount ? invoice.TotalAmount : invoice.PaidAmount;
                    invoice.OwedAmount -= entity.PaidAmount;
                    invoice.OwedAmount = invoice.OwedAmount < 0 ? 0 : invoice.OwedAmount;
                    entity.OutstandingAmount = invoice.OwedAmount;
                    if (invoice.OwedAmount == 0)
                        invoice.State =(char) Enums.BillingStates.FullPaid;
                    else
                        invoice.State = (char)Enums.BillingStates.Paid;

                    _Context.Invoices.Update(invoice);
                    _Context.SaveChanges();
                    var customerBalance = _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x=>x.CustomerId==entity.CustomerId && x.CurrencyId== entity.CurrencyId && x.Active==true);
                    if (customerBalance != null)
                    {
                        customerBalance.OwedAmount -= entity.PaidAmount;
                        customerBalance.OwedAmount = customerBalance.OwedAmount < 0 ? 0 : customerBalance.OwedAmount;
                        _Context.CustomersBalance.Update(customerBalance);
                        _Context.SaveChanges();
                    }
                    decimal taxesRate = invoice.TaxesAmount / invoice.TotalAmount;
                    decimal paymentComissionsAmount = (entity.PaidAmount - (entity.PaidAmount * taxesRate));
                    entity.SellerRate = (previousPayments != null && previousPayments.Sum(x => x.SellerRate) >= invoice.SellerRate) ? 0 : (paymentComissionsAmount * comissionRate);

                    _Context.CustomersPayments.Add(entity);
                    _Context.SaveChanges();

                    transaction.Commit();
                    return new Result<CustomerPayment>(0, 0, "ok_msg", new List<CustomerPayment>() { entity });


                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    result.Exception = ex;
                    return result;
                }
                

            }
        }

          Result<CustomerPayment> AddWithoutTransaction(CustomerPayment entity, Invoice invoice)
        {
            var result = new Result<CustomerPayment>(-1, -1, "error_msg");
                    if (invoice == null)
                        return new Result<CustomerPayment>(-1, -1, "invalidInvoice_msg");
                    if (invoice.OwedAmount != entity.OutstandingAmount)
                        return new Result<CustomerPayment>(-1, -1, "owedAmountOutdated_msg");
                    if (invoice.OwedAmount <= 0)
                        return new Result<CustomerPayment>(-1, -1, "invoicePaid_msg");
                    var previousPayments = _Context.CustomersPayments.AsNoTracking().Where(x => x.InvoiceNumber.ToLower() == entity.InvoiceNumber.ToLower() && x.Active == true).ToList();
                    invoice.PaidAmount += invoice.CurrentPaidAmount;
                    entity.TotalAmount = invoice.TotalAmount;
                    decimal comissionRate = invoice.SellerRate / invoice.BeforeTaxesAmount;

                    invoice.PaidAmount = invoice.PaidAmount > invoice.TotalAmount ? invoice.TotalAmount : invoice.PaidAmount;
                    invoice.OwedAmount -= entity.PaidAmount;
                    invoice.OwedAmount = invoice.OwedAmount < 0 ? 0 : invoice.OwedAmount;
                    entity.OutstandingAmount = invoice.OwedAmount;
                    if (invoice.OwedAmount == 0)
                        invoice.State = (char)Enums.BillingStates.FullPaid;
                    else
                        invoice.State = (char)Enums.BillingStates.Paid;

                    _Context.Invoices.Update(invoice);
                    _Context.SaveChanges();
                  
                    decimal taxesRate = invoice.TaxesAmount / invoice.TotalAmount;
                    decimal paymentComissionsAmount = (entity.PaidAmount - (entity.PaidAmount * taxesRate));
                    entity.SellerRate = (previousPayments != null && previousPayments.Sum(x => x.SellerRate) >= invoice.SellerRate) ? 0 : (paymentComissionsAmount * comissionRate);
                    _Context.CustomersPayments.Add(entity);
                    _Context.SaveChanges();
              
                    return new Result<CustomerPayment>(0, 0, "ok_msg", new List<CustomerPayment>() { entity });
                
        }

        public  Result<object> PayInvoices(InvoicesPaymentModel model)
        {
            var result = new Result<object>(-1, -1, "error_msg");

            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    string sequence = dataRepositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>().CreateSequence(Enums.SequenceTypes.CustomerPayments);
                    if (model.Invoices.Count == 0 && model.Invoices.Any(x => x.CurrentPaidAmount == 0))
                    {
                        transaction.Rollback();
                        return new Result<object>(-1, -1, "noInvoicesSelected_msg");
                    }
                    model.Invoices.ForEach(i => {
                        CustomerPayment payment = new CustomerPayment()
                        {
                            Active=true,
                            CurrentOutstandingAmount= i.OwedAmount - i.CurrentPaidAmount,
                            OutstandingAmount=i.OwedAmount,
                            CurrentOwedAmount=i.OwedAmount - i.CurrentPaidAmount,
                            PaidAmount=i.CurrentPaidAmount,
                            TotalAmount=i.TotalAmount,
                            CurrencyId=model.Payment.CurrencyId,
                            CustomerId= model.Payment.CustomerId,
                            Date=DateTime.Now,
                            Details=model.Payment.Details,
                            ExchangeRate=i.Currency.ExchangeRate,
                            InvoiceCurrencyId=i.CurrencyId,
                            InvoiceNumber=i.InvoiceNumber,
                            SellerId=i.SellerId,
                            CheckbookNumber="",
                            InvoiceId=i.Id,
                            Sequence=sequence,
                            PaymentTypeId=model.Payment.PaymentTypeId,
                        };
                        i.BranchOffice = null;
                        i.Customer = null;
                        i.Currency = null;
                        i.TRNControl = null;
                    var paymentResult=   this.AddWithoutTransaction(payment,i);
                        if (paymentResult.Status < 0) 
                        {
                            throw new Exception(paymentResult.Message);
                        }
                    });
                    var customerBalance = _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x => x.CustomerId == model.Invoices.FirstOrDefault().CustomerId && x.CurrencyId == model.Invoices.FirstOrDefault().CurrencyId && x.Active == true);
                    if (customerBalance != null)
                    {
                        customerBalance.OwedAmount -=model.Invoices.Sum(x=>x.PaidAmount);
                        customerBalance.OwedAmount = customerBalance.OwedAmount < 0 ? 0 : customerBalance.OwedAmount;
                        _Context.CustomersBalance.Update(customerBalance);
                        _Context.SaveChanges();
                    }
                    transaction.Commit();
                    return new Result<object>(0, 0, "ok_msg", new List<CustomerPayment>() { new CustomerPayment() });


                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    result.Exception = ex;
                    return result;
                }


            }
        }

        public Result<object> ReversePayment(string sequence) 
        {
            var result = new Result<object>(-1, -1, "error_msg");
            using (var trans = _Context.Database.BeginTransaction()) 
            {
                try
                {
                    var payments = this.GetAll(x => x, y => y.Active == true && y.Sequence.ToLower() == sequence.ToLower()).Data.ToList();
                    var invoices = _Context.Invoices.Include(i=>i.Customer).ThenInclude(c=>c.CustomerBalances).AsNoTracking().Where(i => payments.Select(p => p.InvoiceNumber).Contains(i.InvoiceNumber)).ToList();
                    var balances = invoices.SelectMany(x => x.Customer.CustomerBalances).Where(x=>x.Active==true && x.CurrencyId== payments.FirstOrDefault().CurrencyId).FirstOrDefault();
                    payments.ForEach(p => {
                        p.Active = false;
                        var index = invoices.FindIndex(x=>x.Id==p.InvoiceId);
                        invoices[index].PaidAmount-= p.PaidAmount;
                        invoices[index].PaidAmount = invoices[index].PaidAmount < 0 ? 0 : invoices[index].PaidAmount;
                        invoices[index].OwedAmount += p.PaidAmount;
                        invoices[index].OwedAmount = invoices[index].OwedAmount > invoices[index].TotalAmount ? invoices[index].TotalAmount : invoices[index].OwedAmount;
                        invoices[index].State = invoices[index].PaidAmount <= 0 ? (char)Enums.BillingStates.Billed : (char)Enums.BillingStates.Paid;
                        balances.OwedAmount += p.PaidAmount;
                        p.Currency = null;
                        p.Customer = null;
                        p.Seller = null;
                    });
                    invoices.ForEach(i => {
                        i.Customer = null;
                        i.Currency = null;
                        i.BranchOffice = null;
                        i.InvoiceLeads = null;
                        i.Payments = null;
                        i.Seller = null;
                        i.Taxes = null;
                        i.TRNControl = null;
                    });
                    _Context.Invoices.UpdateRange(invoices);
                    _Context.SaveChanges();
                    _Context.CustomersPayments.UpdateRange(payments);
                    _Context.SaveChanges();
                    _Context.CustomersBalance.Update(balances);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<object>(0, 0, "ok_msg");
                }
                catch (Exception ex) 
                {
                    trans.Rollback();
                    result = new Result<object>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
                
            }
            return result;
        }

        public override Result<CustomerPayment> Remove(long id)
        {
            Result<CustomerPayment> result = new Result<CustomerPayment>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var obj = this.Get(id).Data.FirstOrDefault();
                    if (obj == null)
                        return new Result<CustomerPayment>(-1, -1, "paymentNotValid_msg");
                    obj.Active = false;

                    Invoice invoice = _Context.Invoices.AsNoTracking().FirstOrDefault(x => x.Active == true && x.InvoiceNumber == obj.InvoiceNumber);

                    invoice.PaidAmount -= obj.PaidAmount;
                    invoice.PaidAmount = invoice.PaidAmount < 0 ? 0 : invoice.PaidAmount;
                    invoice.OwedAmount += obj.PaidAmount;
                    invoice.OwedAmount = invoice.OwedAmount > invoice.TotalAmount ? invoice.TotalAmount : invoice.OwedAmount;
                    if (invoice.State != (char)Enums.BillingStates.Billed)
                        invoice.State = (char)Enums.BillingStates.Billed;
                    _Context.Invoices.Update(invoice);
                    _Context.SaveChanges();
                    CustomerBalance customerBalance = _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x => x.Active == true && x.CustomerId == obj.CustomerId && x.CurrencyId == obj.CurrencyId);
                    if (customerBalance != null)
                    {
                        customerBalance.OwedAmount += obj.PaidAmount;
                        _Context.CustomersBalance.Update(customerBalance);
                        _Context.SaveChanges();
                    }
                    // obj.ModificadoPor = userNamer;
                    obj.ModifiedDate = DateTime.Now;
                    _Context.CustomersPayments.Update(obj);
                    _Context.SaveChanges();
                    transaction.Commit();
                    return new Result<CustomerPayment>(0, 0, "ok_msg", new List<CustomerPayment>() { obj });
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    result.Exception = ex;
                    return result;
                }
            }
        }
        public override Result<CustomerPayment> Remove(CustomerPayment entity)
        {
            Result<CustomerPayment> result = new Result<CustomerPayment>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var obj = this.Get(entity.Id).Data.FirstOrDefault();
                    if (obj == null)
                        return new Result<CustomerPayment>(-1, -1, "paymentNotValid_msg");
                    obj.Active = false;

                    Invoice invoice = _Context.Invoices.AsNoTracking().FirstOrDefault(x => x.Active == true && x.InvoiceNumber == obj.InvoiceNumber);

                    invoice.PaidAmount -= obj.PaidAmount;
                    invoice.PaidAmount = invoice.PaidAmount < 0 ? 0 : invoice.PaidAmount;
                    invoice.OwedAmount += obj.PaidAmount;
                    invoice.OwedAmount = invoice.OwedAmount > invoice.TotalAmount ? invoice.TotalAmount : invoice.OwedAmount;
                    if (invoice.State != (char)Enums.BillingStates.Billed)
                        invoice.State = (char)Enums.BillingStates.Billed;
                    _Context.Invoices.Update(invoice);
                    _Context.SaveChanges();
                    CustomerBalance customerBalance = _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x => x.Active == true && x.CustomerId == obj.CustomerId && x.CurrencyId == obj.CurrencyId);
                    if (customerBalance != null)
                    {
                        customerBalance.OwedAmount += obj.PaidAmount;
                        _Context.CustomersBalance.Update(customerBalance);
                        _Context.SaveChanges();
                    }
                    // obj.ModificadoPor = userNamer;
                    obj.ModifiedDate = DateTime.Now;
                    _Context.CustomersPayments.Update(obj);
                    _Context.SaveChanges();
                    transaction.Commit();
                    return new Result<CustomerPayment>(0, 0, "ok_msg", new List<CustomerPayment>() { obj });
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    result.Exception = ex;
                    return result;
                }
            }
        }

        public override void AddRange(IEnumerable<CustomerPayment> entities)
        {
            base.AddRange(entities);
        }
    }
}
