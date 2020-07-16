using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceLeadRepository : IBase<InvoiceLead>
    {
        Result<InvoiceLead> DeliverLead(long id);
        Result<InvoiceLead> GetLeadOrMenuInfo(long leadId, long menuId, long schoolId, string documentNumber = "");
        Result<InvoiceLead> GetLeadsForBilling(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, int month = 0);
    }
}
