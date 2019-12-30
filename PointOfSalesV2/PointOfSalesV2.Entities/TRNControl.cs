using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class TRNControl : CommonData
    {
        public char Series { get; set; }
        [MaxLength(2)]
        public string Type { get; set; }
        public long Sequence { get; set; }
        public long NumericControl { get; set; }
        public long Quantity { get; set; }
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

    }
}
