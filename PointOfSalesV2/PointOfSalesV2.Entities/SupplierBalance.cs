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
    public class SupplierBalance : CommonData
    {

        public long SupplierId { get; set; }

        public long CurrencyId { get; set; }

        public decimal OwedAmount { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }




    }
}
