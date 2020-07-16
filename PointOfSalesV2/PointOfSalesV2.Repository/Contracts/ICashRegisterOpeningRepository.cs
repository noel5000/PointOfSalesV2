using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface ICashRegisterOpeningRepository : IBase<CashRegisterOpening>
    {
        Result<CashRegisterOpening> Closure(CashRegisterOpening cashRegisterOpening);
    }
}
