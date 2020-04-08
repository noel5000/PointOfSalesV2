using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public class BillService : BillProductServiceBase
    {
        protected override Result<LeadDetail> ProcessDetail(long branchOfficeId, LeadDetail detail, IDataRepositoryFactory dataRepositoryFactory, InvoiceLead invoice)
        {
            var newDetail = new LeadDetail(detail);
            newDetail.WarehouseId = null;
            newDetail.UnitId = null;
            return new Result<LeadDetail>(0, 0, "ok_msg", new List<LeadDetail>() { detail });
        }

        protected override Result<LeadDetail> ProcessReturnDetail(long branchOfficeId, LeadDetail detail, IDataRepositoryFactory dataRepositoryFactory, InvoiceLead invoice)
        {
            return new Result<LeadDetail>(0, 0, "ok_msg", new List<LeadDetail>() { detail });
        }
    }
}
