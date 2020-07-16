using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IMenuRepository : IBase<Menu>
    {
        Result<object> DeleteMenuEntry(byte weekNo, DayOfWeek dayOfWeek);
        List<InvoiceLeadProjection> MonthProjection(DateTime currentDate, long branchOfficeId=0, long warehouseId=0);
    }
}
