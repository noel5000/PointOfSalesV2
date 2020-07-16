using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IExpensesPaymentRepository : IBase<ExpensesPayment>
    {
        Result<Payment> AddPayment(CompanyPayments payment, List<Expense> expenses); 
    }
}
