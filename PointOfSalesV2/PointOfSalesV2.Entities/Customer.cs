using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class Customer : CommonData
    {

        [MaxLength(20)]
        [Export(Order = 3)]
        public string CardId { get; set; }
        [MaxLength(20)]
        [Export(Order = 4)]
        public string PhoneNumber { get; set; }

        public long CurrencyId { get; set; }
        public long TRNControlId { get; set; }

        [MaxLength(200)]
        [Export(Order = 5)]
        public string Address { get; set; }
        [MaxLength(50)]
        [Export(Order = 1)]
        public string Code { get; set; }
        [Export(Order = 6)]
        public long InvoiceDueDays { get; set; }

        [Export(Order = 7)]
        public decimal BillingAmountLimit { get; set; }
        [Export(Order = 8)]
        public decimal CreditAmountLimit { get; set; }

        public long? ZoneId { get; set; }
        public long? WarehouseId { get; set; }


        [MaxLength(100)]
        [Export(Order = 0)]
        public string Name { get; set; }

        [NotMapped]
        [Export(Order = 2)]
        public string NameAndCode { get { return $"{Code ?? ""}  {Name}"; } }



        [ForeignKey("CurrencyId")]
        [Export(Order = 9, ChildProperty = "Code")]
        public Currency Currency { get; set; }


        [ForeignKey("ZoneId")]
        [Export(Order = 12, ChildProperty = "Name")]
        public Zone Zone { get; set; }



        //Tax receipt number -> NCF
        [MaxLength(50)]
        [Export(Order = 10)]
        public string TRNType { get; set; }

        public virtual IEnumerable<CustomerBalance> CustomerBalances {get;set;}


        [ForeignKey("TRNControlId")]
        [Export(Order =11, ChildProperty ="Name" )]
        public TRNControl TRNControl { get; set; }

    }
}
