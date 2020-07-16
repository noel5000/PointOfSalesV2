using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class Inventory : CommonData
    {
        public long WarehouseId { get; set; }

        public long BranchOfficeId { get; set; }

        public long ProductId { get; set; }
        [Export(Order = 2)]
        public decimal Quantity { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        public long UnitId { get; set; }

        [ForeignKey("WarehouseId")]
        [Export(Order = 0, ChildProperty ="Name")]
        public Warehouse Warehouse { get; set; }
        [ForeignKey("ProductId")]
        [Export(Order = 1, ChildProperty = "Name")]
        public Product Product { get; set; }

        [ForeignKey("UnitId")]
        [Export(Order = 3, ChildProperty = "Name")]
        public Unit Unit { get; set; }


        [ForeignKey("BranchOfficeId")]
        [Export(Order = -1, ChildProperty = "Name")]
        public BranchOffice BranchOffice { get; set; }

        [NotMapped]
        public object ProductShort { get; set; }

    }
}
