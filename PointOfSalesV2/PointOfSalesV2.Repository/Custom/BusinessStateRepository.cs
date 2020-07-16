using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class BusinessStateRepository :  IBusinessStateRepository
    {
        private readonly MainDataContext _context;
        public BusinessStateRepository(MainDataContext context) 
        {
            this._context = context;
        }

        public List<object> GetFinancialState(DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }

        public List<TaxesReport> GetTaxesReport(DateTime? startDate, DateTime? endDate)
        {

            List<TaxesReport> result = new List<TaxesReport>();
            List<InvoiceTax> taxes = _context.Invoices.AsNoTracking().Include(x => x.Taxes)
                .ThenInclude(x => x.Tax)
                .Include(x => x.Taxes).ThenInclude(t => t.Currency)
                .Where(x => x.Active == true && 
                (startDate.HasValue?x.BillingDate>=startDate:x.Id>0) &&
                (endDate.HasValue ? x.BillingDate <= endDate : x.Id > 0) &&
                (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid))
                .SelectMany(x => x.Taxes.Select(r=>new InvoiceTax() 
                {
                Active=r.Active,
                PaidAmount=x.PaidAmount,
                TaxAmount=r.TaxAmount,
                TotalAmount=x.TotalAmount,
                Currency=r.Currency,
                CurrencyId=r.CurrencyId,
                Date=r.Date,
                Id=r.Id,
                InvoiceId=r.InvoiceId,
                InvoiceNumber=r.InvoiceNumber,
                Tax=r.Tax,
                TaxId=r.TaxId,
                TRN=r.TRN
                }).Where(t=>t.Active==true)).ToList();
            taxes.AddRange(
                _context.Expenses.AsNoTracking()
                .Include(x => x.Taxes).ThenInclude(t => t.Tax)
                .Include(x => x.Taxes).ThenInclude(t => t.Currency)
                .Where(x => x.Active == true &&
                (startDate.HasValue ? x.Date >= startDate : x.Id > 0) &&
                (endDate.HasValue ? x.Date <= endDate : x.Id > 0) && 
                (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid))
                .SelectMany(x => x.Taxes.Select(r=>new ExpenseTax() 
                {
                ExchangeRateAmount=r.ExchangeRateAmount,
                Active=r.Active,
                PaidAmount=x.PaidAmount,
                TotalAmount=x.TotalAmount,
                TaxAmount=r.TaxAmount,
                Currency=r.Currency,
                CurrencyId=r.CurrencyId,
                Date=r.Date,
                ExpenseId=r.ExpenseId,
                Id=r.Id,
                Reference=r.Reference,
                Tax=r.Tax,
                TaxId=r.TaxId,
                TRN=r.TRN
                }).Where(t=>t.Active==true)).Select(t => new InvoiceTax() 
                {
                Active=true,
                PaidAmount= -1 * t.PaidAmount,
                TotalAmount= -1 * t.TotalAmount,
                Id=t.Id,
                TaxAmount=-1*t.TaxAmount,
                CurrencyId=t.CurrencyId,
                Currency=t.Currency,
                Date=t.Date,
                InvoiceId=t.ExpenseId,
                InvoiceNumber=t.Reference,
                Tax=t.Tax,
                TRN=t.TRN,
                TaxId=t.TaxId,
                }));

            var groupedByCurrency = taxes.OrderBy(x=>x.Date).GroupBy(x => x.CurrencyId).ToList();
            groupedByCurrency.ForEach(g => {
                result.Add(new TaxesReport() 
                {
                Taxes=g.ToList(),
                TotalOutcomeAmount=g.Where(x=>x.TaxAmount<0).Sum(x=>x.TaxAmount),
                TotalIncomeAmount = g.Where(x => x.TaxAmount > 0).Sum(x => x.TaxAmount),
                Currency=g.FirstOrDefault().Currency
                });
            });
            return result;
        }
    }
}
