using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Models
{
    public class ExpensesPaymentModel
    {
        public CompanyPayments Payment { get; set; }
        public List<Expense> Expenses { get; set; }

    }
}
