using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class InvoiceTax : CommonData, IEquatable<InvoiceTax>
    {


        public long InvoiceId { get; set; }
        public long CurrencyId { get; set; }
        public long TaxId { get; set; }
        [MaxLength(50)]
        public string InvoiceNumber { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TaxAmount { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        [ForeignKey("TaxId")]
        public Tax Tax { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }


      



        public bool Equals(InvoiceTax other)
        {
            return (this.Id == other.Id && this.InvoiceId == other.InvoiceId && this.TaxId == other.TaxId && this.TaxAmount == other.TaxAmount &&
                this.Active == other.Active && this.CreatedDate == other.CreatedDate);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.TaxId;
                hashCode = (hashCode * 397) ^ this.InvoiceId;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Active);
                var hashCodeDecimal = this.TaxAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                return Convert.ToInt32( hashCode);
            }
        }
    }
}
