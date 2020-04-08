using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class Currency : CommonData
    {
        [MaxLength(3)]
        public string Code { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsLocalCurrency { get; set; }
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }


        public bool UpdatedRate { get; set; } = true;
        public DateTime? RateUpdateDate { get; set; }

    }
}
