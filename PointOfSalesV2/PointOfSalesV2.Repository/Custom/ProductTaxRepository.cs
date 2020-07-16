using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class ProductTaxRepository : Repository<ProductTax>, IProductTaxRepository
    {
        public ProductTaxRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<ProductTax> GetProductTaxes(long productId)
        {
            return _Context.ProductTaxes.AsNoTracking().Where(x => x.Active == true && x.ProductId == productId);
        }
    }
}
