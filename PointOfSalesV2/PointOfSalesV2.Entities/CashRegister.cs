using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class CashRegister : CommonData
    {


        public long LocationId { get; set; }
        [MaxLength(3)]
        public string Code { get; set; }
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

        [ForeignKey("LocationId")]
        public BranchOffice Location { get; set; }

    }
}
