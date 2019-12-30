using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Zone : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }
        public string Details { get; set; }



    }
}
