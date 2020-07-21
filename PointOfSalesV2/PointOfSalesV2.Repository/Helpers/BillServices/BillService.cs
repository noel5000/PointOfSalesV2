using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public class BillService : BillProductServiceBase
    {
        protected override Result<InvoiceDetail> ProcessDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice invoice)
        {
            var newDetail = new InvoiceDetail(detail);
            newDetail.WarehouseId = null;
            newDetail.UnitId = null;
            return new Result<InvoiceDetail>(0, 0, "ok_msg", new List<InvoiceDetail>() { detail });
        }

        protected override Result<InvoiceDetail> ProcessReturnDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice invoice)
        {
            return new Result<InvoiceDetail>(0, 0, "ok_msg", new List<InvoiceDetail>() { detail });
        }
    }
}
