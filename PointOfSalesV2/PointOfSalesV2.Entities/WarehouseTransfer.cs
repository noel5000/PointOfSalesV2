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
    public class WarehouseTransfer : CommonData
    {


        public long OriginId { get; set; }
        public long DestinyId { get; set; }

        public long DestinyBranchOfficeId { get; set; }

        public long OriginBranchOfficeId { get; set; }
        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
        [MaxLength(100)]
        public string Reference { get; set; }

        [MaxLength(200)]
        public string Details { get; set; }

        [MaxLength(50)]
        public string Sequence { get; set; }

        public DateTime Date { get; set; }


        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        public long UnitId { get; set; }




        [ForeignKey("OriginId")]
        public Warehouse Origin { get; set; }


        [ForeignKey("DestinyId")]
        public Warehouse Destiny { get; set; }

        [ForeignKey("OriginBranchOfficeId")]
        public BranchOffice OriginBranchOffice { get; set; }


        [ForeignKey("DestinyBranchOfficeId")]
        public BranchOffice DestinyBranchOffice { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }




    }
}
