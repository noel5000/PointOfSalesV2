using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CompositeProductRepository : Repository<CompositeProduct>, ICompositeProductRepository
    {
        public CompositeProductRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<CompositeProduct> GetDerivedProducts(long productId)
        {
            return base._Context.CompositeProducts.AsNoTracking().Where(x => x.Active == true && x.BaseProductId == productId);
        }

        public IEnumerable<CompositeProduct> GetProductBases(long productId)
        {
            return _Context.CompositeProducts.AsNoTracking().Where(x => x.Active == true && x.ProductId == productId);
        }
    }
}
