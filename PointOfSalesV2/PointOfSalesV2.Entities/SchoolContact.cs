using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class SchoolContact : CommonData
    {

        [MaxLength(20)]
        public string PhoneNumber { get; set; }


        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }

        public long SchoolId { get; set; }

        public virtual School School { get; set; }



    }
}
