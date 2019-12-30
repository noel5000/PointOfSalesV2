using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Warehouse : CommonData
    {
        public long BranchOfficeId { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

        public List<Inventory> Inventory { get; set; }
        [ForeignKey("BranchOfficeId")]
        public BranchOffice BranchOffice { get; set; }
    }
}
