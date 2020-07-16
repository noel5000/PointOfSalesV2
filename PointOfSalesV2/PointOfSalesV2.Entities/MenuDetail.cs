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
    public class MenuDetail : CommonData, IDetailEntity
    {
        public long BranchOfficeId { get; set; }
        public long? WarehouseId { get; set; }
        public long ProductId { get; set; }
        [Export(Order = 2)]
        public decimal Quantity { get; set; }
      
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
       

        public long MenuId { get; set; }

        [Export(Order = 6)]
        public decimal BeforeTaxesAmount { get; set; }
        [MaxLength(200)]
        [Export(Order =12 )]
        public string Comments { get; set; }

        [Export(Order =8 )]
        public decimal PrincipalCurrencyAmount { get; set; }
      



        public Nullable<long> ParentId { get; set; }

        public Nullable<long> UnitId { get; set; }

        public bool Equals(MenuDetail other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId && this.Quantity == other.Quantity && this.Amount == other.Amount && this.Cost == other.Cost &&
                this.UnitId == other.UnitId && this.TaxesAmount == other.TaxesAmount && this.BeforeTaxesAmount == other.BeforeTaxesAmount && this.TotalAmount == other.TotalAmount &&
                this.MenuId == other.MenuId &&  this.ParentId == other.ParentId && 
                this.Active == other.Active && this.CreatedDate == other.CreatedDate);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;

                hashCode = (hashCode * 397) ^ this.ProductId;



                hashCode = this.UnitId.HasValue ? (hashCode * 397) ^ this.UnitId.Value : hashCode;
                hashCode = this.ParentId.HasValue ? (hashCode * 397) ^ this.ParentId.Value : hashCode;
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

             

                var hashCodeDecimal9 = this.Cost.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal9;

                return Convert.ToInt32( hashCode);
            }
        }


        [ForeignKey("ProductId")]
        [Export(Order = 1, ChildProperty ="Name")]
        public Product Product { get; set; }



        [ForeignKey("UnitId")]
        [Export(Order = 13, ChildProperty ="Name")]
        public Unit Unit { get; set; }


        [ForeignKey("MenuId")]
        [Export(Order =0 ,ChildProperty = "Sequence")]
        public Menu Menu { get; set; }


    }

}

