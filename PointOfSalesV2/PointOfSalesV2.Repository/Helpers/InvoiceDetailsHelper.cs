using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers
{
  public  class InvoiceDetailsHelper
    {
        public static void AddDetails(InvoiceLead Invoice,  IDataRepositoryFactory dataRepositoryFactory, bool updateTaxes = true)
        {

            var invoiceDetailRepo = dataRepositoryFactory.GetDataRepositories<LeadDetail>();
            Invoice.LeadDetails.ForEach(x =>
            {
                x.InvoiceLeadId = Invoice.Id;
                x.CreatedDate = DateTime.Now;
                x.CreatedBy = Invoice.CreatedBy;
                x.Active = true;
                x.Date = DateTime.Now;
                x.ModifiedDate = DateTime.Now;
                var result = InventoryHelper.UpdateProductInventory(Invoice.BranchOffice, x, dataRepositoryFactory, Invoice);
               
                if (result.Status < 0)
                    throw new Exception(result.Message);
                else
                    x = result.Data.FirstOrDefault();

                if (x.SaveRegister)
                    invoiceDetailRepo.Add(x);
            });
            if (updateTaxes)
                UpdateInvoiceTaxes(Invoice, dataRepositoryFactory);

        }

        public static Result<InvoiceLead> UpdateDetails(InvoiceLead invoice, IDataRepositoryFactory dataRepositoryFactory) 
        {
            var detailsRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceDetailRepository>();
            var productUnitsRepo = dataRepositoryFactory.GetCustomDataRepositories<IUnitProductEquivalenceRepository>();
            var oldDetails = detailsRepo.GetByInvoiceId(invoice.Id).ToList();
            var newDetails = invoice.LeadDetails.Where(x => x.Id == 0).ToList();
            var modifiedDetails = invoice.LeadDetails.Except(newDetails).ToList().Except(oldDetails).ToList();
            var untouchedDetails = invoice.LeadDetails.Intersect(oldDetails).ToList();


            
            oldDetails.ForEach(d =>
            {
                bool existe = (modifiedDetails.Exists(x => x.ProductId == d.ProductId && d.ParentId == null) || untouchedDetails.Exists(x => x.ProductId == d.ProductId && d.ParentId == null));
                if (!existe)
                {
                    detailsRepo.Remove(d.Id);
                 var result =   InventoryHelper.AddInventory(d, invoice,dataRepositoryFactory);
                    if (result.Status < 0)
                        throw new Exception(result.Message);
                }
            });

       
            InvoiceLead newinvoice = new InvoiceLead(invoice);
            newinvoice.LeadDetails = newDetails;
            AddDetails(newinvoice, dataRepositoryFactory);


            modifiedDetails.ForEach(d =>
            {
                if (!d.Product.IsService)
                {
                    var oldDetail = oldDetails.Where(x => x.Id == d.Id).FirstOrDefault();
                    decimal currentQuantity =(decimal) ProductsHelper.ConvertToProductPrincipalUnit(
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

                        var warehouse = invoice.BranchOffice.Warehouses?.Where(y => y.Id == d.WarehouseId).FirstOrDefault();
                        if (warehouse == null)
                            throw new Exception("warehouseError_msg");


                        LeadDetail nuevoDetalle = new LeadDetail()
                        {
                            Product = d.Product,
                            ProductId = d.ProductId,
                            Quantity = difference,
                            UnitId = d.UnitId ?? null,
                            Unit = d.Unit ?? null
                        };

                 var result=       InventoryHelper.UpdateInventory(nuevoDetalle, warehouse, invoice, dataRepositoryFactory);
                        if (result.Status < 0)
                            throw new Exception(result.Message);

                    }
                    else if (difference < 0)
                    {
                        LeadDetail detailToInsert = new LeadDetail(d);
                        detailToInsert.Quantity = Math.Abs(difference);
                        detailToInsert.Unit = d.Product.ProductUnits.Where(u => u.IsPrimary).FirstOrDefault().Unit;
                        detailToInsert.UnitId = detailToInsert.Unit.Id;
                        var result = InventoryHelper.AddInventory(detailToInsert, invoice,dataRepositoryFactory);
                        if (result.Status < 0)
                            throw new Exception(result.Message);
                    }
                    detailsRepo.Update(d);
                }
                else
                {
                    detailsRepo.Update(d);
                }

            });

            UpdateInvoiceTaxes(invoice, dataRepositoryFactory);
            return new Result<InvoiceLead>(0,0,"ok_msg",new List<InvoiceLead>() { invoice});
        }
       
        static void UpdateInvoiceTaxes(InvoiceLead invoice, IDataRepositoryFactory dataRepositoryFactory)
        {
            var invoiceTaxRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceTaxRepository>();
            var productTaxRepository = dataRepositoryFactory.GetCustomDataRepositories<IProductTaxRepository>();
            var invoiceTaxes = invoiceTaxRepo.GetInvoiceTaxes(invoice.InvoiceNumber).ToList();
            if (invoiceTaxes != null && invoiceTaxes.Count > 0)
            {
                foreach (var tax in invoiceTaxes)
                {
                    invoiceTaxRepo.Remove(tax.Id);
                }
            }
            Dictionary<long, decimal> amountPerTax = new Dictionary<long, decimal>();
            invoice.LeadDetails.ForEach(x =>
            {
                x.InvoiceLeadId = invoice.Id;

                var productTaxes = x.Product?.Taxes != null && x.Product?.Taxes.Count() > 0 ? x.Product.Taxes :
                productTaxRepository.GetProductTaxes(x.ProductId);
                foreach (var impuesto in productTaxes)
                {
                    if (amountPerTax.Any(i => i.Key == impuesto.TaxId))
                    {
                        amountPerTax[impuesto.TaxId] += impuesto.Tax.Rate * x.BeforeTaxesAmount;
                    }
                    else
                        amountPerTax.Add(impuesto.TaxId, impuesto.Tax.Rate * x.BeforeTaxesAmount);
                }
            });

            foreach (var invoiceTaxAmount in amountPerTax)
            {
                InvoiceTax InvoiceImpuesto = new InvoiceTax()
                {
                    CreatedBy = invoice.CreatedBy,
                    Active = true,
                    InvoiceId = invoice.Id,
                    CreatedDate = DateTime.Now,
                    TaxId = invoiceTaxAmount.Key,
                    CurrencyId = invoice.CurrencyId,
                    TaxAmount = invoiceTaxAmount.Value,
                    InvoiceNumber = string.IsNullOrEmpty(invoice.InvoiceNumber) ? invoice.DocumentNumber : invoice.InvoiceNumber,

                };
                invoiceTaxRepo.Add(InvoiceImpuesto);
            }
        }

        public static Result<InvoiceLead> UpdateQuoteDetails(InvoiceLead invoice, IDataRepositoryFactory dataRepositoryFactory)
        {
            var detailsRepo = dataRepositoryFactory.GetCustomDataRepositories<IInvoiceDetailRepository>();
            var oldDetails = detailsRepo.GetByInvoiceId(invoice.Id).ToList();
            var newDetails = invoice.LeadDetails.Where(x => x.Id == 0).ToList();
            var modifiedDetails = invoice.LeadDetails.Except(newDetails).ToList().Except(oldDetails).ToList();
            var untouchedDetails = invoice.LeadDetails.Intersect(oldDetails).ToList();


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
            InvoiceLead newinvoice = new InvoiceLead(invoice);
            newinvoice.LeadDetails = newDetails;
            AddQuoteDetails(newinvoice,dataRepositoryFactory);


            modifiedDetails.ForEach(d =>
            {

                detailsRepo.Update(d);


            });

            UpdateInvoiceTaxes(invoice, dataRepositoryFactory);
            return new Result<InvoiceLead>(0,0,"ok_msg",new List<InvoiceLead>() { invoice});
        }

        public static void AddQuoteDetails(InvoiceLead invoice, IDataRepositoryFactory dataRepositoryFactory)
        {
            var detailsRepo = dataRepositoryFactory.GetDataRepositories<LeadDetail>();

            invoice.LeadDetails.ForEach(x =>
            {
                x.InvoiceLeadId = invoice.Id;
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
