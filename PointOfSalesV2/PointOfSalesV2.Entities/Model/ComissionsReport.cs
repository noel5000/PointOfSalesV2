using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities
{
    public class ComissionsByCurrency
    {
        public string CurrencyCode { get; set; }

        public decimal TotalAmount { get; set; }
        public string CurrencyName { get; set; }
        public List<ComissionDetail> Details { get; set; }
    }

    public class ComissionsSearch
    {
        public int ReportType { get; set; }
        public long? CurrencyId { get; set; }
        public long? SellerId { get; set; }
        public long? CustomerId { get; set; }
        public string InvoiceNumber { get; set; }
        public string StartDate { get; set; } = "0";
        public string EndDate { get; set; } = "0";

        public DateTime? InitialDate
        {
            get
            {
                return this.StartDate == "0" || string.IsNullOrEmpty(this.StartDate) ? null : new DateTime?(Convert.ToDateTime(this.StartDate));
            }
        }

        public DateTime? FinalDate
        {
            get
            {
                return this.EndDate == "0" || string.IsNullOrEmpty(this.EndDate) ? null : new DateTime?(Convert.ToDateTime(this.EndDate));
            }
        }
    }

    public class ComissionDetail
    {
        [Export(Order = 3)]
        public string CurrencyCode { get; set; }

        [Export(Order = 0)]
        public string SellerName { get; set; }

        [Export(Order = 1)]
        public string Reference { get; set; }

        [Export(Order = 2)]
        public DateTime Date { get; set; }

        [Export(Order = 4)]
        public decimal Amount { get; set; }

        [Export(Order = 5)]
        public decimal TotalAmount { get; set; }
        [Export(Order = 6)]
        public decimal BeforeTaxesAmount { get; set; }

        [Export(Order = 7)]
        public decimal PaidAmount { get; set; }

        [Export(Order = 8)]
        public string CustomerName { get; set; }

        [Export(Order = 9)]
        public int DaysAmount
        {
            get
            {
                return Convert.ToInt32((DateTime.Now - this.Date).TotalDays);
            }
        }
    }

    public class ComissionsReport
    {
        public List<ComissionsByCurrency> ComissionsByCyrrencies { get; set; }

    }
}
