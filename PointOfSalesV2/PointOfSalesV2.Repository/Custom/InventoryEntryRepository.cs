using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class InventoryEntryRepository : Repository<InventoryEntry>, IInventoryEntryRepository
    {
        readonly ISequenceManagerRepository sequenceRepo;
        readonly IWarehouseMovementRepository warehouseMovements;
        public InventoryEntryRepository(MainDataContext context,IDataRepositoryFactory repositoryFactory) : base(context)
        {
            this.sequenceRepo = repositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
            this.warehouseMovements = repositoryFactory.GetCustomDataRepositories<IWarehouseMovementRepository>();
        }

        public Result<object> AddInventoryList(List<InventoryEntry> entries, string reference, string details)
        {
            var result = new Result<object>(-1, -1, "error_msg");

            using (var tran = _Context.Database.BeginTransaction())
            {
                try
                {
                    string sequence = sequenceRepo.CreateSequence(SequenceTypes.InventoryIncomes);
                    List<Inventory> inventories = new List<Inventory>();
                    entries.ForEach(e =>
                    {
                        var currency = e.Currency ?? _Context.Currencies.Find(e.CurrencyId);
                        _Context.Entry<Currency>(currency).State = EntityState.Detached;
                        e.ExchangeRate = currency.ExchangeRate;
                        e.Details = details;
                        e.Date = DateTime.Now;
                        e.Reference = reference;
                        e.BeforeTaxAmount = e.ProductCost * e.Quantity;
                        if (e.TaxAmount <= 0 && e.NoTaxes == false) 
                        {
                            throw new Exception("taxIsReq_msg");
                        }
                        e.TotalAmount = e.TaxAmount + e.BeforeTaxAmount;
                        e.ExchangeRateAmount = e.TotalAmount * currency.ExchangeRate;
                        e.Sequence = sequence;

                        int inventoryIndex = inventories.FindIndex(x => x.ProductId == e.ProductId && x.WarehouseId == e.WarehouseId);
                        e.Product = e.Product != null ? e.Product : new Product() { Id = e.ProductId };
                        e.Product.ProductUnits = _Context.UnitProductsEquivalences.Include(x => x.Unit).AsNoTracking().Where(x => x.Active == true && x.ProductId == e.ProductId);
                        var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
            e.Quantity,
            e.UnitId,
              e.Product.ProductUnits.ToList()
            );
                        if (inventoryIndex < 0)
                        {
                            inventories.Add(new Inventory()
                            {
                                Quantity = convertionResult.Status >= 0 ? (decimal)convertionResult.Data.FirstOrDefault() : 0,
                                BranchOfficeId = e.BranchOfficeId,
                                ProductId = e.ProductId,
                                UnitId = e.Product.ProductUnits.FirstOrDefault(x => x.IsPrimary == true).UnitId,
                                WarehouseId = e.WarehouseId
                            });
                        }
                        else
                        {
                            inventories[inventoryIndex].Quantity += convertionResult.Status >= 0 ? (decimal)convertionResult.Data.FirstOrDefault() : 0;
                        }
                        e.Supplier = null;
                        e.Product = null;
                        e.Unit = null;
                        e.Warehouse = null;
                        e.Currency = null;
                    });
                    if (entries.Count > 0) 
                    {
                        _Context.InventoryEntries.AddRange(entries);
                        _Context.SaveChanges();
                    }


                    inventories.ForEach(inventory =>
                    {
                        decimal currentQuantity = 0;
                        var currentInventory = _Context.Inventory.AsNoTracking().FirstOrDefault(x => x.ProductId == inventory.ProductId && x.WarehouseId == inventory.WarehouseId && x.UnitId == inventory.UnitId && x.Active == true);
                        if (currentInventory != null)
                        {
                            
                            currentInventory.Quantity += inventory.Quantity;
                            currentQuantity = currentInventory.Quantity;
                            _Context.Inventory.Update(currentInventory);
                        }
                        else
                            _Context.Inventory.Add(inventory);
                        _Context.SaveChanges();
                        var movement = new WarehouseMovement()
                        {
                            CurrentBalance = currentQuantity,
                            BranchOfficeId=inventory.BranchOfficeId,
                            MovementType = Enums.MovementTypes.IN.ToString(),
                            ProductId=inventory.ProductId,
                            Quantity=inventory.Quantity,
                            Reference= sequence,
                            UnitId=inventory.UnitId,
                            WarehouseId=inventory.WarehouseId
                        };
                        warehouseMovements.Add(movement);
                    });
                    tran.Commit();
                    return new Result<object>(0, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    result = new Result<object>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public Result<object> RemoveEntries(string sequence)
        {
            Result<object> result = new Result<object>(-1, -1, "error_msg");
            using (var tran = _Context.Database.BeginTransaction())
            {
                try
                {
                    var entries = _Context.InventoryEntries.AsNoTracking().Where(x => x.Active == true && x.Sequence == sequence).ToList();
                    entries.ForEach(e =>
                    {
                        e.Active = false;
                        var productUnits = _Context.UnitProductsEquivalences.AsNoTracking().Where(x => x.Active == true && x.ProductId == e.ProductId).ToList();
                        var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
e.Quantity,
e.UnitId,
productUnits
);
                        var inventory = _Context.Inventory.AsNoTracking().FirstOrDefault(x => x.Active == true && x.ProductId == e.ProductId && x.WarehouseId == e.WarehouseId);
                        
                        inventory.Quantity -= (decimal)convertionResult.Data.FirstOrDefault();
                        decimal currentBalance = inventory != null ? inventory.Quantity : 0;
                        var movement = new WarehouseMovement()
                        {
                            CurrentBalance = currentBalance,
                            BranchOfficeId = inventory.BranchOfficeId,
                            MovementType = Enums.MovementTypes.OUT.ToString(),
                            ProductId = inventory.ProductId,
                            Quantity =- (decimal)convertionResult.Data.FirstOrDefault(),
                            Reference = sequence,
                            UnitId = inventory.UnitId,
                            WarehouseId = inventory.WarehouseId
                        };
                        _Context.Inventory.Update(inventory);
                        _Context.SaveChanges();
                        warehouseMovements.Add(movement);

                    });
                    _Context.InventoryEntries.UpdateRange(entries);
                    _Context.SaveChanges();
                    tran.Commit();
                    result = new Result<object>(0, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    result = new Result<object>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }
            return result;
        }

        public override Result<InventoryEntry> Add(InventoryEntry entity)
        {
            throw new NotImplementedException();
        }

        public override Result<InventoryEntry> Update(InventoryEntry entity, bool fromDb = true)
        {
            throw new NotImplementedException();
        }
    }
}
