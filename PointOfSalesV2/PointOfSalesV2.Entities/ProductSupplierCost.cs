using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PointOfSalesV2.Entities
{
    public class ProductSupplierCost : CommonData, IEquatable<ProductSupplierCost>, IEqualityComparer<ProductSupplierCost>
    {
       public long ProductId { get; set; }
       public long SupplierId { get; set; }
       public decimal Cost { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        public bool Equals([AllowNull] ProductSupplierCost other)
        {
            return other == null ? false : (this.Id==other.Id && this.ProductId==other.ProductId && this.SupplierId==other.SupplierId && this.Cost==other.Cost);
        }

        public bool Equals([AllowNull] ProductSupplierCost x, [AllowNull] ProductSupplierCost y)
        {
            return x == null || y==null ? false : (x.Id == y.Id && x.ProductId == y.ProductId && x.SupplierId == y.SupplierId && x.Cost==y.Cost);
        }

        public int GetHashCode([DisallowNull] ProductSupplierCost obj)
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.SupplierId;
                var hashCodeDecimal = this.Cost.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;
                return Convert.ToInt32(hashCode);
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.SupplierId;

                var hashCodeDecimal = this.Cost.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;
                return Convert.ToInt32(hashCode);
            }
        }
    }
}
