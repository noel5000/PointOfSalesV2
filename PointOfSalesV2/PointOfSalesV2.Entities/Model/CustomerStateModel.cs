using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities
{
    public class CustomerStateModel
    {
        [Export(Order = 0)]
        public string DocumentNumber { get; set; }
        [Export(Order = 1)]
        public DateTime Date { get; set; }
        [Export(Order = 2)]
        public decimal Debit { get; set; }
        [Export(Order = 3)]
        public decimal Credit { get; set; }
        [Export(Order = 4)]
        public string Reference { get; set; }
        [Export(Order = 5)]
        public decimal Balance { get; set; }
        [Export(Order = 6)]
        public long CurrencyId { get; set; }
        [Export(Order = 7)]
        public string CurrencyName { get; set; }
        [Export(Order = 8)]
        public string SellerName { get; set; }
        [Export(Order = 9)]
        public string CustomerName { get; set; }

    }

    public class CustomerStateReport
    {
        public List<CustomerStateModel> Data { get; set; } = new List<CustomerStateModel>();
        public Customer Customer { get; set; }
        public decimal TotalBilledAmount { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalOwedAmount { get; set; }
    }
}
