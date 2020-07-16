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
    public class ExpenseTax : CommonData,IEquatable<ExpenseTax>

    {


        public long ExpenseId { get; set; }
        public long CurrencyId { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        public long TaxId { get; set; }
        [MaxLength(50)]
        public string Reference { get; set; }
        [MaxLength(50)]
        public string TRN { get; set; }
        public DateTime Date { get; set; }
        public decimal TaxAmount { get; set; }

        public decimal ExchangeRateAmount { get; set; }


        [NotMapped]
        public decimal PaidAmount { get; set; }

        [NotMapped]
        public decimal TotalAmount { get; set; }





        public bool Equals(ExpenseTax other)
        {
            return (this.Id == other.Id && this.ExpenseId == other.ExpenseId && this.TaxId == other.TaxId && this.TaxAmount == other.TaxAmount &&
                this.Active == other.Active && this.CreatedDate == other.CreatedDate);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;
                hashCode = (hashCode * 397) ^ this.TaxId;
                hashCode = (hashCode * 397) ^ this.ExpenseId;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Active);
                var hashCodeDecimal = this.TaxAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                return Convert.ToInt32(hashCode);
            }
        }

       




        [ForeignKey("TaxId")]
        public Tax Tax { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }


        [ForeignKey("ExpenseId")]
        public Expense Expense { get; set; }


    }
}
