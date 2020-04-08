using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Entities
{
    public class CompositeProduct : CommonData, IEquatable<CompositeProduct>
    {

        public long ProductId { get; set; }

        public long BaseProductId { get; set; }
        public long CurrencyId { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        public Nullable<long> BaseProductUnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalPrice { get; set; }
        [ForeignKey("BaseProductId")]
        public Product BaseProduct { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("BaseProductUnitId")]
        public UnitProductEquivalence UnitProductEquivalence { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        public bool Equals(CompositeProduct other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId &&
                this.BaseProductId == other.BaseProductId &&
               ((this.BaseProductUnitId == other.BaseProductUnitId)) && this.Quantity == other.Quantity);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.BaseProductId;
                hashCode = this.BaseProductUnitId.HasValue ? (hashCode * 397) ^ this.BaseProductUnitId.Value : hashCode;

                var hashCodeDecimal = this.Quantity.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;
                return Convert.ToInt32( hashCode);
            }
        }


    }


    public class CustomCompositeProduct : CommonData, IEquatable<CustomCompositeProduct>
    {

        public long ProductId { get; set; }
        public long BaseProductId { get; set; }
        public Nullable<long> BaseProductUnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalPrice { get; set; }
        public string UnitName { get; set; }

        public long BaseProductUnitProductId { get; set; }
        public long BaseProductUnitUnitId { get; set; }
        public decimal UnitProductEquivalence { get; set; }
        public bool IsPrincipal { get; set; }
        public long Order { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string BaseProductName { get; set; }

        public bool Equals(CustomCompositeProduct other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId &&
                this.BaseProductId == other.BaseProductId &&
               ((this.BaseProductUnitId == other.BaseProductUnitId)) && this.Quantity == other.Quantity);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.BaseProductId;
                hashCode = this.BaseProductUnitId.HasValue ? (hashCode * 397) ^ this.BaseProductUnitId.Value : hashCode;

                var hashCodeDecimal = this.Quantity.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;
                return Convert.ToInt32( hashCode);
            }
        }
    }
}
