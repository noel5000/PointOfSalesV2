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
    public class CustomerPayment : CommonData
    {

        public CustomerPayment() { }

        public CustomerPayment(long CustomerId, long CurrencyId, long InvoiceCurrencyId, long PaymentTypeId, decimal TotalAmount, decimal PaidAmount, string InvoiceNumber, decimal ExchangeRate, decimal OutstandingAmount,
            string Sequence, string Details, DateTime CreatedDate, Guid CreatedBy, bool Active, decimal CurrentOutstandingAmount, string CheckbookNumber, decimal SellerRate = 0, int? SellerId = null, decimal currentOwedAmount=0)
        {
            this.Active = Active;
            this.CustomerId = CustomerId;
            this.CreatedBy = CreatedBy;
            this.Details = Details;
            this.CreatedDate = CreatedDate;
            this.InvoiceCurrencyId = InvoiceCurrencyId;
            this.CurrencyId = CurrencyId;
            this.PaidAmount = PaidAmount;
            this.OutstandingAmount = OutstandingAmount; // Monto pendiente
            this.TotalAmount = TotalAmount;
            this.InvoiceNumber = InvoiceNumber;
            this.Sequence = Sequence;
            this.ExchangeRate = ExchangeRate;
            this.PaymentTypeId = PaymentTypeId;
            this.CurrentOutstandingAmount = CurrentOutstandingAmount;
            this.CheckbookNumber = CheckbookNumber;
            this.SellerRate = SellerRate;
            this.SellerId = SellerId;
            this.CurrentOwedAmount = currentOwedAmount;
        }
        public long CustomerId { get; set; }
        [NotMapped]

        [Export(Order =14 )]
        public int DaysCount
        {
            get
            {
                return Convert.ToInt32((DateTime.Now - this.CreatedDate).TotalDays);
            }
        }
        [NotMapped]
        public decimal CurrentOwedAmount { get; set; }


        [Export(Order =5 )]
        public decimal TotalAmount { get; set; }

        [Export(Order = 4)]
        public decimal PaidAmount { get; set; }

        [Export(Order = 8)]
        public decimal SellerRate { get; set; } = 0;
        public long CurrencyId { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        public long InvoiceCurrencyId { get; set; }

        public long PaymentTypeId { get; set; }
        [MaxLength(50)]

        [Export(Order = 9)]
        public string InvoiceNumber { get; set; }

        [Export(Order = 7)]
        public decimal ExchangeRate { get; set; }

        [Export(Order = 6)]
        public decimal OutstandingAmount { get; set; }
        [MaxLength(50)]

        [Export(Order =1 )]
        public string Sequence { get; set; }
        [MaxLength(50)]

        [Export(Order =10 )]
        public string CheckbookNumber { get; set; }
        public long? SellerId { get; set; }

        public long? InvoiceId { get; set; }

        [MaxLength(200)]

        [Export(Order = 11)]
        public string Details { get; set; }

        [Export(Order = 100)]
        public char State { get; set; } = 'P';

        [ForeignKey("CurrencyId")]

        [Export(Order = 3, ChildProperty ="Code")]
        public Currency Currency { get; set; }
        [ForeignKey("SellerId")]

        [Export(Order = 12, ChildProperty ="NameAndCode")]
        public Seller Seller { get; set; }
        [ForeignKey("InvoiceCurrencyId")]

        [Export(Order = 13, ChildProperty ="InvoiceNumber")]
        public Currency InvoiceCurrency { get; set; }
        [ForeignKey("CustomerId")]

        [Export(Order = 2, ChildProperty ="NameAndCode")]
        public Customer Customer { get; set; }

        [NotMapped]
        public decimal CurrentOutstandingAmount { get; set; }

        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }

        [Export(Order = 0)]
        public DateTime Date { get; set; }


        [NotMapped]
        public string Name { get; set; }

     [NotMapped]
        public string PaymentTypeName { get; set; }



    }
}
