using System;
using System.Collections.Generic;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Entities
{
  public  class InvoiceLeadProjection
    {
        public string SchoolName { get; set; }
        public long Id { get; set; }
        public long SchoolId { get; set; }
        public long MenuId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public bool EnoughExistence { get; set; }
        public byte WeekOfMonth { get; set; }
        public DateTime Date { get; set; }
        public string LeadSequence { get; set; }
        public char State { get; set; } =(char) BillingStates.Projected;
    }
}
