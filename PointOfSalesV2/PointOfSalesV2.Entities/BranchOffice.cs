using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class BranchOffice : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

        public virtual IEnumerable<Warehouse> Warehouses { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
        public virtual IEnumerable<CashRegister> CashRegisters { get; set; }


    }
}
