using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PointOfSalesV2.Repository.Helpers
{
  public  class ProductsRepoHelper
    {

        public static bool ExistProductInInvoices(int productId, IDataRepositoryFactory dataRepositoryFactory)
        {
            var detailsRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceDetailRepository>();
            if (detailsRepo.GetByProductId(productId).ToList().Count > 0)
                return true;
            return false;
        }

        public static bool IsProductInWarehouse(int productId, IDataRepositoryFactory dataRepositoryFactory)
        {
            var inventoryRepo = dataRepositoryFactory.GetCustomDataRepositories<IInventoryRepository>();
            if (inventoryRepo.GetProductInventory(productId).Where(e => e.Quantity > 0).Count() > 0)
                return true;
            return false;
        }

        public static bool IsBaseProduct(int productId, IDataRepositoryFactory dataRepositoryFactory)
        {
            var repo = dataRepositoryFactory.GetCustomDataRepositories<ICompositeProductRepository>();
            if (repo.GetDerivedProducts(productId).Count() > 0)
                return true;
            return false;
        }

        public static bool AddUnits(Product product, IDataRepositoryFactory dataRepositoryFactory)
        {
            var unitsRepo = dataRepositoryFactory.GetDataRepositories<UnitProductEquivalence>();
            product.ProductUnits.ToList().ForEach(u =>
            {
                u.CreatedBy = product.CreatedBy;
                u.CreatedDate = DateTime.Now;
                u.Active = true;
                u.ProductId = product.Id;
                unitsRepo.Add(u);
            });

            return true;
        }

        public static bool InsertarImpuestos(Product product, IDataRepositoryFactory dataRepositoryFactory)
        {
            var taxesRepo = dataRepositoryFactory.GetDataRepositories<ProductTax>();
            product.Taxes.ToList().ForEach(u =>
            {
                u.CreatedBy = product.CreatedBy;
                u.CreatedDate = DateTime.Now;
                u.Active = true;
                u.ProductId = product.Id;
                taxesRepo.Add(u);
            });

            return true;
        }

        public static bool AddBaseProducts(Product product, IDataRepositoryFactory dataRepositoryFactory)
        {
            var baseProductsRepo = dataRepositoryFactory.GetDataRepositories<CompositeProduct>();
            if (product.IsService && product.IsCompositeProduct)
                product.BaseCompositeProducts.ToList().ForEach(u =>
                {
                    u.CreatedBy = product.CreatedBy;
                    u.CreatedDate = DateTime.Now;
                    u.Active = true;
                    u.ProductId = product.Id;
                    baseProductsRepo.Add(u);
                });

            return true;
        }

        public static bool UpdateProductUnits(Product product, IDataRepositoryFactory dataRepositoryFactory)
        {
            var unitsRepo = dataRepositoryFactory.GetCustomDataRepositories<IUnitProductEquivalenceRepository>();
            List<UnitProductEquivalence> productUnits = product.ProductUnits!=null?product.ProductUnits.ToList(): new List<UnitProductEquivalence>();
            var previousUnits = unitsRepo.GetProductUnits(product.Id).ToList();

            if (product.IsService)
            {
                productUnits = new List<UnitProductEquivalence>();
                var deletedUnits = previousUnits.Except(productUnits).ToList();
                if (deletedUnits != null)
                    deletedUnits.ForEach(e => { unitsRepo.Remove(e.Id); });
            }

            if (!product.IsService)
            {
                if (productUnits.Count == 0)
                    throw new Exception("productNeedsUnits_msg");

                if (!productUnits.Exists(u => u.IsPrimary))
                    throw new Exception("productNeedsPrimaryUnit_msg");
            }
            if (!product.IsService && previousUnits != null)
            {
                productUnits.ForEach(u =>
                {
                    if (u.Id == 0)
                    {
                        u.Active = true;
                        u.CreatedBy = product.CreatedBy;
                        u.CreatedDate = product.CreatedDate;
                        unitsRepo.Add(u);
                    }
                    else
                    {
                        var previuosEquivalenceUnits = previousUnits.Where(e => e.Id == u.Id).FirstOrDefault();
                        previuosEquivalenceUnits.Equivalence = u.Equivalence;
                        previuosEquivalenceUnits.IsPrimary = u.IsPrimary;
                        previuosEquivalenceUnits.CostPrice = u.CostPrice;
                        previuosEquivalenceUnits.SellingPrice = u.SellingPrice;
                        previuosEquivalenceUnits.ModifiedBy = product.ModifiedBy;
                        previuosEquivalenceUnits.ModifiedDate = product.ModifiedDate;
                        unitsRepo.Update(previuosEquivalenceUnits);
                    }


                });

                var deletedUnits = previousUnits.Except(productUnits).ToList();
                if (deletedUnits != null)
                    deletedUnits.ForEach(e =>
                    {
                        try
                        {
                            unitsRepo.Remove(e.Id);
                        }
                        catch
                        {
                            throw new Exception("cannotEraseUnit_msg");
                        }

                    });

            }
            return true;
        }

        public static bool UpdateProductTaxes(Product product, IDataRepositoryFactory dataRepositoryFactory)
        {
            List<ProductTax> productTaxes = product.Taxes!=null?product.Taxes.ToList() : new List<ProductTax>();
            var taxesRepo = dataRepositoryFactory.GetCustomDataRepositories<IProductTaxRepository>();
            var previousTaxes = taxesRepo.GetProductTaxes(product.Id).ToList();


            if (previousTaxes != null)
            {
                productTaxes.ForEach(u =>
                {
                    if (u.Id == 0)
                    {
                        u.Active = true;
                        u.CreatedBy = product.CreatedBy;
                        u.CreatedDate = product.CreatedDate;
                        u.ProductId = product.Id;
                        taxesRepo.Add(u);
                    }
                    else
                    {
                        var previuosEquivalenceUnits = productTaxes.Where(e => e.Id == u.Id).FirstOrDefault();

                        previuosEquivalenceUnits.TaxId = u.TaxId;
                        previuosEquivalenceUnits.ModifiedBy = product.ModifiedBy;
                        previuosEquivalenceUnits.ModifiedDate = product.ModifiedDate;
                        taxesRepo.Update(previuosEquivalenceUnits);
                    }


                });

                var deletedUnits = previousTaxes.Except(productTaxes).ToList();
                if (deletedUnits != null)
                    deletedUnits.ForEach(e =>
                    {
                        try
                        {
                            taxesRepo.Remove(e.Id);
                        }
                        catch 
                        {
                            throw new Exception("cannotDeleteTax_msg");
                        }

                    });

            }
            return true;
        }

        public static bool UpdateProductBases(Product product, IDataRepositoryFactory dataRepositoryFactory)
        {
            var repo = dataRepositoryFactory.GetCustomDataRepositories<ICompositeProductRepository>();
            List<CompositeProduct> productBases = product.BaseCompositeProducts!=null?product.BaseCompositeProducts.ToList() : new List<CompositeProduct>();
            var previousBases = repo.GetProductBases(product.Id).ToList() ?? new List<CompositeProduct>();

            if (!product.IsService)
            {
                productBases = new List<CompositeProduct>();
                var deletedBases = previousBases.Except(productBases).ToList();
                if (deletedBases != null)
                    deletedBases.ForEach(e => { repo.Remove(e.Id); });
            }


            if (product.IsService && product.IsCompositeProduct)
            {
                productBases.ForEach(u =>
                {
                    if (u.Id == 0)
                    {
                        u.Active = true;
                        u.CreatedBy = product.CreatedBy;
                        u.CreatedDate = product.CreatedDate;
                        repo.Add(u);
                    }
                    else
                    {
                        var previousEquivalenceBases = previousBases.Where(e => e.Id == u.Id).FirstOrDefault();
                        if (previousEquivalenceBases != null)
                        {
                            previousEquivalenceBases.Quantity = u.Quantity;
                            previousEquivalenceBases.BaseProductId = u.BaseProductId;
                            previousEquivalenceBases.ProductId = u.ProductId;
                            previousEquivalenceBases.BaseProductUnitId = u.BaseProductUnitId ?? null;
                            previousEquivalenceBases.ModifiedBy = product.ModifiedBy ;
                            previousEquivalenceBases.ModifiedDate = product.ModifiedDate;
                            repo.Update(previousEquivalenceBases);
                        }

                    }


                });

                var deletedUnits = previousBases.Except(productBases).ToList();
                if (deletedUnits != null)
                    deletedUnits.ForEach(e =>
                    {
                        try
                        {
                            repo.Remove(e.Id);
                        }
                        catch 
                        {
                            throw new Exception("cannotRemoveBaseProduct_msg");
                        }

                    });

            }
            else if ((product.IsService && !product.IsCompositeProduct) || !product.IsService)
            {
                previousBases.ForEach(e =>
                {
                    try
                    {
                        repo.Remove(e.Id);
                    }
                    catch 
                    {
                        throw new Exception("cannotRemoveBaseProduct_msg");
                    }

                });


            }
            return true;
        }
    }
}
