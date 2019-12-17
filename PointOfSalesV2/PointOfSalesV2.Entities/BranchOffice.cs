using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class BranchOffice : CommonData
    {
        public decimal Rate { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Warehouse> Warehouses { get; set; }


    }
}
