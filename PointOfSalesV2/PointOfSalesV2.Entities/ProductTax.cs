using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class ProductTax : CommonData, IEquatable<ProductTax>

    {


        public long ProductId { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        public long TaxId { get; set; }


        public bool Equals(ProductTax other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId && this.TaxId == other.TaxId && this.Active == other.Active);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.TaxId;


                return Convert.ToInt32( hashCode);
            }
        }


        [ForeignKey("TaxId")]
        public Tax Tax { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }


    }
}
