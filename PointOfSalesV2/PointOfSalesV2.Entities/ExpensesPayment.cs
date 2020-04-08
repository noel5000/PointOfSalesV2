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
    public class ExpensesPayment : CommonData
    {
        public ExpensesPayment() { }

        public long SupplierId { get; set; }

        [Export(Order =0 )]
        public DateTime Date { get; set; }
        [Export(Order = 8)]
        public decimal TotalAmount { get; set; }
        [Export(Order =7 )]
        public decimal GivenAmount { get; set; }
        [Export(Order =1)]

        [MaxLength(50)]
        public string Sequence { get; set; }
        [Export(Order = 8)]

        public decimal PositiveBalance { get; set; }
        [Export(Order =14 )]
        public char State { get; set; }
        [Export(Order = 6)]
        public decimal PaidAmount { get; set; }
        public long CurrencyId { get; set; }
        public long ExpenseCurrencyId { get; set; }
        public long ExpenseId { get; set; }

        public long PaymentId { get; set; }

        public long PaymentTypeId { get; set; }
        [MaxLength(50)]
        [Export(Order = 11)]
        public string ExpenseReference { get; set; }
        [Export(Order = 9)]
        public decimal ExchangeRate { get; set; }
        [Export(Order =10 )]
        public decimal ExchangeRateAmount { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        [Export(Order = 7)]
        public decimal OutstandingAmount { get; set; }
        [MaxLength(50)]
        [Export(Order = 2)]
        public string PaymentSequence { get; set; }

        [MaxLength(200)]
        [Export(Order =12 )]
        public string Details { get; set; }


        [ForeignKey("CurrencyId")]
        [Export(Order =3, ChildProperty ="Code" )]
        public Currency Currency { get; set; }

        [ForeignKey("ExpenseCurrencyId")]
        [Export(Order = 4,ChildProperty ="Code")]
        public Currency ExpenseCurrency { get; set; }

        [ForeignKey("PaymentId")]
        public CompanyPayments Payment { get; set; }

        [ForeignKey("ExpenseId")]
        public Expense Expense { get; set; }

        [ForeignKey("SupplierId")]
        [Export(Order = 13, ChildProperty ="Name")]
        public Supplier Supplier { get; set; }

        [ForeignKey("PaymentTypeId")]
        [Export(Order =5, ChildProperty ="Name" )]
        public PaymentType PaymentType { get; set; }

        [NotMapped]
        public decimal CurrentOutstandingAmount { get; set; }


        [NotMapped]
        public string Name { get; set; }


    }
}
