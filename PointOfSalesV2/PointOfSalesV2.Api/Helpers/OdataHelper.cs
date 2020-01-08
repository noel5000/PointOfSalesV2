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
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder(app.ApplicationServices);
            builder.EntitySet<Invoice>("Invoices").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
            builder.EntitySet<InvoiceDetail>("InvoiceDetails").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
            builder.EntitySet<Product>("Products").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
                builder.EntitySet<CashRegister>("CashRegisters").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<LanguageKey>("LanguageKeys").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<CashRegisterOpening>("CashRegisterOpenings").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<CustomerPayment>("CustomersPayments").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<CompositeProduct>("CompositeProducts").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<CreditNote>("CreditNotes").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Currency>("Currencies").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Customer>("Customers").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<CustomerBalance>("CustomersBalance").EntityType.HasKey(x => x.Id).Filter(QueryOptionSetting.Allowed);
            builder.EntitySet<CustomerReturn>("CustomersReturns").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<CustomerReturnDetail>("CustomersReturnDetails").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Expense>("Expenses").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<ExpenseTax>("ExpenseTaxes").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<ExpensesPayment>("ExpensesPayments").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<InventoryEntry>("InventoryEntries").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Invoice>("Invoices").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<InvoiceDetail>("InvoicesDetails").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<InvoiceTax>("InvoicesTaxes").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<BranchOffice>("BranchOffices").EntityType.HasKey(x =>x.Id).Count().Expand().OrderBy().Page().Select().OrderBy().Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<MovementType>("MovementTypes").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<OpeningAmount>("OpeningsAmounts").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<PaymentType>("PaymentTypes").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<PaymentDetail>("PaymentDetails").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Product>("Products").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<ProductTax>("ProductTaxes").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<ReturnDetail>("ReturnDetails").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Seller>("Sellers").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<SequenceControl>("SequencesControl").EntityType.HasKey(x => x.Id).Filter(QueryOptionSetting.Allowed);
            builder.EntitySet<SupplierReturn>("SuppliersReturns").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Supplier>("Suppliers").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Language>("Languages").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<SupplierBalance>("SuppliersBalances").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Tax>("Taxes").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<TRNControl>("TRNsControl").EntityType.HasKey(x => x.Id).Filter(QueryOptionSetting.Allowed);
            builder.EntitySet<Unit>("Units").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<UnitProductEquivalence>("UnitProductsEquivalences").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Warehouse>("Warehouses").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<WarehouseMovement>("WarehousesMovements").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Inventory>("Inventory").EntityType.HasKey(x => x.Id).Filter(QueryOptionSetting.Allowed);
            builder.EntitySet<WarehouseTransfer>("WarehousesTransfers").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Zone>("Zones").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Section>("Sections").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<SectionOperation>("SectionOperations").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Operation>("Operations").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<Role>("Roles").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<RoleSection>("RoleSections").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<User>("Users").EntityType.HasKey(x =>x.UserId).Filter(QueryOptionSetting.Allowed);
         builder.EntitySet<UserClaims>("UsersClaims").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);

         builder.EntitySet<UserRole>("UserRoles").EntityType.HasKey(x =>x.Id).Filter(QueryOptionSetting.Allowed);
           
            return builder.GetEdmModel();
        }
    }
}
