using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class UserOperation 
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string OperationName { get; set; }
        public string OperationViewName { get; set; }



    }
}
