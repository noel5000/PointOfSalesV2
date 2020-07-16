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

        [Export(Order = 0)]
        public long InvoiceId { get; set; }

        [Export(Order = 1)]
        public long CurrencyId { get; set; }

        [Export(Order = 2)]
        public long TaxId { get; set; }

        [MaxLength(50)]
        [Export(Order = 3)]
        public string InvoiceNumber { get; set; }

        [MaxLength(50)]
        [Export(Order = 4)]
        public string TRN { get; set; }

        [Export(Order = 5)]
        public DateTime Date { get; set; }

        [Export(Order = 6)]
        public decimal TaxAmount { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        [Export(Order = 7, ChildProperty = "Name")]
        [ForeignKey("TaxId")]
        public Tax Tax { get; set; }

        [Export(Order = 8, ChildProperty = "Code")]
        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [NotMapped]
        [Export(Order = 9)]
        public decimal PaidAmount { get; set; }

        [NotMapped]
        [Export(Order = 10)]
        public decimal TotalAmount { get; set; }

        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }






        public bool Equals(InvoiceTax other)
        {
            return (this.Id == other.Id && this.InvoiceId == other.InvoiceId && this.TaxId == other.TaxId && this.TaxAmount == other.TaxAmount &&
                this.Active == other.Active && this.CreatedDate == other.CreatedDate && this.Date == other.Date);
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

                return Convert.ToInt32(hashCode);
            }
        }
    }
}
