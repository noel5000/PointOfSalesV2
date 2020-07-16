using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceDetailRepository: IBase<LeadDetail>
    {
        IEnumerable<LeadDetail> GetByProductId(long productId);
        IEnumerable<LeadDetail> GetByInvoiceId(long invoiceId);
        IEnumerable<LeadDetail> GetChildren(long parentId);
        IEnumerable<LeadDetail> GetInvoiceParentsDetails(long invoiceId);
    }
}
