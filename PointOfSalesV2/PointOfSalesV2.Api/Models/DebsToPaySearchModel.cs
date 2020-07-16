using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Models
{
    public class DebsToPaySearchModel
    {
        public long? SupplierId { get; set; }
        public long? CurrencyId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? BranchOfficeId { get; set; }
    }
}
