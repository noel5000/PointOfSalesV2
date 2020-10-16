using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Models
{
    public class InventoryReportModel 
    {
        public List<BranchOfficeModel> BranchOffices { get; set; }
    }
    public class BranchOfficeModel : BaseModel
    {
        public List<WarehouseModel> Warehouses{get;set;}
    }

    public class WarehouseModel : BaseModel 
    {
    public List<InventoryModel> Inventory { get; set; }
        public string Code { get; set; }
    }

    public class InventoryModel 
    {
    public long ProductId { get; set; }
    public long UnitId { get; set; }
    public decimal Quantity { get; set; }
    public BaseModel Product { get; set; }
    public BaseModel Unit { get; set; }
    public BaseModel Warehouse { get; set; }
    }

}
