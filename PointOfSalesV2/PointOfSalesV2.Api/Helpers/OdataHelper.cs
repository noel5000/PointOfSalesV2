using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Builder;
using Microsoft.OData.Edm;
using PointOfSalesV2.Entities;
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
            builder.EntitySet<Invoice>("Invoice");
            builder.EntitySet<InvoiceDetail>("InvoiceDetail");
            builder.EntitySet<Product>("Product");
            builder.EntitySet<CashRegister>("CashRegister");
            builder.EntitySet<LanguageKey>("LanguageKey").EntityType.HasKey(x=>new {x.LanguageCode,x.Key });
            builder.EntitySet<CashRegisterOpening>("CashRegisterOpening");
            builder.EntitySet<CustomerPayment>("CustomerPayment");
            builder.EntitySet<CompositeProduct>("CompositeProduct");
            builder.EntitySet<CreditNote>("CreditNote");
            builder.EntitySet<Currency>("Currency");
            builder.EntitySet<Customer>("Customer");
            builder.EntitySet<CustomerBalance>("CustomerBalance");
            builder.EntitySet<CustomerReturn>("CustomerReturn");
            builder.EntitySet<CustomerReturnDetail>("CustomerReturnDetail");
            builder.EntitySet<Expense>("Expense");
            builder.EntitySet<ExpenseTax>("ExpenseTax");
            builder.EntitySet<ExpensesPayment>("ExpensesPayment");
            builder.EntitySet<InventoryEntry>("InventoryEntry");
            builder.EntitySet<Invoice>("Invoice");
            builder.EntitySet<InvoiceDetail>("InvoiceDetail");
            builder.EntitySet<InvoiceTax>("InvoiceTax");
            builder.EntitySet<BranchOffice>("BranchOffice").EntityType.HasKey(x=>x.Id).Property(x=>x.TranslationData).IsFilterable().IsNavigable();
            builder.EntitySet<MovementType>("MovementType");
            builder.EntitySet<OpeningAmount>("OpeningAmount");
            builder.EntitySet<PaymentType>("PaymentType");
            builder.EntitySet<PaymentDetail>("PaymentDetail");
            builder.EntitySet<Product>("Product");
            builder.EntitySet<ProductTax>("ProductTax");
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
            builder.EntitySet<Warehouse>("Warehouse");
            builder.EntitySet<WarehouseMovement>("WarehouseMovement");
            builder.EntitySet<Inventory>("Inventory");
            builder.EntitySet<WarehouseTransfer>("WarehouseTransfer");
            builder.EntitySet<Zone>("Zone");
            builder.EntitySet<Section>("Section");
            builder.EntitySet<SectionOperation>("SectionOperation");
            builder.EntitySet<Operation>("Operation");
            builder.EntitySet<Role>("Role");
            builder.EntitySet<RoleSection>("RoleSection");
            builder.EntitySet<User>("User");
            builder.EntitySet<UserClaims>("UserClaims");
            builder.EntitySet<UserRole>("UserRole");

            return builder.GetEdmModel();
        }
    }
}
