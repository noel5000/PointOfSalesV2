using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities
{
    public class CompanyStateModel
    {
        [Export(Order = 0)]
        public string Details { get; set; }
        [Export(Order = 1)]
        public DateTime Date { get; set; }
        [Export(Order = 2)]
        public decimal IncomeAmount { get; set; }
        [Export(Order = 3)]
        public decimal OutcomeAmount { get; set; }
        [Export(Order = 4)]
        public string Reference { get; set; }
        [Export(Order = 5)]
        public decimal CompanyOwedAmount { get; set; }
        [Export(Order = 5)]
        public decimal CustomersOwedAmount { get; set; }
        [Export(Order = 6)]
        public long CurrencyId { get; set; }
        [Export(Order = 7)]
        public string CurrencyName { get; set; }
        [Export(Order = 8)]
        public string SellerName { get; set; }
        [Export(Order = 9)]
        public string CustomerName { get; set; }
        public decimal ExchangeRate { get; set; }
        public string CurrencyCode { get; set; }

        public int DaysCount { get 
            {
                return Convert.ToInt32( (DateTime.Now - this.Date).TotalDays);
            } }

    }

    public class CompanyStateReport
    {
        public List<CompanyStateModel> Data { get; set; } = new List<CompanyStateModel>();
        public decimal TotalOutComesAmount { get; set; }
        public decimal TotalIncomesAmount { get; set; }
        public decimal TotalCustomersOwedAmount { get; set; }
        public decimal TotalCompanyOwedAmount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
