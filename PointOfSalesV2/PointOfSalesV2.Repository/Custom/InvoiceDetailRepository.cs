using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class InvoiceDetailRepository : Repository<LeadDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<LeadDetail> GetByInvoiceId(long invoiceId)
        {
            return _Context.LeadsDetails.AsNoTracking().Where(x => x.Active == true && x.InvoiceLeadId == invoiceId);
        }

        public IEnumerable<LeadDetail> GetByProductId(long productId)
        {
            return _Context.LeadsDetails.AsNoTracking().Where(x => x.Active == true && x.ProductId == productId);
        }

        public IEnumerable<LeadDetail> GetChildren(long parentId)
        {
            return _Context.LeadsDetails.AsNoTracking().Where(x => x.Active == true && x.ParentId==parentId);
        }

        public IEnumerable<LeadDetail> GetInvoiceParentsDetails(long invoiceId)
        {
            return _Context.LeadsDetails.AsNoTracking().Where(x => x.Active == true && x.InvoiceLeadId == invoiceId && x.ParentId==null);
        }
    }
}
