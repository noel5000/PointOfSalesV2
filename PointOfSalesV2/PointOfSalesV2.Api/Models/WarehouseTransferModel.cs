using PointOfSalesV2.Entities;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Models
{
    public class WarehouseTransferModel
    {
        public string Reference { get; set; }
        public string Details { get; set; }

        public List<WarehouseTransfer> Entries { get; set; }
    }

    public class WarehouseMovementModel
    {
        public BaseModel Product { get; set; }
        public BaseModel BranchOffice { get; set; }
        public BaseModel Warehouse { get; set; }
        public BaseModel Unit { get; set; }
        public string Reference { get; set; }
        public string MovementType { get; set; }
        public long ProductId { get; set; }
        public long BranchOfficeId { get; set; }
        public long WarehouseId { get; set; }
        public long UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal CurrentBalance { get; set; }
        public long Id { get; set; }
    }
}
