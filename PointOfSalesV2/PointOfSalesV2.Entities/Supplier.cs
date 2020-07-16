using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Supplier : CommonData
    {

        [MaxLength(500)]
        [Export(Order = 3)]
        public string Address { get; set; }
        [MaxLength(20)]
        [Export(Order = 2)]
        public string PhoneNumber { get; set; }
        //public int MonedaId { get; set; }
        [MaxLength(20)]
        [Export(Order = 1)]
        public string CardId { get; set; }
        [MaxLength(100)]
        [Export(Order = 0)]
        public string Name { get; set; }
       
        public IEnumerable<ProductSupplierCost> ProductsCosts { get; set; }

       
    }
}
