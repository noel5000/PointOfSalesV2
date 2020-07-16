using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface ICustomerBalanceRepository: IBase<CustomerBalance>
    {
        CustomerBalance CustomerBalanceByCurrency(long customerId, long currencyId);

        CustomerStateReport CustomerState(long customerId);
    }
}
