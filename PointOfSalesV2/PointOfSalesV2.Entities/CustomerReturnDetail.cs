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
    public class CustomerReturnDetail : CommonData
    {


        public long ProductId { get; set; }

        [Export(Order = 3)]
        public decimal Quantity { get; set; }
        [MaxLength(50)]
        [Export(Order = 7)]
        public string Reference { get; set; }
        [MaxLength(50)]
        [Export(Order =8 )]
        public string InvoiceNumber { get; set; }
        public Nullable<long> WarehouseId { get; set; }

        [Export(Order =4 )]
        public decimal TaxesAmount { get; set; }
        [Export(Order =4)]
        public decimal BeforeTaxesAmount { get; set; }
        [Export(Order = 5)]
        public decimal TotalAmount { get; set; }
        public long CustomerId { get; set; }

        [Export(Order = 6)]
        public bool Defective { get; set; }

        public Nullable<long> UnitId { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        [ForeignKey("CustomerId")]
        [Export(Order =1, ChildProperty ="NameAndCode" )]
        public Customer Customer { get; set; }
        [ForeignKey("ProductId")]
        [Export(Order = 2, ChildProperty ="Name")]
        public Product Product { get; set; }
        [ForeignKey("WarehouseId")]
        [Export(Order =9,ChildProperty ="Name" )]
        public Warehouse Warehouse { get; set; }

        [Export(Order = 0)]
        public DateTime Date { get; set; }






    }
}
