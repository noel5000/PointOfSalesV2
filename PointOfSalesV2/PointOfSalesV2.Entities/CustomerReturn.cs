using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class CustomerReturn : CommonData
    {

        public Invoice Invoice { get; set; }


        public List<ReturnDetail> ReturnDetails { get; set; }






    }
}
