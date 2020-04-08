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
    public class Payment : CommonData
    {
        public Payment() { }

        public Payment(int CustomerId, int CurrencyId, int InvoiceCurrencyId, int PaymentTypeId, decimal TotalAmount, decimal PaidAmount, string InvoiceNumber, decimal ExchangeRate, decimal OwedAmount,
            string Sequence, string Details, DateTime CreatedDate, Guid CreatedBy, bool Active, decimal CurrentOwedAmount, string ReceiptNumber, decimal SellerPercentage = 0, int? SellerId = null)
        {
            this.Active = Active;
            this.CustomerId = CustomerId;
            this.CreatedBy = CreatedBy;
            this.Details = Details;
            this.CreatedDate = CreatedDate;
            this.InvoiceCurrencyId = InvoiceCurrencyId;
            this.CurrencyId = CurrencyId;
            this.PaidAmount = PaidAmount;
            this.OwedAmount = OwedAmount;
            this.TotalAmount = TotalAmount;
            this.InvoiceNumber = InvoiceNumber;
            this.Sequence = Sequence;
            this.ExchangeRate = ExchangeRate;
            this.PaymentTypeId = PaymentTypeId;
            this.CurrentOwedAmount = CurrentOwedAmount;
            this.ReceiptNumber = ReceiptNumber;
            this.SellerPercentage = SellerPercentage;
            this.SellerId = SellerId;
        }
        public long CustomerId { get; set; }
        [NotMapped]
        [Export(Order = 15)]
        public int DaysCount
        {
            get
            {
                return Convert.ToInt32((DateTime.Now - this.CreatedDate).TotalDays);
            }
        }

        [Export(Order = 7)]
        public decimal TotalAmount { get; set; }
        [Export(Order = 6)]
        public decimal PaidAmount { get; set; }
        [Export(Order = 9)]
        public decimal SellerPercentage { get; set; } = 0;
        public long CurrencyId { get; set; }
        public long InvoiceCurrencyId { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        public long PaymentTypeId { get; set; }
        [MaxLength(50)]
        [Export(Order = 0)]
        public string InvoiceNumber { get; set; }
        [Export(Order = 3)]
        public decimal ExchangeRate { get; set; }
        [Export(Order = 8)]
        public decimal OwedAmount { get; set; }
        [MaxLength(50)]
        [Export(Order = 3)]
        public string Sequence { get; set; }
        [MaxLength(50)]
        [Export(Order = 3)]
        public string ReceiptNumber { get; set; }
        public long? SellerId { get; set; }


        [Export(Order = 1)]
        public DateTime Date { get; set; }


        [MaxLength(200)]
        [Export(Order = 14)]
        public string Details { get; set; }





        [ForeignKey("CurrencyId")]
        [Export(Order = 4, ChildProperty ="Name")]
        public Currency Currency { get; set; }

        [ForeignKey("SellerId")]
        [Export(Order = 11, ChildProperty ="NameAndCode")]
        public Seller Seller { get; set; }

        [ForeignKey("InvoiceCurrencyId")]
        [Export(Order = 5,ChildProperty ="Name")]
        public Currency InvoiceCurrency { get; set; }
        [ForeignKey("CustomerId")]
        [Export(Order = 12, ChildProperty ="NameAndCode")]
        public Customer Customer { get; set; }


        [ForeignKey("PaymentTypeId")]
        [Export(Order =13, ChildProperty ="Name")]
        public PaymentType PaymentType { get; set; }

        [NotMapped]
        public decimal CurrentOwedAmount { get; set; }


      
    }
}
