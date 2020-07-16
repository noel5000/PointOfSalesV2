using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Diagnostics.CodeAnalysis;
using NPOI.OpenXmlFormats.Dml.Diagram;

namespace PointOfSalesV2.Entities
{
    public class LeadDetail : CommonData, IDetailEntity, IEquatable<LeadDetail>, IEqualityComparer<LeadDetail>
    {
        public LeadDetail() { }

        public LeadDetail(LeadDetail newDetail)
        {
            this.Id = newDetail.Id;
            this.ProductId = newDetail.ProductId;
            this.Product = newDetail.Product ?? null;
            this.Active = newDetail.Active;
            this.WarehouseId = newDetail.WarehouseId ?? null;
            this.Quantity = newDetail.Quantity;
            this.Comments = newDetail.Comments;
            this.CreatedBy = newDetail.CreatedBy;
            this.InvoiceLeadId = newDetail.InvoiceLeadId;
            this.Date = newDetail.Date;
            this.CreatedDate = newDetail.CreatedDate;
            this.ModifiedDate = newDetail.ModifiedDate;
            this.ModifiedBy = newDetail.ModifiedBy;
            this.Amount = newDetail.Amount;
            this.PrincipalCurrencyAmount = newDetail.PrincipalCurrencyAmount;
            this.BeforeTaxesAmount = newDetail.BeforeTaxesAmount;
            this.TaxesAmount = newDetail.TaxesAmount;
            this.TotalAmount = newDetail.TotalAmount;
            this.Unit = newDetail.Unit ?? null;
            this.UnitId = newDetail.UnitId ?? null;
            this.DiscountAmount = newDetail.DiscountAmount;
            this.CreditNoteAmount = newDetail.CreditNoteAmount;
            this.ParentId = newDetail.ParentId;
            this.SaveRegister = newDetail.SaveRegister;
            this.DiscountRate = newDetail.DiscountRate;
            this.Free = newDetail.Free;
            this.SellerRate = newDetail.SellerRate;
            this.Cost = newDetail.Cost;
            this.ReturnAmount = newDetail.ReturnAmount;
            this.Defective = newDetail.Defective;
        }
        [NotMapped]
        public bool Defective { get; set; }
        [NotMapped]
        public decimal ReturnAmount { get; set; }

        public long BranchOfficeId { get; set; }

        public long ProductId { get; set; }
        [Export(Order = 2)]
        public decimal Quantity { get; set; }
        [Export(Order = 18)]
        public decimal SellerRate { get; set; } = 0;
        [Export(Order = 7)]
        public decimal Cost { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        [Export(Order =4 )]
        public decimal Amount { get; set; }
        [Export(Order = 5)]
        public decimal TaxesAmount { get; set; }
        [Export(Order =7 )]
        public decimal TotalAmount { get; set; }
        public bool Free { get; set; }
        [Export(Order = 3)]
        public DateTime Date { get; set; }

        public long InvoiceLeadId { get; set; }

        [Export(Order = 6)]
        public decimal BeforeTaxesAmount { get; set; }
        [MaxLength(200)]
        [Export(Order =12 )]
        public string Comments { get; set; }

        [Export(Order =8 )]
        public decimal PrincipalCurrencyAmount { get; set; }
        [Export(Order = 9)]
        public decimal DiscountRate { get; set; }

        public Nullable<long> WarehouseId { get; set; }



        [Export(Order =10 )]
        public decimal DiscountAmount { get; set; }
        [Export(Order =11 )]
        public decimal CreditNoteAmount { get; set; }

        public Nullable<long> ParentId { get; set; }

        public Nullable<long> UnitId { get; set; }

        public bool Equals(LeadDetail other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId && this.Quantity == other.Quantity && this.Amount == other.Amount && this.Cost == other.Cost &&
                this.UnitId == other.UnitId && this.TaxesAmount == other.TaxesAmount && this.BeforeTaxesAmount == other.BeforeTaxesAmount && this.TotalAmount == other.TotalAmount &&
                this.InvoiceLeadId == other.InvoiceLeadId && this.CreditNoteAmount == other.CreditNoteAmount && this.DiscountAmount == other.DiscountAmount && this.DiscountRate == other.DiscountRate
                && this.Free == other.Free && this.ParentId == other.ParentId && this.WarehouseId == other.WarehouseId &&
                this.Active == other.Active && this.Date == other.Date && this.CreatedDate == other.CreatedDate);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^Convert.ToInt32( this.Id);

                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.ProductId);
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.InvoiceLeadId);



                hashCode = this.UnitId.HasValue ? (hashCode * 397) ^ this.UnitId.Value : hashCode;
                hashCode = this.ParentId.HasValue ? (hashCode * 397) ^ this.ParentId.Value : hashCode;
                hashCode = this.WarehouseId.HasValue ? (hashCode * 397) ^ this.WarehouseId.Value : hashCode;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Active);

                var hashCodeDecimal = this.Quantity.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                var hashCodeDecimal2 = this.Amount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal2;

                var hashCodeDecimal3 = this.BeforeTaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal3;

                var hashCodeDecimal4 = this.TaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal4;

                var hashCodeDecimal5 = this.TotalAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal5;

                var hashCodeDecimal6 = this.DiscountAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal6;

                var hashCodeDecimal7 = this.CreditNoteAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal7;

                var hashCodeDecimal8 = this.DiscountRate.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal8;

                var hashCodeDecimal9 = this.Cost.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal9;

                return Convert.ToInt32( hashCode);
            }
        }

        public bool Equals([AllowNull] LeadDetail x, [AllowNull] LeadDetail y)
        {
            return x.Id == y.Id && x.ProductId == y.ProductId && x.UnitId == y.UnitId && x.Quantity == y.Quantity;
        }

        public int GetHashCode([DisallowNull] LeadDetail obj)
        {
          return  GetHashCode(obj);
        }

        [ForeignKey("ProductId")]
        [Export(Order = 1, ChildProperty ="Name")]
        public Product Product { get; set; }



        [ForeignKey("UnitId")]
        [Export(Order = 13, ChildProperty ="Name")]
        public Unit Unit { get; set; }


        [ForeignKey("InvoiceLeadId")]
        [Export(Order =0 ,ChildProperty ="DocumentNumber")]
        public InvoiceLead Lead { get; set; }

        [NotMapped]
        public bool SaveRegister { get; set; } = true;

    }

}

