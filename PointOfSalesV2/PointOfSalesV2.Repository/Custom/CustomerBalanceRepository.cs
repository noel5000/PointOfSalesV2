using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class CustomerBalanceRepository : Repository<CustomerBalance>, ICustomerBalanceRepository
    {
        public CustomerBalanceRepository(MainDataContext context) : base(context)
        {
        }

        public CustomerBalance CustomerBalanceByCurrency(long customerId, long currencyId)
        {
            return _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x => x.Active == true && x.CurrencyId == currencyId && x.CustomerId == customerId);
        }
    }
}
