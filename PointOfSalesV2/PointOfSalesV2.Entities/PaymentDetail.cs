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
    public class PaymentDetail : CommonData
    {

        public long PaymentId { get; set; }
        public long InvoiceId { get; set; }
        [Export(Order = 3)]
        public decimal TotalAmount { get; set; }
        [Export(Order = 2)]
        public decimal PaidAmount { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        [Export(Order = 4)]
        public decimal OwedAmount { get; set; }
        [Export(Order = 5)]
        public DateTime BillingDate { get; set; }

        [ForeignKey("InvoiceId")]
        [Export(Order =0,ChildProperty = "InvoiceNumber")]
        public Invoice Invoice { get; set; }

        [ForeignKey("PaymentId")]
        [Export(Order = 1, ChildProperty = "Sequence")]
        public Payment Payment { get; set; }






    }
}
