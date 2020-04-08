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
    public class CompanyPayments : CommonData
    {
        public CompanyPayments() { }

        [Export(Order = 4)]
        public byte DestinationType { get; set; }
        [Export(Order = 5)]
        public decimal TotalAmount { get; set; }
        [Export(Order = 6)]
        public decimal GivenAmount { get; set; }
        [Export(Order =0 )]
        public DateTime Date { get; set; }
        [Export(Order = 7)]
        public decimal PositiveBalance { get; set; }
        [Export(Order = 14)]
        public char State { get; set; }
        [Export(Order =8 )]
        public decimal PaidAmount { get; set; }
        public long CurrencyId { get; set; }

        [Export(Order =13 )]
        public long PaymentDestinationId { get; set; }

        public long PaymentTypeId { get; set; }
        [MaxLength(50)]
        [Export(Order =2 )]
        public string Reference { get; set; }
        [Export(Order = 11)]
        public decimal ExchangeRate { get; set; }
        [Export(Order = 12)]
        public decimal ExchangeRateAmount { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        [Export(Order =7 )]
        public decimal OutstandingAmount { get; set; }
        [MaxLength(50)]
        [Export(Order = 1)]
        public string Sequence { get; set; }

        [MaxLength(200)]
        [Export(Order = 3)]
        public string Details { get; set; }


        [ForeignKey("CurrencyId")]
        [Export(Order = 9, ChildProperty ="Code")]
        public Currency Currency { get; set; }

        [Export(Order = 10, ChildProperty ="Name")]
        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }


        [NotMapped]
        public string Name { get; set; }


    }
}
