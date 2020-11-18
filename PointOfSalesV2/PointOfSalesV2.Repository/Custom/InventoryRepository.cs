using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<Inventory> GetBranchOfficeInventory(long branchOfficeId, long? productId)
        {
            Func<Inventory, bool> func = inventory => inventory.Active == true && (productId.HasValue ? inventory.ProductId == productId.Value : inventory.Id > 0) &&
            inventory.BranchOfficeId == branchOfficeId;

            return _Context.Inventory.Include(x=>x.BranchOffice).Include(x=>x.Product).Include(x=>x.Unit).AsNoTracking().Where(func);
        }

        public IEnumerable<Inventory> GetProductInventory(long productId)
        {
            return _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking().Where(x=>x.Active==true && x.ProductId==productId);
        }

        public IEnumerable<Inventory> GetWarehouseInventory(long warehouseId)
        {
            return _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking().Where(x => x.Active == true && x.WarehouseId == warehouseId);
        }

        public IEnumerable<Inventory> GetWarehouseInventoryByProduct(long warehouseId, long productId)
        {
            return _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking().Where(x => x.Active == true && x.ProductId == productId && x.WarehouseId==warehouseId);
        }
    }
}
