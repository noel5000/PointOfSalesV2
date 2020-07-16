using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities
{
    public interface IDetailEntity
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long? UnitId { get; set; }
        public decimal Quantity { get; set; }
        public long? WarehouseId { get; set; }
        public long BranchOfficeId { get; set; }
    }
}
