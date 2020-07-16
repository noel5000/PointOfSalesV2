using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities
{
 public   class SchoolYearLeadsEntry
    {
        public DateTime Date { get; set; }
        public List<InvoiceLead> Leads { get; set; }
    }
}
