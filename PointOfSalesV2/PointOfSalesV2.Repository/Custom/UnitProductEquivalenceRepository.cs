using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class UnitProductEquivalenceRepository : Repository<UnitProductEquivalence>, IUnitProductEquivalenceRepository
    {
        public UnitProductEquivalenceRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<UnitProductEquivalence> GetProductUnits(long productId)
        {
            return _Context.UnitProductsEquivalences.AsNoTracking().Where(x=>x.Active==true && x.ProductId==productId);
        }
    }
}
