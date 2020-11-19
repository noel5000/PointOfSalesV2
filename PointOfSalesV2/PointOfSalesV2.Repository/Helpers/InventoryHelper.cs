using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository.Helpers.BillServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers
{
    public class InventoryHelper
    {
        public static Result<object> UpdateInventory(IDetailEntity detail, Warehouse currentWarehouse, Invoice invoiceLead, IDataRepositoryFactory _repositoryFactory, out long? warehouseId)
        {
            warehouseId = null;
            var warehouseMovementRepo = _repositoryFactory.GetDataRepositories<WarehouseMovement>();
            var productUnitsRepo = _repositoryFactory.GetDataRepositories<UnitProductEquivalence>();
            var productRepo = _repositoryFactory.GetDataRepositories<Product>();
            var inventoryRepo = _repositoryFactory.GetDataRepositories<Inventory>();
            detail.Product.ProductUnits = detail.Product.ProductUnits ?? productUnitsRepo.GetAll(x => x.AsNoTracking(), y => y.Active == true && y.ProductId == detail.ProductId).Data;
            Inventory currentInventory = inventoryRepo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.ProductId == detail.ProductId && y.WarehouseId == currentWarehouse.Id));
            if (currentInventory != null)
            {
                var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
       detail.Quantity,
       detail.UnitId.Value,
      detail.Product.ProductUnits.ToList()
       );
                if (convertionResult.Status >= 0)
                    detail.Quantity = (decimal)convertionResult.Data.FirstOrDefault();
                else
                    return convertionResult;

                detail.UnitId = detail.Product.ProductUnits.FirstOrDefault(pu => pu.IsPrimary).UnitId;
                convertionResult = ProductsHelper.ConvertFromProductPrincipalUnit(
       currentInventory.Quantity,
       detail.Product.ProductUnits.Where(pu => pu.IsPrimary).FirstOrDefault().UnitId,
      detail.Product.ProductUnits.ToList()
       );

                if (convertionResult.Status >= 0)
                    currentInventory.Quantity = (decimal)convertionResult.Data.FirstOrDefault();
                else
                    return convertionResult;


                if (currentInventory.Quantity < detail.Quantity)
                    return new Result<object>(-1, -1, $"outOfStock_msg | {detail.Product.Name},{currentWarehouse.Name}");
                else
                {
                    currentInventory.Quantity -= detail.Quantity;
                   
                    currentInventory.Product = null;
                    currentInventory.Unit = null;
                    currentInventory.BranchOffice = null;
                    currentInventory.Warehouse = null;
                    currentInventory.ProductShort = null;
                    detail.WarehouseId = currentInventory.WarehouseId;
                    warehouseId = currentInventory.WarehouseId;
                    InventoryHelper.InventoryToUpdate = InventoryHelper.InventoryToUpdate == null ? new List<Inventory>() : InventoryHelper.InventoryToUpdate;
                    InventoryHelper.InventoryToUpdate.Add(new Inventory() 
                    {
                    ProductId= currentInventory.ProductId,
                    WarehouseId=currentInventory.WarehouseId,
                    BranchOfficeId=currentInventory.BranchOfficeId,
                    UnitId=currentInventory.UnitId,
                    Quantity=detail.Quantity
                    });
                    //var inventoryResult = inventoryRepo.Update(currentInventory,false);

                    //if (inventoryResult.Status < 0)
                    //    return new Result<object>(-1, -1, "error_msg");


                    var units = detail.Product.ProductUnits ?? productUnitsRepo.GetAll(x => x.AsNoTracking().Where(y => y.Active == true && y.ProductId == detail.ProductId)).Data;
                    WarehouseMovement movement = new WarehouseMovement(currentWarehouse.Id, detail.ProductId, detail.Quantity * -1,
                        true, units.Where(u => u.IsPrimary).FirstOrDefault().UnitId, invoiceLead.BranchOfficeId, "OUT",
                       !string.IsNullOrEmpty(invoiceLead.InvoiceNumber) ? invoiceLead.InvoiceNumber : invoiceLead.DocumentNumber ?? string.Empty, currentInventory.Quantity);

                    var logResult = warehouseMovementRepo.Add(movement);
                    if (logResult.Status < 0)
                        return new Result<object>(-1, -1, logResult.Message, null, logResult.Exception);

                    return new Result<object>(0, 0, "ok_msg");


                }
            }
            else
                return new Result<object>(-1, -1, $"outOfStock_msg | {detail.Product.Name},{currentWarehouse.Name}");

        }

        public static bool VerifyExistence(List<IDetailEntity> menuDetails, IDataRepositoryFactory _repositoryFactory, List<Inventory> inventories)
        {
            bool result = true;
            menuDetails.ForEach(detail =>
            {
                if (detail.Product.IsService && !detail.Product.IsCompositeProduct)
                {
                    result = true;
                    return;
                }
                else if (detail.Product.IsCompositeProduct)
                {
                    var children = _repositoryFactory.GetDataRepositories<CompositeProduct>().GetAll(x => x.AsNoTracking().Include(y => y.Product).Include(y => y.UnitProductEquivalence),
                        y => y.Active == true && y.ProductId == detail.ProductId
                    );
                    children.Data.ToList().ForEach(child =>
                    {
                        if (child.BaseProductUnitId.HasValue)
                            result = ProcessProduct(new MenuDetail()
                            {
                                UnitId = child.UnitProductEquivalence.UnitId,
                                ProductId = child.BaseProductId,
                                Quantity = child.UnitProductEquivalence.Equivalence * child.Quantity
                            }, inventories, _repositoryFactory);

                    });
                }
                else
                    result = ProcessProduct(detail, inventories, _repositoryFactory);

            });
            return result;

        }

        public static bool ProcessProduct(IDetailEntity detail, List<Inventory> inventories, IDataRepositoryFactory _repositoryFactory)
        {
            bool result = true;
            var productUnitsRepo = _repositoryFactory.GetDataRepositories<UnitProductEquivalence>();
            var productUnits = productUnitsRepo.GetAll(x => x, y => y.Active == true && y.ProductId == detail.ProductId).Data.ToList();
            decimal detailQuantity = (decimal)ProductsHelper.ConvertToProductPrincipalUnit(detail.Quantity,
                detail.UnitId.Value, productUnits).Data.FirstOrDefault();
            decimal acumulator = 0;
            var productInventories = inventories.Where(x => x.ProductId == detail.ProductId && x.Quantity > 0).ToList();
            if (productInventories.Sum(x => x.Quantity) < detailQuantity)
            {
                result = false;
                productInventories.ForEach(pi =>
                {
                    pi.Quantity = 0;
                    int index = inventories.FindIndex(x => x.Id == pi.Id);
                    inventories[index] = pi;
                });
                return false;
            }
            else
            {
                productInventories.ForEach(pi =>
                {
                    if (acumulator < detailQuantity)
                        if (pi.Quantity > detailQuantity)
                        {
                            pi.Quantity -= detailQuantity;
                            acumulator += detailQuantity;
                        }
                        else
                        {
                            acumulator += pi.Quantity;
                            pi.Quantity = 0;
                        }

                    int index = inventories.FindIndex(x => x.Id == pi.Id);
                    inventories[index] = pi;
                });
            }
            return result;
        }


        public static Result<object> AddInventory(IDetailEntity detail, Invoice invoiceLead, IDataRepositoryFactory _repositoryFactory)
        {
           
            var warehouseMovementRepo = _repositoryFactory.GetDataRepositories<WarehouseMovement>();
            var productUnitsRepo = _repositoryFactory.GetDataRepositories<UnitProductEquivalence>();
            var productRepo = _repositoryFactory.GetDataRepositories<Product>();
            var inventoryRepo = _repositoryFactory.GetDataRepositories<Inventory>();
            if (!detail.Product.IsService)
            {
                detail.Product.ProductUnits = detail.Product.ProductUnits ?? productUnitsRepo.GetAll(x => x.AsNoTracking().Where(y => y.Active == true && y.ProductId == detail.ProductId)).Data.ToList();


                if (detail.WarehouseId.HasValue)
                {
                    Inventory currentInventory = inventoryRepo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.ProductId == detail.ProductId && y.WarehouseId == detail.WarehouseId.Value));
                    if (currentInventory != null)
                    {
                        var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
               currentInventory.Quantity,
               detail.Product.ProductUnits.Where(pu => pu.IsPrimary).FirstOrDefault().UnitId,
               detail.Product.ProductUnits.ToList()
               );
                        if (convertionResult.Status < 0)
                            return convertionResult;

                        currentInventory.Quantity = (decimal)convertionResult.Data.FirstOrDefault();

                        convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
               detail.Quantity,
               detail.UnitId.Value,
                detail.Product.ProductUnits.ToList()
               );
                        if (convertionResult.Status < 0)
                            return convertionResult;

                        detail.Quantity = (decimal)convertionResult.Data.FirstOrDefault();
                        var units = detail.Product.ProductUnits ?? productUnitsRepo.GetAll(x => x.AsNoTracking().Where(y => y.Active == true && y.ProductId == detail.ProductId)).Data.ToList();


                        currentInventory.Quantity += detail.Quantity;
                        Product Product =detail.Product?? productRepo.Get(detail.ProductId).Data.FirstOrDefault();
                        Product.Existence += detail.Quantity;

                        var productResult = productRepo.Update(Product,false);
                        var inventoryResult = inventoryRepo.Update(currentInventory,false);

                        if (productResult.Status < 0 || inventoryResult.Status < 0)
                            return new Result<object>(-1, -1, "error_msg");

                        WarehouseMovement movimientoAlmacen = new WarehouseMovement(currentInventory.WarehouseId, detail.ProductId, detail.Quantity, true,
                           units.Where(u => u.IsPrimary).FirstOrDefault().UnitId,currentInventory.BranchOfficeId, "IN", !string.IsNullOrEmpty(invoiceLead.InvoiceNumber)?invoiceLead.InvoiceNumber : invoiceLead.DocumentNumber ?? string.Empty, currentInventory.Quantity);

                        var logResult = warehouseMovementRepo.Add(movimientoAlmacen);
                        if (logResult.Status < 0)
                            return new Result<object>(-1, -1, logResult.Message, null, logResult.Exception);

                        return new Result<object>(0, 0, "ok_msg");
                    }
                    else
                        return new Result<object>(-1, -1, $"outOfStock_msg | {detail.Product.Name}");
                }
            }

            return new Result<object>(0, 0, "ok_msg");

        }


        public static Result<object> ReInsertInventoryToWarehouse(InvoiceDetail detail, IDataRepositoryFactory _repositoryFactory, Warehouse currentWarehouse, string reference="")
        {
            var productUnitsRepo = _repositoryFactory.GetDataRepositories<UnitProductEquivalence>();
            var inventoryRepo = _repositoryFactory.GetDataRepositories<Inventory>();
            var warehouseMovementRepo = _repositoryFactory.GetDataRepositories<WarehouseMovement>();
            var productRepo = _repositoryFactory.GetDataRepositories<Product>();

            Inventory currentInventory = inventoryRepo.Get(x => x.AsNoTracking().Where(y => y.ProductId == detail.ProductId && y.WarehouseId == currentWarehouse.Id && y.Active == true));
            if (currentInventory != null)
            {
                detail.Product = detail.Product == null ? _repositoryFactory.GetDataRepositories<Product>().Get(x => x.AsNoTracking(), y => y.Active == true && y.Id == detail.ProductId) : detail.Product;
                detail.Product.ProductUnits = detail.Product.ProductUnits ?? productUnitsRepo.GetAll(x => x.AsNoTracking().Where(y => y.Active && y.ProductId == detail.ProductId)).Data.ToList();

                var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
       currentInventory.Quantity,
       detail.Product.ProductUnits.Where(pu => pu.IsPrimary).FirstOrDefault().UnitId,
        detail.Product.ProductUnits.ToList()
       );
                if (convertionResult.Status < 0)
                    return convertionResult;
                currentInventory.Quantity = (decimal)convertionResult.Data.FirstOrDefault();

                convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
           detail.Quantity,
           detail.UnitId.Value,
           detail.Product.ProductUnits.ToList()
           );
                if (convertionResult.Status < 0)
                    return convertionResult;

                detail.Quantity = (decimal)convertionResult.Data.FirstOrDefault();

                currentInventory.Quantity += detail.Quantity;
                Product Product =detail.Product?? productRepo.Get(detail.ProductId).Data.FirstOrDefault();
                Product.Existence += detail.Quantity;


                var productResult = productRepo.Update(Product,false);
                var inventoryResult = inventoryRepo.Update(currentInventory,false);

                if (productResult.Status < 0 || inventoryResult.Status < 0)
                    return new Result<object>(-1, -1, "error_msg");

            }
            else
            {
                var inventoryResult = inventoryRepo.Add(new Inventory()
                {
                    Active = true,
                    Quantity = detail.Quantity,
                    WarehouseId = currentWarehouse.Id,
                    CreatedBy = detail.CreatedBy,
                    CreatedDate = DateTime.Now,
                    ProductId = detail.ProductId,
                    UnitId = detail.Product.ProductUnits.Where(u => u.IsPrimary).FirstOrDefault().Id
                });
              
                if (inventoryResult.Status < 0)
                    return new Result<object>(-1, -1, inventoryResult.Message, null, inventoryResult.Exception);
            }

            _repositoryFactory.GetDataRepositories<WarehouseMovement>().Add(new WarehouseMovement()
            {
                Active = true,
                BranchOfficeId = currentWarehouse.BranchOfficeId,
                CurrentBalance = currentInventory.Quantity,
                UnitId = currentInventory.UnitId,
                LocationName = "",
                MovementType = Enums.MovementTypes.IN.ToString(),
                ProductId = currentInventory.ProductId,
                Quantity = detail.Quantity,
                Reference = reference,
                WarehouseId = currentWarehouse.Id,
                WarehouseName = currentWarehouse.Name
            });
            return new Result<object>(0, 0, "ok_msg");

        }

        public static Result<InvoiceDetail> UpdateProductInventory(BranchOffice branchOffice, InvoiceDetail detail, IDataRepositoryFactory _repositoryFactory, Invoice invoice)
        {
            InvoiceDetail newdetail = new InvoiceDetail(detail);
            var productRepo = _repositoryFactory.GetDataRepositories<Product>();
            var inventoryRepo = _repositoryFactory.GetDataRepositories<Inventory>();
            var detailRepo = _repositoryFactory.GetDataRepositories<InvoiceDetail>();
            detail.Product = detail.Product ?? productRepo.Get(x => x.AsNoTracking(), y => y.Active == true && y.Id == detail.ProductId);
            var service = GetBillProductOrServiceInstance.GetBillingInstance(detail.Product);
            var result = service.ProcessProductService(branchOffice.Id, detail, _repositoryFactory, invoice);
            return result;
        }

        public static List<Inventory> InventoryToUpdate { get; set; }
    }
}
