using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using NPOI.OpenXmlFormats.Dml.Diagram;

namespace PointOfSalesV2.Entities
{
    public class Expense : CommonData
    {


        public Expense() { }
        public Expense(Expense obj)
        {
            this.Active = obj.Active;
            this.CreatedBy = obj.CreatedBy;
            this.Details = obj.Details;
            this.State = obj.State;
            this.ExchangeRateAmount = obj.ExchangeRateAmount;
            this.CreatedDate = obj.CreatedDate;
            this.Date = obj.Date;
            this.ModifiedDate = obj.ModifiedDate;
            this.Id = obj.Id;
            this.BranchOffice = obj.BranchOffice ?? null;
            this.BranchOfficeId = obj.BranchOfficeId;
            this.ModifiedBy = obj.ModifiedBy;
            this.Currency = obj.Currency ?? null;
            this.CurrencyId = obj.CurrencyId;
            this.OwedAmount = obj.OwedAmount;
            this.GivenAmount = obj.GivenAmount;
            this.ReturnedAmount = obj.ReturnedAmount;
            this.BeforeTaxesAmount = obj.BeforeTaxesAmount;
            this.TaxesAmount = obj.TaxesAmount;
            this.PaidAmount = obj.PaidAmount;
            this.TotalAmount = obj.TotalAmount;
            this.TRN = obj.TRN;
            this.Name = obj.Name;
            this.ExpenseReference = obj.ExpenseReference;
            this.Supplier = obj.Supplier ?? null;
            this.SupplierId = obj.SupplierId;
            this.PaymentTypeId = obj.PaymentTypeId;
            this.ExchangeRate = obj.ExchangeRate;

        }
     
        public long? PaymentTypeId { get; set; }
        public decimal ExchangeRate { get; set; }

        [NotMapped]
        public string Name { get; set; }

        [MaxLength(200)]
        [Export(Order =13 )]
        public string Details { get; set; }

      
        public List<ExpenseTax> Taxes { get; set; }

        public long SupplierId { get; set; }
        [MaxLength(50)]
        [Export(Order =12 )]
        public string ExpenseReference { get; set; }
        [MaxLength(50)]
        [Export(Order = 0)]
        public string Sequence { get; set; }
        public long CurrencyId { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        [Export(Order =7 )]
        public decimal TotalAmount { get; set; }
        [Export(Order =6 )]
        public decimal PaidAmount { get; set; }
        [Export(Order =11 )]
        public char State { get; set; }
        [Export(Order =1 )]
        public DateTime Date { get; set; }
        [Export(Order = 5)]
        public decimal TaxesAmount { get; set; }
        [Export(Order = 8)]

        public decimal ExchangeRateAmount { get; set; }
        [Export(Order =4 )]
        public decimal BeforeTaxesAmount { get; set; }
        [Export(Order = 4)]
        public decimal ReturnedAmount { get; set; }
        [Export(Order = 4)]
        public decimal GivenAmount { get; set; }
        [Export(Order = 4)]
        public decimal OwedAmount { get; set; }
        public long BranchOfficeId { get; set; }
        [MaxLength(50)]
        [Export(Order = 9)]
        public string TRN { get; set; }

        [NotMapped]
        public decimal CurrentPaidAmount { get; set; }

        public virtual List<ExpensesPayment> Payments { get; set; }

        [ForeignKey("CurrencyId")]
        [Export(Order =3, ChildProperty ="Code" )]
        public Currency Currency { get; set; }
        [ForeignKey("PaymentTypeId")]
        [Export(Order =10, ChildProperty ="Name" )]
        public PaymentType PaymentType { get; set; }

        [ForeignKey("SupplierId")]
        [Export(Order =2, ChildProperty ="Name" )]
        public Supplier Supplier { get; set; }

        [NotMapped]
        [Export(Order = 15)]
        public long NumberOfDays
        {
            get
            {
                if (this.Date.Year > DateTime.MinValue.Year)
                    return Convert.ToInt32((DateTime.Now - this.Date).TotalDays);
                else
                    return 0;
            }
        }

        [ForeignKey("BranchOfficeId")]
        [Export(Order =14, ChildProperty ="Name" )]
        public BranchOffice BranchOffice { get; set; }

    }
}
