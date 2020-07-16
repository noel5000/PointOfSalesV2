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
    public class SupplierReturn : CommonData
    {


        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        public long ProductId { get; set; }
        [Export(Order = 17)]
        public DateTime Date { get; set; }
        [Export(Order = 4)]
        public decimal Quantity { get; set; }
        [MaxLength(50)]
        [Export(Order = 14)]
        public string Reference { get; set; }
        [MaxLength(50)]
        [Export(Order = 15)]
        public string Sequence { get; set; }
        [MaxLength(200)]
        [Export(Order = 16)]
        public string Details { get; set; }

        public long CurrencyId { get; set; }
        public long WarehouseId { get; set; }
        public long BranchOfficeId { get; set; }
        [Export(Order = 7)]
        public decimal TaxAmount { get; set; }
        [Export(Order = 6)]
        public decimal ProductCost { get; set; }
        [Export(Order = 13)]
        public bool IsDefective { get; set; }
        public bool NoTaxes { get; set; }
        [Export(Order = 8)]
        public decimal BeforeTaxAmount { get; set; }
        [Export(Order = 10)]
        public decimal ExchangeRate { get; set; }
        [Export(Order = 11)]
        public decimal ExchangeRateAmount { get; set; }
        [Export(Order = 9)]
        public decimal TotalAmount { get; set; }
        public long SupplierId { get; set; }

        public long UnitId { get; set; }

        [ForeignKey("ProductId")]
        [Export(Order = 3, ChildProperty ="Name")]
        public Product Product { get; set; }

        [ForeignKey("WarehouseId")]
        [Export(Order = 2, ChildProperty = "Name")]
        public Warehouse Warehouse { get; set; }

        [ForeignKey("SupplierId")]
        [Export(Order = 0, ChildProperty = "Name")]
        public Supplier Supplier { get; set; }

        [ForeignKey("UnitId")]
        [Export(Order = 5, ChildProperty = "Name")]
        public Unit Unit { get; set; }


        [ForeignKey("BranchOfficeId")]
        [Export(Order = 1, ChildProperty = "Name")]
        public BranchOffice BranchOffice { get; set; }
        [ForeignKey("CurrencyId")]
        [Export(Order = 12, ChildProperty = "Code")]
        public Currency Currency { get; set; }




    }
}
