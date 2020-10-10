using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public ProductRepository(MainDataContext context, ISequenceManagerRepository sequence) : base(context)
        {
            this._sequenceRepo = sequence;
        }

        public IEnumerable<Product> GetFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsOnlyFilteredAndLimited(int pageZise, string name, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsOnlyFilteredAndLimited(int pageZise, string fieldName1, string fieldName2, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public override Result<Product> Add(Product entity)
        {

            Result<Product> result = new Result<Product>(-1, -1, "error_msg");

            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    if ((entity.Taxes == null || entity.Taxes.Count() == 0) && !entity.IsCompositeProduct)
                        throw new Exception("productNeedsTaxes_msg");
                    languages = _Context.Set<Language>().AsNoTracking().Where(x => x.Active == true).ToList();
                    entity.TranslationData = TranslateUtility.SaveTranslation(entity, entity.TranslationData,languages);
                    var costs = entity.SuppliersCosts?.ToList();
                    var units = entity.ProductUnits?.ToList();
                    var taxes = entity.Taxes?.ToList();
                    var bases = entity.BaseCompositeProducts?.ToList();
                    entity.BaseCompositeProducts = null;
                    entity.SuppliersCosts = null;
                    entity.ProductUnits = null;
                    entity.Taxes = null;
                    decimal tempCost = (entity.IsService ? bases.Sum(x => x.TotalCost) : costs.Sum(x => x.Cost) / costs.Count);
                    entity.Cost = entity.Cost > tempCost ? entity.Cost :tempCost;
                    decimal tempPrice = (entity.IsService ? bases.Sum(x => x.TotalPrice) : entity.Price);
                    entity.Price = entity.Price == 0 ? tempPrice : entity.Price;
                    string sequence = _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Products);
                    entity.Sequence = sequence;
                    _Context.Products.Add(entity);
                    _Context.SaveChanges();
                    SetChildren(entity, costs, units, taxes, bases);


                    transaction.Commit();
                    result = new Result<Product>(0, 0, "ok_msg", new List<Product>() { new Product() { Id = entity.Id } });
                }
                catch (Exception ex)
                {
                    result = new Result<Product>(-1, -1, $"error_msg", null, ex);
                    transaction.Rollback();
                }
            }
            return result;
        }

        public override Result<Product> Update(Product entity, bool fromDb = true)
        {
            Result<Product> result = new Result<Product>(-1, -1, "error_msg");

            using (var transaction = _Context.Database.BeginTransaction()) 
            {
                try
                {
                    if ((entity.Taxes == null || entity.Taxes.Count() == 0)&& !entity.IsCompositeProduct)
                        throw new Exception("productNeedsTaxes_msg");
                    var dbEntity = _Context.Products.Find(entity.Id);
                    _Context.Entry<Product>(dbEntity).State = EntityState.Detached;
                    var translation = dbEntity as IEntityTranslate;
                    if (translation != null)
                    {
                        languages = _Context.Set<Language>().AsNoTracking().Where(x => x.Active == true).ToList();
                        entity.TranslationData = TranslateUtility.SaveTranslation(entity, translation.TranslationData, languages);

                    }
                    var costs = entity.SuppliersCosts?.ToList();
                    var units = entity.ProductUnits?.ToList();
                    var taxes = entity.Taxes?.ToList();
                    var bases = entity.BaseCompositeProducts?.ToList();
                    entity.BaseCompositeProducts = null;
                    entity.SuppliersCosts = null;
                    entity.ProductUnits = null;
                    entity.Sequence =string.IsNullOrEmpty(entity.Sequence)? _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Products):entity.Sequence;
                    entity.Taxes = null;
                    decimal tempCost = (entity.IsService ?(entity.IsCompositeProduct? bases.Sum(x => x.TotalCost):entity.Cost ): costs.Average(x => x.Cost));
                    entity.Cost = entity.Cost > tempCost ? entity.Cost : tempCost;
                    decimal tempPrice = (entity.IsService ? bases.Sum(x => x.TotalPrice) : entity.Price);
                    entity.Price = entity.Price == 0 ? tempPrice : entity.Price;
                    _Context.Products.Update(entity);
                    _Context.SaveChanges();
                  
                    SetChildren(entity,costs,units,taxes,bases);


                    transaction.Commit();
                    result = new Result<Product>(0, 0, "ok_msg", new List<Product>() { new Product() {Id=entity.Id } });
                }
                catch (Exception ex)
                {
                   result = new Result<Product>(-1, -1, ex.Message,null,ex);
                    transaction.Rollback();
                }
            }
            return result;
        }


        private void SetChildren(Product product,List<ProductSupplierCost> costs,List<UnitProductEquivalence> units,List<ProductTax>taxes,List<CompositeProduct> bases) 
        {
            var previousCost = _Context.ProductSupplierCosts.Where(x => x.ProductId == product.Id && x.Active == true).AsNoTracking().ToList();
            var previousUnits = _Context.UnitProductsEquivalences.Where(x => x.ProductId == product.Id && x.Active == true).AsNoTracking().ToList();
            var previousTaxes = _Context.ProductTaxes.Where(x => x.ProductId == product.Id && x.Active == true).AsNoTracking().ToList();
            var previousBases = _Context.CompositeProducts.Where(x => x.ProductId == product.Id && x.Active == true).AsNoTracking().ToList();
            var productIsBase = _Context.CompositeProducts.Where(x => x.BaseProductId == product.Id && x.Active == true).AsNoTracking().ToList();
            costs.ForEach(c => {
                c.ProductId = product.Id;
                c.Supplier = null;
                c.Product = null;
                if (c.Id > 0 && !previousCost.Any(x => x.Id == c.Id))
                    c.Active = false;
                else
                    c.Active = true;

                if (c.Id == 0)
                    _Context.ProductSupplierCosts.Add(c);
                else
                    _Context.ProductSupplierCosts.Update(c);
                _Context.SaveChanges();
            });
            previousCost.ForEach(c=> {
                if (!costs.Any(x => x.Id == c.Id)) 
                {
                    this.Remove(c.Id);
                }
            });
           

            units.ForEach(c => {
               
                c.ProductId = product.Id;
                c.Product = null;
                c.Unit = null;
                c.CostPrice = product.Cost/c.Equivalence;
                c.SellingPrice = GetUnitSellingPrice(product, c.Equivalence);

                if (c.Id > 0 && !previousUnits.Any(x => x.Id == c.Id))
                    c.Active = false;
                else
                    c.Active = true;

                if (c.Id == 0)
                    _Context.UnitProductsEquivalences.Add(c);
                else
                    _Context.UnitProductsEquivalences.Update(c);
                _Context.SaveChanges();
            });
            previousUnits.ForEach(c => {
                if (!units.Any(x => x.Id == c.Id))
                {
                    c.Active = false;
                    _Context.UnitProductsEquivalences.Update(c);
                    _Context.SaveChanges();
                }
            });

            taxes.ForEach(c => {
               
                c.ProductId = product.Id;
                c.Product = null;
                c.Tax = null;

                if (c.Id > 0 && !previousTaxes.Any(x => x.Id == c.Id))
                    c.Active = false;
                else
                    c.Active = true;

                if (c.Id == 0)
                    _Context.ProductTaxes.Add(c);
                else
                    _Context.ProductTaxes.Update(c);
                _Context.SaveChanges();
            });


            previousTaxes.ForEach(c => {
                if (!taxes.Any(x => x.Id == c.Id))
                {
                    c.Active = false;
                    _Context.ProductTaxes.Update(c);
                    _Context.SaveChanges();
                }
            });
            bases.ForEach(c => {
               
                c.BaseProduct = c.BaseProduct != null && c.BaseProduct.Id > 0 ? c.BaseProduct : _Context.Products.Find(c.BaseProductId);
                _Context.Entry<Product>(c.BaseProduct).State = EntityState.Detached;
                c.BaseProductUnitId = c.BaseProductUnitId == 0 ? null : c.BaseProductUnitId;
                c.UnitProductEquivalence = c.UnitProductEquivalence != null && c.UnitProductEquivalence.Id > 0 ? c.UnitProductEquivalence :c.BaseProductUnitId.HasValue? _Context.UnitProductsEquivalences.Find(c.BaseProductUnitId):null;
                if(c.UnitProductEquivalence!=null)
                _Context.Entry<UnitProductEquivalence>(c.UnitProductEquivalence).State = EntityState.Detached;
                c.ProductId = product.Id;
                c.Active = true;
                c.CurrencyId = product.CurrencyId;
                c.Currency = null;
                c.TotalCost =c.UnitProductEquivalence!=null? c.Quantity * c.UnitProductEquivalence.CostPrice:c.BaseProduct.Cost*c.Quantity;
                c.TotalPrice =c.UnitProductEquivalence!=null?(c.Quantity*c.UnitProductEquivalence.SellingPrice): c.Quantity * (new decimal[] { product.Price, product.Price2, product.Price3 }.OrderByDescending(x => x).FirstOrDefault());
                c.BaseProduct = null;
                c.Product = null;
                c.UnitProductEquivalence = null;

                if (c.Id > 0 && !previousBases.Any(x => x.Id == c.Id))
                    c.Active = false;
                else
                    c.Active = true;

                if (c.Id == 0)
                    _Context.CompositeProducts.Add(c);
                else
                    _Context.CompositeProducts.Update(c);
                _Context.SaveChanges();
            });
            productIsBase.ForEach(b => {
                var unit = b.BaseProductUnitId.HasValue ? units.FirstOrDefault(x => x.UnitId == b.BaseProductUnitId):null;
                if (b.BaseProductUnitId.HasValue && unit == null)
                    throw new Exception("thisIsABaseProduct_error");

                b.TotalCost = unit != null ? b.Quantity * unit.CostPrice : product.Cost * b.Quantity;
                b.TotalPrice = unit != null ? b.Quantity * unit.SellingPrice : b.Quantity * (new decimal[] { product.Price, product.Price2, product.Price3 }.OrderByDescending(x => x).FirstOrDefault());
                _Context.CompositeProducts.Update(b);
                _Context.SaveChanges();


            });


            previousBases.ForEach(c => {
                if (!bases.Any(x => x.Id == c.Id))
                {
                    c.Active = false;
                    _Context.CompositeProducts.Update(c);
                    _Context.SaveChanges();
                }
            });
        }

        private decimal GetUnitSellingPrice(Product product, decimal equivalence) 
        {
            decimal result = 0;
            decimal[] prices = new decimal[] { product.Price, product.Price2, product.Price3 }.Where(x=>x>0).ToArray();
            result = prices.Average(x=>x) / equivalence;
            return result;
        }
    }
}
