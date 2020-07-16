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
    public class InvoiceLead : CommonData
    {

        public InvoiceLead() { }

        public InvoiceLead(InvoiceLead newInvoice)
        {
            this.Id = newInvoice.Id;
            this.Active = newInvoice.Active;
            this.School = newInvoice.School ?? null;
            this.Customer = newInvoice.Customer ?? null;
            this.CustomerId = newInvoice.CustomerId;
            this.SchoolId = newInvoice.SchoolId;
            this.CreatedBy = newInvoice.CreatedBy;
            this.Details = newInvoice.Details ?? null;
            this.LeadDetails = newInvoice.LeadDetails ?? new List<LeadDetail>();
            this.State = newInvoice.State;
            this.CreatedDate = newInvoice.CreatedDate;
            this.BillingDate = newInvoice.BillingDate;
            this.ModifiedDate = newInvoice.ModifiedDate;
            this.BranchOffice = newInvoice.BranchOffice ?? null;
            this.BranchOfficeId = newInvoice.BranchOfficeId;
            this.ModifiedBy = newInvoice.ModifiedBy;
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
            this.DiscountAmount = newInvoice.DiscountAmount;
            this.AppliedCreditNoteAmount = newInvoice.AppliedCreditNoteAmount;
            this.Details = newInvoice.Details;
            this.DiscountRate = newInvoice.DiscountRate;
            this.WarehouseId = newInvoice.WarehouseId;
            this.DocumentNumber = newInvoice.DocumentNumber ?? null;
            this.CashRegisterId = newInvoice.CashRegisterId ?? null;
            this.SellerRate = newInvoice.SellerRate;
            this.SellerId = newInvoice.SellerId ?? null;
            this.ZoneId = newInvoice.ZoneId;
            this.Cost = newInvoice.Cost;
            this.Seller = newInvoice.Seller ?? null;
            this.Zone = newInvoice.Zone ?? null;
        }

        public long SchoolId { get; set; }

        public long CustomerId { get; set; }

        [MaxLength(50)]
        public string TRN { get; set; } = "";

        public long ZoneId { get; set; }
        [MaxLength(50)]
        [Export(Order = 8)]
        public string DocumentNumber { get; set; }
        [Export(Order = 1)]
        public decimal DiscountRate { get; set; }
        public long? SellerId { get; set; }

        public long? WarehouseId { get; set; }

        public long? InvoiceId { get; set; }
        [Export(Order = 9)]
        public decimal SellerRate { get; set; } = 0;
        public long? CashRegisterId { get; set; }
        [NotMapped]
        public bool EnoughInventory { get; set; }

        public bool InventoryModified { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }


        [Export(Order = 10)]
        public decimal ReturnedAmount { get; set; }
        [Export(Order = 11)]

        public decimal ReceivedAmount { get; set; }
        [Export(Order = 12)]
        public decimal Cost { get; set; }

        [Export(Order = 6)]

        public decimal OwedAmount { get; set; }
        [Export(Order = 3)]
        public decimal DiscountAmount { get; set; }
        [Export(Order = 3)]
        public decimal AppliedCreditNoteAmount { get; set; }

        [NotMapped]
        public Enums.BillingStates BillingState
        {
            get
            {
                return (Enums.BillingStates)this.State;
            }
        }

        public long BranchOfficeId { get; set; }
        [MaxLength(50)]
        [Export(Order = 14)]
        public string InvoiceNumber { get; set; }

        public long? MenuId { get; set; }
        public long CurrencyId { get; set; }
        [Export(Order = 5)]
        public decimal TotalAmount { get; set; }

        [Export(Order = 6)]
        public decimal PaidAmount { get; set; }

        [Export(Order = 7)]
        public char State { get; set; }
        [Export(Order = 0)]
        public DateTime? BillingDate { get; set; }
        [Export(Order = 0)]
        public DateTime Date { get; set; }
        [Export(Order = 4)]
        public decimal TaxesAmount { get; set; }

        [MaxLength(200)]
        [Export(Order = 15)]
        public string Details { get; set; }
        [Export(Order = 3)]

        public decimal BeforeTaxesAmount { get; set; }




        [ForeignKey("CurrencyId")]
        [Export(Order = 2, ChildProperty = "Code")]
        public Currency Currency { get; set; }
        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }

        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }

        [ForeignKey("SellerId")]
        [Export(Order = 16, ChildProperty = "NameAndCode")]
        public Seller Seller { get; set; }
        [ForeignKey("ZoneId")]
        [Export(Order = 17, ChildProperty = "Name")]
        public Zone Zone { get; set; }

        [ForeignKey("SchoolId")]
        [Export(Order = 18, ChildProperty = "Name")]
        public School School { get; set; }


        [ForeignKey("CustomerId")]
        [Export(Order = 19, ChildProperty = "NameAndCode")]
        public Customer Customer { get; set; }

        public byte WeekNumber { get; set; } = 0;

        public DayOfWeek DayOfWeek { get; set; }

        [ForeignKey("BranchOfficeId")]
        [Export(Order = 20, ChildProperty = "Name")]
        public BranchOffice BranchOffice { get; set; }


        public virtual List<LeadDetail> LeadDetails { get; set; }


        [NotMapped]
        [Export(Order = 21)]
        public int DaysAmountBilled
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
        [Export(Order = 21)]
        public int DaysAmount
        {
            get
            {
                if (this.Date.Year > DateTime.MinValue.Year)
                    return Convert.ToInt32((DateTime.Now - this.Date).TotalDays);
                else
                    return 0;
            }
        }

    }

}

