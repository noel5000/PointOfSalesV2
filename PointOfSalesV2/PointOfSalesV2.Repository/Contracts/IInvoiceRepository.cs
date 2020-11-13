using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceRepository: IBase<Invoice>
    {
        IEnumerable<Invoice> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, Nullable<long> customerId, Nullable<long> currencyId, long? sellerId,long?branchOfficeId);
        IEnumerable<Invoice> GetSales(DateTime? startDate, DateTime? endDate, Nullable<long> customerId, Nullable<long> currencyId, Nullable<long> sellerId, long? branchOfficeId);
        Invoice GetByInvoiceNumber(string invoiceNumber);

        Result<Invoice> BillQuote(long quoteId);
        PagedList<Invoice> GetPagedQuotes(int page, int size);
        IEnumerable<object> GetAccountStatus(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId);
        IEnumerable<Invoice> GetInvoicesToPay(long branchOfficeId = 0, long currencyId = 0, long customerId = 0);

        List<CompanyStateModel> GetCompanyStatus(DateTime? initialDate, DateTime? endDate);

    }
}
