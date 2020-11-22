using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Builder;
using Microsoft.OData.Edm;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Helpers
{
    public class OdataHelper
    {
        public static IEdmModel GetEdmModel(IApplicationBuilder app)
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EnableLowerCamelCase();
            builder.EntitySet<LeadDetail>("LeadDetail");
            builder.EntitySet<CashRegister>("CashRegister");
            builder.EntitySet<LanguageKey>("LanguageKey").EntityType.HasKey(x => new { x.LanguageCode, x.Key });
            builder.EntitySet<CashRegisterOpening>("CashRegisterOpening");
            builder.EntitySet<CashRegisterOpeningDetail>("CashRegisterOpeningDetail").HasOptionalBinding(x => x.CashRegisterOpening, "CashRegisterOpening");
            builder.EntitySet<CustomerPayment>("CustomerPayment");
            builder.EntitySet<ProductSupplierCost>("ProductCost");
            builder.EntitySet<CompositeProduct>("CompositeProduct");
            builder.EntitySet<UnitProductEquivalence>("ProductUnit");
            builder.EntitySet<CreditNote>("CreditNote");
            builder.EntitySet<Currency>("Currency");
            builder.EntitySet<Customer>("Customer");
            builder.EntitySet<Customer>("Customer").HasOptionalBinding(x=>x.Zone,"Zone");
            builder.EntitySet<Customer>("Customer").HasOptionalBinding(x => x.Currency, "Currency");
            builder.EntitySet<Customer>("Customer").HasOptionalBinding(x => x.TRNControl, "TRNControl");
            builder.EntitySet<School>("School");
            builder.EntitySet<CustomerBalance>("CustomerBalance");
            builder.EntitySet<CustomerReturn>("CustomerReturn");
            builder.EntitySet<CustomerReturnDetail>("CustomerReturnDetail");
            builder.EntitySet<Expense>("Expense");
            builder.EntitySet<ExpenseTax>("ExpenseTax");
            builder.EntitySet<ExpensesPayment>("ExpensesPayment");
            builder.EntitySet<InventoryEntry>("InventoryEntry").HasOptionalBinding(x => x.BranchOffice, "BranchOffice");
            builder.EntitySet<InventoryEntry>("InventoryEntry").HasOptionalBinding(x => x.Warehouse, "Warehouse");
            builder.EntitySet<InventoryEntry>("InventoryEntry").HasOptionalBinding(x => x.Supplier, "Supplier");
            builder.EntitySet<InventoryEntry>("InventoryEntry").HasOptionalBinding(x => x.Product, "Product");
            builder.EntitySet<InventoryEntry>("InventoryEntry").HasOptionalBinding(x => x.Unit, "Unit");
            builder.EntitySet<InventoryEntry>("InventoryEntry").HasOptionalBinding(x => x.Currency, "Currency");
            builder.EntitySet<InvoiceLead>("InvoiceLead");
            builder.EntitySet<InvoiceTax>("InvoiceTax");
            builder.EntitySet<BranchOffice>("BranchOffice").HasManyBinding(x => x.Warehouses, "Warehouse");
            builder.EntitySet<MovementType>("MovementType");
            builder.EntitySet<OpeningAmount>("OpeningAmount");
            builder.EntitySet<PaymentType>("PaymentType");
            builder.EntitySet<PaymentDetail>("PaymentDetail");
            builder.EntitySet<Product>("Product").HasOptionalBinding(x=>x.Currency,"Currency");
            builder.EntitySet<ProductTax>("ProductTax").HasOptionalBinding(x=>x.Product,"Product");
            builder.EntitySet<ProductTax>("ProductTax").HasOptionalBinding(x=>x.Tax,"Tax");
            builder.EntitySet<ReturnDetail>("ReturnDetail");
            builder.EntitySet<Seller>("Seller");
            builder.EntitySet<SequenceControl>("SequenceControl");
            builder.EntitySet<SupplierReturn>("SupplierReturn");
            builder.EntitySet<Supplier>("Supplier");
            builder.EntitySet<Language>("Language");
            builder.EntitySet<SupplierBalance>("SupplierBalance");
            builder.EntitySet<Tax>("Tax");
            builder.EntitySet<TRNControl>("TRNControl");
            builder.EntitySet<Unit>("Unit");
            builder.EntitySet<UnitProductEquivalence>("UnitProductEquivalence");
            builder.EntitySet<Warehouse>("Warehouse").EntityType.HasKey(x => x.Id);
            builder.EntitySet<Warehouse>("Warehouse").HasOptionalBinding(x => x.BranchOffice, "BranchOffice");
            builder.EntitySet<WarehouseMovement>("WarehouseMovement");
            builder.EntitySet<Inventory>("Inventory");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer").HasOptionalBinding(x => x.Destiny, "Destiny");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer").HasOptionalBinding(x => x.DestinyBranchOffice, "DestinyBranchOffice");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer").HasOptionalBinding(x => x.Origin, "Origin");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer").HasOptionalBinding(x => x.OriginBranchOffice, "OriginBranchOffice");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer").HasOptionalBinding(x => x.Product, "Product");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer").HasOptionalBinding(x => x.Unit, "Unit");
            builder.EntitySet<Zone>("Zone");
            builder.EntitySet<Section>("Section");
            builder.EntitySet<SectionOperation>("SectionOperation");
            builder.EntitySet<Operation>("Operation");
            builder.EntitySet<Role>("Role");
            builder.EntitySet<RoleSectionOperation>("RoleSectionOperation").HasOptionalBinding(x => x.Operation, "Operation");
            builder.EntitySet<RoleSectionOperation>("RoleSectionOperation").HasOptionalBinding(x => x.Section, "Section");
            builder.EntitySet<User>("User");
            builder.EntitySet<UserClaims>("UserClaims");
            builder.EntitySet<UserRole>("UserRole");
            builder.EntitySet<CompanyPayments>("CompanyPayment");
            builder.EntitySet<CompanyPayments>("CompanyPayment").HasOptionalBinding(x => x.PaymentType, "PaymentType");
            builder.EntitySet<CompanyPayments>("CompanyPayment").HasOptionalBinding(x => x.Currency, "Currency");

            builder.EntitySet<SupplierReturn>("SupplierReturn");
            builder.EntitySet<SupplierReturn>("SupplierReturn").HasOptionalBinding(x => x.Currency, "Currency");
            builder.EntitySet<SupplierReturn>("SupplierReturn").HasOptionalBinding(x => x.BranchOffice, "BranchOffice");
            builder.EntitySet<SupplierReturn>("SupplierReturn").HasOptionalBinding(x => x.Warehouse, "Warehouse");
            builder.EntitySet<SupplierReturn>("SupplierReturn").HasOptionalBinding(x => x.Supplier, "Supplier");
            builder.EntitySet<SupplierReturn>("SupplierReturn").HasOptionalBinding(x => x.Product, "Product");
            builder.EntitySet<SupplierReturn>("SupplierReturn").HasOptionalBinding(x => x.Unit, "Unit");
            builder.EntitySet<School>("School").HasOptionalBinding(x => x.BranchOffice, "BranchOffice");
            builder.EntitySet<School>("School").HasOptionalBinding(x => x.Warehouse, "Warehouse");
            builder.EntitySet<School>("School").HasOptionalBinding(x => x.Currency, "Currency");

            builder.EntitySet<MenuDetail>("MenuDetail").HasOptionalBinding(x => x.Product, "Product");
            builder.EntitySet<MenuDetail>("MenuDetail").HasOptionalBinding(x => x.Unit, "Unit");
            builder.EntitySet<Invoice>("Invoice");
            builder.EntitySet<Invoice>("Invoice").HasOptionalBinding(x=>x.Customer,"Customer");
            builder.EntitySet<Invoice>("Invoice").HasOptionalBinding(x => x.Currency, "Currency");
            builder.EntitySet<Invoice>("Invoice").HasOptionalBinding(x => x.BranchOffice, "BranchOffice");
            builder.EntitySet<Invoice>("Invoice").HasOptionalBinding(x => x.Seller, "Seller");
            builder.EntitySet<Invoice>("Invoice").HasOptionalBinding(x => x.TRNControl, "TNRControl");


            return builder.GetEdmModel();
        }
    }
}
