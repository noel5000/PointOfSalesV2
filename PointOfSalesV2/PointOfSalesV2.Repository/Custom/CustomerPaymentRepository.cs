using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CustomerPaymentRepository : Repository<CustomerPayment>, ICustomerPaymentRepository
    {
        public CustomerPaymentRepository(MainDataContext context) : base(context)
        {
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

        public object IncomesReport(object searchParams)
        {
            throw new NotImplementedException();
        }
        public override Result<CustomerPayment> Update(CustomerPayment entity)
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
                        invoice.State =(char) Enums.BillingStates.Paid;

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
