using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities
{
    public class InvoicesPaymentModel
    {
        public PaymentModelInfo Payment { get; set; }
        public Guid UserId { get; set; }
        public List<Invoice> Invoices { get; set; }
    }

    public class PaymentModelInfo
    {
        public string Details { get; set; }
        public string Reference { get; set; }
        public long BranchOfficeId { get; set; }
        public long CustomerId { get; set; }
        public long CurrencyId { get; set; }
        public decimal GivenAmount { get; set; }
        public decimal PositiveBalance { get; set; }
        public long PaymentTypeId { get; set; }

    }
}
