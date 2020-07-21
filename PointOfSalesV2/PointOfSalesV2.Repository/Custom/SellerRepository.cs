using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class SellerRepository : Repository<Seller>, ISellerRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public SellerRepository(MainDataContext context, ISequenceManagerRepository sequenceRepo) : base(context)
        {
            this._sequenceRepo = sequenceRepo;
        }

        public override Result<Seller> Add(Seller entity)
        {
            entity.Code = _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Sellers);
            return base.Add(entity);
        }

        public ComissionsReport PaymentsComissions(ComissionsSearch search)
        {
            var result = new ComissionsReport() { ComissionsByCyrrencies = new List<ComissionsByCurrency>() };
            var invoices = _Context.CustomersPayments.AsNoTracking().Include(x => x.Currency).Include(x => x.Seller).Include(x=>x.Customer)
                .Where(x => 
                x.Active == true && x.State!=(char)BillingStates.Nulled &&
                (search.CustomerId.HasValue && search.CustomerId.Value>0?x.CustomerId== search.CustomerId.Value:x.CustomerId>0) &&
                (search.CurrencyId.HasValue && search.CurrencyId.Value > 0 ? x.CurrencyId == search.CurrencyId.Value : x.CurrencyId > 0) &&
                (search.SellerId.HasValue && search.SellerId.Value > 0 ? x.SellerId == search.SellerId.Value : x.SellerId > 0) &&
                (search.InitialDate.HasValue ? x.Date >= search.InitialDate.Value : x.Date > DateTime.MinValue) &&
                (search.FinalDate.HasValue  ? x.Date <= search.FinalDate.Value : x.Date < DateTime.Now) &&
                (string.IsNullOrEmpty(search.InvoiceNumber)?x.InvoiceNumber!="":x.InvoiceNumber.ToUpper()== search.InvoiceNumber.ToUpper())
                && x.SellerRate>0
                ).ToList().GroupBy(x => x.CurrencyId).ToList();

            invoices.ForEach(r => {
                result.ComissionsByCyrrencies.Add(new ComissionsByCurrency()
                {
                    TotalAmount = r.Sum(x => x.SellerRate),
                    CurrencyCode = r.FirstOrDefault().Currency.Code,
                    CurrencyName = r.FirstOrDefault().Currency.Name,
                    Details =r.Select(x => new ComissionDetail() 
                    {
                    Amount=x.SellerRate,
                    BeforeTaxesAmount=0,
                    PaidAmount=x.PaidAmount,
                    TotalAmount=x.TotalAmount,
                    CurrencyCode=x.Currency.Code,
                    CustomerName=x.Customer.NameAndCode,
                    Date=x.Date,
                    Reference=x.Sequence,
                    SellerName=x.Seller?.NameAndCode??""
                    }).ToList()
                });
            });


            return result;
        }

        public ComissionsReport SalesComissions(ComissionsSearch search)
        {
            var result = new ComissionsReport() { ComissionsByCyrrencies = new List<ComissionsByCurrency>() };
            var invoices = _Context.Invoices.AsNoTracking().Include(x => x.Currency).Include(x => x.Seller).Include(x => x.Customer)
                .Where(x =>
                x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid) &&
                (search.CustomerId.HasValue && search.CustomerId.Value > 0 ? x.CustomerId == search.CustomerId.Value : x.CustomerId > 0) &&
                (search.CurrencyId.HasValue && search.CurrencyId.Value > 0 ? x.CurrencyId == search.CurrencyId.Value : x.CurrencyId > 0) &&
                (search.SellerId.HasValue && search.SellerId.Value > 0 ? x.SellerId == search.SellerId.Value : x.SellerId > 0) &&
                (search.InitialDate.HasValue ? x.BillingDate >= search.InitialDate.Value : x.BillingDate > DateTime.MinValue) &&
                (search.FinalDate.HasValue ? x.BillingDate <= search.FinalDate.Value : x.BillingDate < DateTime.Now) &&
                (string.IsNullOrEmpty(search.InvoiceNumber) ? x.InvoiceNumber != "" : x.InvoiceNumber.ToUpper() == search.InvoiceNumber.ToUpper())
                && x.SellerRate > 0
                ).ToList().GroupBy(x => x.CurrencyId).ToList();

            invoices.ForEach(r => {
                result.ComissionsByCyrrencies.Add(new ComissionsByCurrency()
                {
                    TotalAmount = r.Sum(x => x.SellerRate),
                    CurrencyCode = r.FirstOrDefault().Currency.Code,
                    CurrencyName = r.FirstOrDefault().Currency.Name,
                    Details = r.Select(x => new ComissionDetail()
                    {
                        Amount = x.SellerRate,
                        BeforeTaxesAmount = x.BeforeTaxesAmount,
                        PaidAmount = x.PaidAmount,
                        TotalAmount = x.TotalAmount,
                        CurrencyCode = x.Currency.Code,
                        CustomerName = x.Customer.NameAndCode,
                        Date = x.BillingDate.Value,
                        Reference = x.InvoiceNumber,
                        SellerName = x.Seller?.NameAndCode ?? ""
                    }).ToList()
                });
            });


            return result;
        }

        public override Result<Seller> Update(Seller entity, bool fromDb = true)
        {
            entity.Code = string.IsNullOrEmpty(entity.Code) ? _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Sellers) : entity.Code;
            return base.Update(entity);
        }

    }
}
