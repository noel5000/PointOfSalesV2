using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
   public class UnitProductEquivalence: CommonData, IEquatable<UnitProductEquivalence>, IEqualityComparer<UnitProductEquivalence>
    {
        public long ProductId { get; set; }

        public long UnitId { get; set; }
        public decimal Equivalence { get; set; }
        public bool IsPrimary { get; set; }
        public int Order { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }


        public decimal CostPrice { get; set; }

        public decimal SellingPrice { get; set; }

        public bool Equals(UnitProductEquivalence other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId && this.Equivalence == other.Equivalence && this.CostPrice == other.CostPrice &&
                this.UnitId == other.UnitId && this.SellingPrice == other.SellingPrice && this.Active == other.Active);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.UnitId;

                var hashCodeDecimal = this.Equivalence.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                var hashCodeDecimal2 = this.CostPrice.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal2;

                var hashCodeDecimal3 = this.SellingPrice.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal3;




                return Convert.ToInt32( hashCode);
            }
        }

        public bool Equals([AllowNull] UnitProductEquivalence x, [AllowNull] UnitProductEquivalence y)
        {
            return (x.Id == y.Id && x.ProductId == y.ProductId && x.Equivalence == y.Equivalence && x.CostPrice == y.CostPrice &&
                x.UnitId == y.UnitId && x.SellingPrice == y.SellingPrice && x.Active == y.Active);
        }

        public int GetHashCode([DisallowNull] UnitProductEquivalence obj)
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.UnitId;

                var hashCodeDecimal = this.Equivalence.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                var hashCodeDecimal2 = this.CostPrice.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal2;

                var hashCodeDecimal3 = this.SellingPrice.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal3;




                return Convert.ToInt32(hashCode);
            }
        }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public IEnumerable<CompositeProduct> CompositeProducts { get; set; }


    }
}
