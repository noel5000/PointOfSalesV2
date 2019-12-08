using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class InventoryEntry : CommonData
    {

        public long ProductId { get; set; }

        public decimal Quantity { get; set; }

        public string Reference { get; set; }
        public long WarehouseId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public long SupplierId { get; set; }
        public long UnitId { get; set; }





        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
        [ForeignKey("Product")]
        public Product Product { get; set; }
        [ForeignKey("WarehouseId")]
        public Warehouse Warehouse { get; set; }
        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
       

    }
}
