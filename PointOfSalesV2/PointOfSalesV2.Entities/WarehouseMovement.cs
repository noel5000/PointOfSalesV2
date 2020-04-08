using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class WarehouseMovement : CommonData
    {

        public long WarehouseId { get; set; }
        public long BranchOfficeId { get; set; }
        public long ProductId { get; set; }

        [Export(Order = 4)]
        public decimal Quantity { get; set; }




        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        public long UnitId { get; set; }
        [Export(Order = 5)]
        public string MovementType { get; set; }
        [MaxLength(50)]
        [Export(Order = 6)]
        public string Reference { get; set; }
        [Export(Order =7)]
        public decimal CurrentBalance { get; set; }


        public WarehouseMovement() { }

        public WarehouseMovement(long warehouseId, long productId, decimal quantity, bool active, long unitId, long branchOfficeId, string movType, string reference, decimal currentBalance = 0)
        {
            this.WarehouseId = warehouseId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.CreatedDate = DateTime.Now;
            this.Active = active;
            this.UnitId = unitId;
            this.BranchOfficeId = branchOfficeId;
            this.MovementType = movType;
            this.Reference = reference;
            this.CurrentBalance = currentBalance;
        }


        [ForeignKey("ProductId")]
        [Export(Order = 2, ChildProperty = "Name")]
        public Product Product { get; set; }
        [ForeignKey("BranchOfficeId")]
        [Export(Order = 0, ChildProperty = "Name")]
        public BranchOffice BranchOffice { get; set; }
        [ForeignKey("WarehouseId")]
        [Export(Order = 1, ChildProperty = "Name")]
        public Warehouse Warehouse { get; set; }

        [NotMapped]
        public string WarehouseName { get; set; }
        [NotMapped]
        public string LocationName { get; set; }
        [NotMapped]
        public string Name { get; set; }

        [NotMapped]
        public string Details { get; set; }
        [ForeignKey("UnitId")]
        [Export(Order = 3, ChildProperty = "Name")]
        public Unit Unit { get; set; }
       

    }
}
