using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PointOfSalesV2.Common;
using System.Runtime.Serialization;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Entities
{
    public class Invoice : CommonData
    {

        public Invoice() { }

        public Invoice(Invoice newInvoice)
        {
            this.Id = newInvoice.Id;
            this.Active = newInvoice.Active;
            this.Customer = newInvoice.Customer ?? null;
            this.CustomerId = newInvoice.CustomerId;
            this.CreatedBy = newInvoice.CreatedBy;
            this.Details = newInvoice.Details ?? null;
            this.WarehouseId = newInvoice.WarehouseId;
            this.InvoiceDetails = newInvoice.InvoiceDetails;
            this.State = newInvoice.State;
            this.CreatedDate = newInvoice.CreatedDate;
            this.BillingDate = newInvoice.BillingDate;
            this.ModifiedDate = newInvoice.ModifiedDate;
            this.BranchOffice = newInvoice.BranchOffice ?? null;
            this.BranchOfficeId = newInvoice.BranchOfficeId;
            this.ModifiedBy = newInvoice.ModifiedBy ;
            this.Currency = newInvoice.Currency ?? null;
            this.CurrencyId = newInvoice.CurrencyId;
            this.OwedAmount = newInvoice.OwedAmount;
            this.ReturnedAmount = newInvoice.ReturnedAmount;
            this.BeforeTaxesAmount = newInvoice.BeforeTaxesAmount;
            this.TaxesAmount = newInvoice.TaxesAmount;
            this.PaidAmount = newInvoice.PaidAmount;
            this.ReceivedAmount = newInvoice.ReceivedAmount;
            this.TotalAmount = newInvoice.TotalAmount;
            this.InvoiceNumber = newInvoice.InvoiceNumber ?? null;
            this.Payments = newInvoice.Payments ?? new List<CustomerPayment>();
            this.DiscountAmount = newInvoice.DiscountAmount;
            this.AppliedCreditNoteAmount = newInvoice.AppliedCreditNoteAmount;
            this.Details = newInvoice.Details;
            this.DiscountRate = newInvoice.DiscountRate;
            this.TRN = newInvoice.TRN;
            this.TRNType = newInvoice.TRNType;
            this.TRNControl = newInvoice.TRNControl ?? null;
            this.NRC = newInvoice.NRC;
            this.DocumentNumber = newInvoice.DocumentNumber ?? null;
            this.CashRegisterId = newInvoice.CashRegisterId ?? null;
            this.SellerRate = newInvoice.SellerRate;
            this.SellerId = newInvoice.SellerId ?? null;
            this.Cost = newInvoice.Cost;
            this.Seller = newInvoice.Seller ?? null;
            this.TRNControlId = newInvoice.TRNControlId;
            this.AppliedCreditNote = newInvoice.AppliedCreditNote;
            this.Taxes = newInvoice.Taxes ?? new List<InvoiceTax>();
            this.Month = newInvoice.Month;
            this.ExchangeRate = newInvoice.ExchangeRate;
            this.PaidDate = newInvoice.PaidDate;
            this.InventoryModified = newInvoice.InventoryModified;
            this.CurrentPaidAmount = newInvoice.CurrentPaidAmount;
        }

        public DateTime InitialDate 
        {
            get 
            {
                return this.CreatedDate;
            }
        }

        public override DateTime CreatedDate { get; set; }
        public long CustomerId { get; set; }
        public decimal ExchangeRate { get; set; }
        public long? WarehouseId { get; set; }

        [MaxLength(50)]
        [Export(Order = 23)]
        public string DocumentNumber { get; set; }
        [Export(Order = 15)]
        public decimal DiscountRate { get; set; }
        public long? SellerId { get; set; }
        [Export(Order = 22)]

        public decimal SellerRate { get; set; } = 0;

       
        public bool InventoryModified { get; set; }
        public DateTime? PaidDate { get; set; }
        public long? CashRegisterId { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        [Export(Order = 14)]

        public decimal ReturnedAmount { get; set; }
        [NotMapped]
        public decimal CurrentPaidAmount { get; set; }

        [Export(Order =13 )]
        public decimal ReceivedAmount { get; set; }
        [Export(Order =16 )]
        public decimal Cost { get; set; }


        [Export(Order = 12)]
        public decimal OwedAmount { get; set; }
        [Export(Order = 8)]
        public decimal DiscountAmount { get; set; }
        public Month Month { get; set; }
        [Export(Order = 9)]
        public decimal AppliedCreditNoteAmount { get; set; }
        [MaxLength(100)]
        [Export(Order =21 )]
        public string NRC { get; set; }


        public long BranchOfficeId { get; set; }
        [MaxLength(50)]
        [Export(Order =1 )]
        public string InvoiceNumber { get; set; }
        public long CurrencyId { get; set; }
        [Export(Order = 10)]
        public decimal TotalAmount { get; set; }
        [MaxLength(50)]
        [Export(Order =19 )]
        public string TRN { get; set; }
        [MaxLength(2)]
        [Export(Order =18 )]
        public string TRNType { get; set; }
        public long TRNControlId { get; set; }
        [Export(Order = 11)]
        public decimal PaidAmount { get; set; }

        [Export(Order = 17)]
        public char State { get; set; }
        [Export(Order = 0)]
        public DateTime? BillingDate { get; set; }
        [Export(Order = 7)]
        public decimal TaxesAmount { get; set; }

        [MaxLength(200)]
        [Export(Order = 20)]
        public string Details { get; set; }

        [Export(Order = 6)]
        public decimal BeforeTaxesAmount { get; set; }

        [NotMapped]
        public Enums.BillingStates BillingState 
        {
            get 
            {
                return  (Enums.BillingStates)this.State;
            }
        }


        [ForeignKey("CurrencyId")]
        [Export(Order =5,ChildProperty ="Code" )]
        public Currency Currency { get; set; }

        [ForeignKey("SellerId")]
        [Export(Order =4, ChildProperty ="NameAndCode" )]
        public Seller Seller { get; set; }


        [ForeignKey("TRNControlId")]
        [Export(Order =3, ChildProperty ="Name" )]
        public TRNControl TRNControl { get; set; }

        [ForeignKey("CustomerId")]
        [Export(Order =2, ChildProperty ="NameAndCode" )]
        public Customer Customer { get; set; }

        [ForeignKey("BranchOfficeId")]
        [Export(Order = 24, ChildProperty ="Name")]
        public BranchOffice BranchOffice { get; set; }

        public virtual  List<CustomerPayment> Payments { get; set; }

        public virtual List<InvoiceTax> Taxes { get; set; }
        public virtual List<InvoiceDetail> InvoiceDetails { get; set; }


        [NotMapped]
        [Export(Order =25 )]
        public int DaysAmount
        {
            get
            {
                if (this.BillingDate.HasValue && this.BillingDate.Value.Year > DateTime.MinValue.Year)
                    return Convert.ToInt32((DateTime.Now - this.BillingDate.Value).TotalDays);
                else
                    return 0;
            }
        }

      [NotMapped]
        public string AppliedCreditNote { get; set; }








    }
}
