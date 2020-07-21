using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceDetailRepository: IBase<InvoiceDetail>
    {
        IEnumerable<InvoiceDetail> GetByProductId(long productId);
        IEnumerable<InvoiceDetail> GetByInvoiceId(long invoiceId);
        IEnumerable<InvoiceDetail> GetChildren(long parentId);
        IEnumerable<InvoiceDetail> GetInvoiceParentsDetails(long invoiceId);
    }
}
