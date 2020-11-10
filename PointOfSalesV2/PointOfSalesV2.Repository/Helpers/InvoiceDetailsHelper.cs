using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers
{
    public class InvoiceDetailsHelper
    {
        public static void AddDetails(Invoice Invoice, BranchOffice branchOffice, IDataRepositoryFactory dataRepositoryFactory, bool updateTaxes = true)
        {

            var invoiceDetailRepo = dataRepositoryFactory.GetDataRepositories<InvoiceDetail>();
            var inventories = dataRepositoryFactory.GetDataRepositories<Inventory>();
            InventoryHelper.InventoryToUpdate = new List<Inventory>();
            Invoice.InvoiceDetails.ForEach(x =>
            {
                x.InvoiceId = Invoice.Id;
                x.Date =Invoice.BillingDate.HasValue? Invoice.BillingDate.Value:DateTime.Now;
                if (Invoice.InventoryModified)
                {
                    var result = InventoryHelper.UpdateProductInventory(branchOffice, x, dataRepositoryFactory, Invoice);

                    if (result.Status < 0)
                        throw new Exception(result.Message);
                    else
                        x = result.Data.FirstOrDefault();
                }
                else
                    x.SaveRegister = true;
               

                if (x.SaveRegister)
                {
                    x.Id = 0;
                    x.Unit = null;
                    x.Product = null;
                    x.Invoice = null;
                    var addResult = invoiceDetailRepo.Add(x);
                    if (addResult.Status < 0)
                        throw addResult.Exception;
                }

            });
            if (Invoice.InventoryModified)
            {
                var inventorySumm = InventoryHelper.InventoryToUpdate.GroupBy(x => new { x.ProductId, x.WarehouseId }).ToList();
                inventorySumm.ForEach(i => {
                    var currentInventory = inventories.Get(x => x.AsNoTracking(), y => y.Active == true && y.WarehouseId == i.Key.WarehouseId && y.ProductId == i.Key.ProductId);
                    currentInventory.Quantity -= i.Sum(x => x.Quantity);
                    if (currentInventory.Quantity < 0)
                        throw new Exception("outOfStock_msg");
                    inventories.Update(currentInventory, false);

                });
                InventoryHelper.InventoryToUpdate = null;
                if (updateTaxes)
                    UpdateInvoiceTaxes(Invoice, dataRepositoryFactory);
            }
           

        }

        public static Result<Invoice> UpdateDetails(Invoice invoice, BranchOffice branchOffice, IDataRepositoryFactory dataRepositoryFactory)
        {
            var detailsRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceDetailRepository>();
            var productUnitsRepo = dataRepositoryFactory.GetCustomDataRepositories<IUnitProductEquivalenceRepository>();
            var oldDetails = detailsRepo.GetByInvoiceId(invoice.Id).ToList();
            var newDetails = invoice.InvoiceDetails.Where(x => x.Id == 0).ToList();
            var modifiedDetails = new List<InvoiceDetail>();
            var untouchedDetails = new List<InvoiceDetail>();
            oldDetails.ForEach(od =>
            {
                var detail = invoice.InvoiceDetails.FirstOrDefault(x => x.Id == od.Id);
                if (detail != null)
                {
                    if (od.ProductId != detail.ProductId || od.Quantity != detail.Quantity ||
                    od.UnitId != detail.UnitId || od.BranchOfficeId != detail.BranchOfficeId || od.WarehouseId != detail.WarehouseId || od.TotalAmount != detail.TotalAmount)
                    {
                        modifiedDetails.Add(detail);
                    }
                    else
                        untouchedDetails.Add(detail);
                }
            });




            oldDetails.ForEach(d =>
            {
                bool existe = (modifiedDetails.Exists(x => x.ProductId == d.ProductId && d.ParentId == null) || untouchedDetails.Exists(x => x.ProductId == d.ProductId && d.ParentId == null));
                if (!existe)
                {
                    detailsRepo.Remove(d.Id);
                    var result = InventoryHelper.AddInventory(d, invoice, dataRepositoryFactory);

                    var children = detailsRepo.GetAll(x=>x.AsNoTracking().Include(x => x.Product).Include(x => x.Unit),y => y.Active == true && y.ParentId == d.Id).Data.ToList();
                    children.ForEach(d =>
                    {
                        InventoryHelper.AddInventory(d, invoice, dataRepositoryFactory);
                    });
                    if (result.Status < 0)
                        throw new Exception(result.Message);
                }
            });


            Invoice newinvoice = new Invoice(invoice);
            newinvoice.InvoiceDetails = newDetails;
            AddDetails(newinvoice, branchOffice, dataRepositoryFactory, false);

            var detailUpdate = new Result<InvoiceDetail>(-1, -1);
            modifiedDetails.ForEach(d =>
            {
                if (!d.Product.IsService)
                {
                    var oldDetail = oldDetails.Where(x => x.Id == d.Id).FirstOrDefault();
                    decimal currentQuantity = (decimal)ProductsHelper.ConvertToProductPrincipalUnit(
           d.Quantity,
           d.UnitId.Value,
           d.Product.ProductUnits == null || d.Product.ProductUnits.Count() == 0 ? productUnitsRepo.GetProductUnits(d.ProductId).ToList() : d.Product.ProductUnits.ToList()
           ).Data.FirstOrDefault();

                    decimal oldQuantity = (decimal)ProductsHelper.ConvertToProductPrincipalUnit(
            oldDetail.Quantity,
            oldDetail.UnitId.Value,
           oldDetail.Product.ProductUnits == null || oldDetail.Product.ProductUnits.Count() == 0 ? productUnitsRepo.GetProductUnits(oldDetail.ProductId).ToList() : oldDetail.Product.ProductUnits.ToList()
            ).Data.FirstOrDefault();
                    decimal difference = currentQuantity - oldQuantity;
                    if (difference > 0)
                    {
                        var warehouses = dataRepositoryFactory.GetDataRepositories<Warehouse>().GetAll(x => x.AsNoTracking(), y => y.Active == true && y.BranchOfficeId == invoice.BranchOfficeId).Data;
                        var warehouse = warehouses.Where(y => y.Id == d.WarehouseId).FirstOrDefault();
                        if (warehouse == null)
                            throw new Exception("warehouseError_msg");


                        InvoiceDetail nuevoDetalle = new InvoiceDetail()
                        {
                            Product = d.Product,
                            ProductId = d.ProductId,
                            Quantity = difference,
                            UnitId = d.UnitId ?? null,
                            Unit = d.Unit ?? null
                        };

                        var result = InventoryHelper.UpdateInventory(nuevoDetalle, warehouse, invoice, dataRepositoryFactory, out long? warehouseId);
                        nuevoDetalle.WarehouseId = warehouseId;
                        if (result.Status < 0)
                            throw new Exception(result.Message);

                    }
                    else if (difference < 0)
                    {
                        InvoiceDetail detailToInsert = new InvoiceDetail(d);
                        detailToInsert.Quantity = Math.Abs(difference);
                        d.Product.ProductUnits = d.Product.ProductUnits ?? productUnitsRepo.GetAll(x => x.Include(r => r.Unit).AsNoTracking(), y => y.Active == true && y.ProductId == d.ProductId).Data;
                        detailToInsert.Unit = d.Product.ProductUnits.Where(u => u.IsPrimary).FirstOrDefault().Unit;
                        detailToInsert.UnitId = detailToInsert.Unit.Id;
                        var result = InventoryHelper.AddInventory(detailToInsert, invoice, dataRepositoryFactory);
                        if (result.Status < 0)
                            throw new Exception(result.Message);
                    }
                    d.Unit = null;
                    d.Product = null;
                    d.Invoice = null;
                    detailUpdate = detailsRepo.Update(d);
                }
                else if (d.Product.IsCompositeProduct) 
                {
                
                }
                else
                {
                    d.Unit = null;
                    d.Product = null;
                    d.Invoice = null;
                    detailUpdate = detailsRepo.Update(d);
                }
                if (detailUpdate.Status < 0)
                    throw new Exception(detailUpdate.Message ?? "error_msg");
            });

            UpdateInvoiceTaxes(invoice, dataRepositoryFactory);
            return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { invoice });
        }

        public static void UpdateInvoiceTaxes(Invoice invoice, IDataRepositoryFactory dataRepositoryFactory)
        {
            var invoiceTaxRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceTaxRepository>();
            var productTaxRepository = dataRepositoryFactory.GetCustomDataRepositories<IProductTaxRepository>();
            var leadDetailsRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceDetailRepository>();
            var productsRepo = dataRepositoryFactory.GetDataRepositories<Product>();
            var invoiceTaxes = invoiceTaxRepo.GetInvoiceTaxes(invoice.InvoiceNumber).Where(x=>x.Active==true).ToList();
            if (invoiceTaxes != null && invoiceTaxes.Count > 0)
            {
                foreach (var tax in invoiceTaxes)
                {
                    var taxResult = invoiceTaxRepo.Remove(tax.Id);
                    if (taxResult.Status < 0)
                        throw new Exception(taxResult.Message);
                }
            }
            Dictionary<long, decimal> amountPerTax = new Dictionary<long, decimal>();
            invoice.InvoiceDetails = invoice.InvoiceDetails == null ? leadDetailsRepo.GetAll(x => 
            x.Include(d=>d.Product).ThenInclude(d=>d.Taxes).ThenInclude(d=>d.Tax)
            .AsNoTracking()
            , y => y.Active == true && y.InvoiceId == invoice.Id).Data.ToList():invoice.InvoiceDetails;
            invoice.InvoiceDetails.ForEach(x =>
            {
                x.InvoiceId = invoice.Id;
                x.Product = x.Product == null ? productsRepo.Get(x => x.Include(y => y.Taxes).ThenInclude(y => y.Tax), y => y.Active == true && y.Id == x.ProductId) : x.Product;
                var productTaxes = x.Product?.Taxes != null && x.Product?.Taxes.Count() > 0 ? x.Product.Taxes :
                productTaxRepository.GetProductTaxes(x.ProductId);
                foreach (var impuesto in productTaxes)
                {
                    if (amountPerTax.Any(i => i.Key == impuesto.TaxId))
                    {
                        amountPerTax[impuesto.TaxId] += impuesto.Tax.Rate * (x.BeforeTaxesAmount-x.DiscountAmount);
                    }
                    else
                        amountPerTax.Add(impuesto.TaxId, impuesto.Tax.Rate * (x.BeforeTaxesAmount - x.DiscountAmount));
                }
            });

            foreach (var invoiceTaxAmount in amountPerTax)
            {
                InvoiceTax InvoiceImpuesto = new InvoiceTax()
                {
                    CreatedBy = invoice.CreatedBy,
                    Active = true,
                    InvoiceId = invoice.Id,
                    Date= invoice.BillingDate.HasValue?invoice.BillingDate.Value:invoice.BillingDate.Value,
                    CreatedDate = DateTime.Now,
                    TaxId = invoiceTaxAmount.Key,
                    CurrencyId = invoice.CurrencyId,
                    TRN=invoice.TRN,
                    TaxAmount = invoiceTaxAmount.Value,
                    InvoiceNumber = string.IsNullOrEmpty(invoice.InvoiceNumber) ? invoice.DocumentNumber : invoice.InvoiceNumber,

                };
                var taxResult = invoiceTaxRepo.Add(InvoiceImpuesto);
                if (taxResult.Status < 0)
                    throw new Exception(taxResult.Message);
            }
        }

        public static Result<Invoice> UpdateQuoteDetails(Invoice invoice, IDataRepositoryFactory dataRepositoryFactory)
        {
            var detailsRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceDetailRepository>();
            var oldDetails = detailsRepo.GetByInvoiceId(invoice.Id).ToList();
            var newDetails = invoice.InvoiceDetails.Where(x => x.Id == 0).ToList();
            var modifiedDetails = invoice.InvoiceDetails.Except(newDetails).ToList().Except(oldDetails).ToList();
            var untouchedDetails = invoice.InvoiceDetails.Intersect(oldDetails).ToList();


            // BORRA LOS QUE YA NO EXISTEN EN LA invoice NUEVA
            oldDetails.ForEach(d =>
            {
                bool existe = (modifiedDetails.Exists(x => x.ProductId == d.ProductId && d.ParentId == null) || untouchedDetails.Exists(x => x.ProductId == d.ProductId && d.ParentId == null));
                if (!existe)
                {
                    detailsRepo.Remove(d.Id);

                }
            });

            //INSERTAR DETALLES NUEVOS
            Invoice newinvoice = new Invoice(invoice);
            newinvoice.InvoiceDetails = newDetails;
            AddQuoteDetails(newinvoice, dataRepositoryFactory);


            modifiedDetails.ForEach(d =>
            {

                detailsRepo.Update(d);


            });

            UpdateInvoiceTaxes(invoice, dataRepositoryFactory);
            return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { invoice });
        }

        public static void AddQuoteDetails(Invoice invoice, IDataRepositoryFactory dataRepositoryFactory)
        {
            var detailsRepo = dataRepositoryFactory.GetDataRepositories<InvoiceDetail>();

            invoice.InvoiceDetails.ForEach(x =>
            {
                x.InvoiceId = invoice.Id;
                x.CreatedDate = DateTime.Now;
                x.CreatedBy = invoice.CreatedBy;
                x.Active = true;
                x.Date = DateTime.Now;
                x.ModifiedDate = DateTime.Now;
                detailsRepo.Add(x);

            });

            UpdateInvoiceTaxes(invoice, dataRepositoryFactory);
        }



    }
}
