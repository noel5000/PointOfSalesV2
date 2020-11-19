import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { PagesComponent } from './pages.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { BranchOfficeIndexComponent } from './branchOffice/index/branchOfficeIndex.component';
import { BranchOfficeFormComponent } from './branchOffice/form/branchOfficeForm.component';
import { UnitFormComponent } from './unit/form/unitForm.component';
import { UnitIndexComponent } from './unit/index/unitIndex.component';
import { TaxFormComponent } from './tax/form/taxForm.component';
import { TaxIndexComponent } from './tax/index/taxIndex.component';
import { CurrencyIndexComponent } from './currency/index/currencyIndex.component';
import { CurrencyFormComponent } from './currency/form/currencyForm.component';
import { ZoneIndexComponent } from './zone/index/zoneIndex.component';
import { ZoneFormComponent } from './zone/form/zoneForm.component';
import { TRNControlFormComponent } from './trnControl/form/trnControlForm.component';
import { TRNControlIndexComponent } from './trnControl/index/trnControlIndex.component';
import { WarehouseFormComponent } from './warehouse/form/warehouseForm.component';
import { WarehouseIndexComponent } from './warehouse/index/warehouseIndex.component';
import { CustomerIndexComponent } from './customer/index/customerIndex.component';
import { CustomerFormComponent } from './customer/form/CustomerForm.component';
import { ProductIndexComponent } from './product/index/productIndex.component';
import { ProductFormComponent } from './product/form/productForm.component';
import { SellerIndexComponent } from './seller/index/sellerIndex.component';
import { SellerFormComponent } from './seller/form/sellerForm.component';
import { SupplierFormComponent } from './supplier/form/supplierForm.component';
import { SupplierIndexComponent } from './supplier/index/supplierIndex.component';
import { UserIndexComponent } from './user/index/userIndex.component';
import { UserFormComponent } from './user/form/userForm.component';
import { RoleIndexComponent } from './role/index/roleIndex.component';
import { RoleFormComponent } from './role/form/roleForm.component';
import { UserRoleFormComponent } from './userRole/form/userRoleForm.component';
import { CashRegisterIndexComponent } from './cashRegister/index/cashRegisterIndex.component';
import { CashRegisterFormComponent } from './cashRegister/form/cashRegisterForm.component';
import { CashRegisterOpeningFormComponent } from './cashRegisterOpening/form/cashRegisterOpeningForm.component';
import { CashRegisterOpeningIndexComponent } from './cashRegisterOpening/index/cashRegisterOpeningIndex.component';
import { ExpenseFormComponent } from './expense/form/expenseForm.component';
import { ExpenseIndexComponent } from './expense/index/expenseIndex.component';
import { ExpensePaymentIndexComponent } from './expensePayment/index/expensePaymentIndex.component';
import { ExpensePaymentFormComponent } from './expensePayment/form/expensePaymentForm.component';
import { InventoryEntryFormComponent } from './inventoryEntry/form/inventoryEntryForm.component';
import { InventoryEntryIndexComponent } from './inventoryEntry/index/inventoryEntryIndex.component';
import { WarehouseTransferIndexComponent } from './warehouseTransfers/index/warehouseTransfersIndex.component';
import { WarehouseTransferFormComponent } from './warehouseTransfers/form/warehouseTransfersForm.component';
import { SupplierReturnIndexComponent } from './supplierReturn/index/supplierReturnIndex.component';
import { SupplierReturnFormComponent } from './supplierReturn/form/supplierReturnForm.component';
import { PriceListIndexComponent } from './priceListReport/index/priceListReportIndex.component';
import { CustomerListIndexComponent } from './customerListReport/index/customerListReportIndex.component';
import { InventoryReportIndexComponent } from './inventoryReport/index/inventoryReportIndex.component';
import { WarehouseMovementReportIndexComponent } from './warehouseMovementReport/index/warehouseMovementReportIndex.component';
import { InvoiceIndexComponent } from './invoice/index/invoiceIndex.component';
import { InvoiceFormComponent } from './invoice/form/invoiceForm.component';
import { InvoicePrintComponent } from './invoice/print/invoicePrint.component';
import { InvoicePaymentIndexComponent } from './invoicePayment/index/InvoicePaymentIndex.component';
import { InvoicePaymentFormComponent } from './invoicePayment/form/InvoicePaymentForm.component';
import { InvoicePaymentPrintComponent } from './invoicePayment/print/invoicePaymenPrint.component';
import { AccountsReceivableIndexComponent } from './accountsReceivablesReport/index/accountsReceivableIndex.component';
import { SalesReportIndexComponent } from './salesReport/index/salesReportIndex.component';
import { ReceiptsReportIndexComponent } from './receiptsReport/index/receiptsReportIndex.component';
import { DebtsToPayReportIndexComponent } from './debtsToPayReport/index/debtsToPayReportIndex.component';
import { AccountStateIndexComponent } from './accountState/index/accountStateIndex.component';
import { CompanyStateIndexComponent } from './companyState/index/companyStateIndex.component';
import { TaxReportIndexComponent } from './taxesReport/index/taxesReportIndex.component';
import { ComissionsReportIndexComponent } from './comissionsReport/index/comissionsReportIndex.component';
import { QuotesIndexComponent } from './quotes/index/quotesIndex.component';
import { QuotesFormComponent } from './quotes/form/quotesForm.component';
import { CustomerReturnIndexComponent } from './customerReturn/index/customerReturnIndex.component';
import { CustomerReturnFormComponent } from './customerReturn/form/customerReturnForm.component';

const routes: Routes = [{
  path: '',
  component: PagesComponent,
  children: [
    {
      path: 'dashboard',
      component: DashboardComponent,
    },
    {
      path: '',
      redirectTo: 'dashboard',
      pathMatch: 'full',
    },
    {
      path: 'branchoffice',
      component: BranchOfficeIndexComponent
    },
    {
      path: 'branchoffice/add',
      component: BranchOfficeFormComponent
    },
    {
      path: 'branchoffice/edit/:id',
      component: BranchOfficeFormComponent
    },


    {
      path: 'unit',
      component: UnitIndexComponent
    },
    {
      path: 'unit/add',
      component: UnitFormComponent
    },
    {
      path: 'unit/edit/:id',
      component: UnitFormComponent
    },


    {
      path: 'tax',
      component: TaxIndexComponent
    },
    {
      path: 'tax/add',
      component: TaxFormComponent
    },
    {
      path: 'tax/edit/:id',
      component: TaxFormComponent
    },
    {
      path: 'customerreturn',
      component: CustomerReturnIndexComponent
    },
    {
      path: 'customerreturn/add',
      component: CustomerReturnFormComponent
    },


    {
      path: 'currency',
      component: CurrencyIndexComponent
    },
    {
      path: 'currency/add',
      component: CurrencyFormComponent
    },
    {
      path: 'currency/edit/:id',
      component: CurrencyFormComponent
    },


    {
      path: 'zone',
      component: ZoneIndexComponent
    },
    {
      path: 'zone/add',
      component: ZoneFormComponent
    },
    {
      path: 'zone/edit/:id',
      component: ZoneFormComponent
    },


    {
      path: 'trncontrol',
      component: TRNControlIndexComponent
    },
    {
      path: 'trncontrol/add',
      component: TRNControlFormComponent
    },
    {
      path: 'trncontrol/edit/:id',
      component: TRNControlFormComponent
    },
    {
      path: 'warehouse',
      component: WarehouseIndexComponent
    },
    {
      path: 'warehouse/add',
      component: WarehouseFormComponent
    },
    {
      path: 'warehouse/edit/:id',
      component: WarehouseFormComponent
    },
    {
      path: 'user',
      component: UserIndexComponent
    },
    {
      path: 'user/add',
      component: UserFormComponent
    },
    {
      path: 'user/edit/:id',
      component: UserFormComponent
    },
    {
      path: 'role',
      component: RoleIndexComponent
    },
    {
      path: 'role/add',
      component: RoleFormComponent
    },
    {
      path: 'role/edit/:id',
      component: RoleFormComponent
    },
    {
      path: 'userrole/:id',
      component: UserRoleFormComponent
    },
    {
      path: 'customer',
      component: CustomerIndexComponent
    },
    {
      path: 'customer/add',
      component: CustomerFormComponent
    },
    {
      path: 'customer/edit/:id',
      component: CustomerFormComponent
    },


    {
      path: 'product',
      component: ProductIndexComponent
    },
    {
      path: 'product/add',
      component: ProductFormComponent
    },
    {
      path: 'product/edit/:id',
      component: ProductFormComponent
    },


    {
      path: 'seller',
      component: SellerIndexComponent
    },
    {
      path: 'seller/add',
      component: SellerFormComponent
    },
    {
      path: 'seller/edit/:id',
      component: SellerFormComponent
    },


    {
      path: 'supplier',
      component: SupplierIndexComponent
    },
    {
      path: 'supplier/add',
      component: SupplierFormComponent
    },
    {
      path: 'supplier/edit/:id',
      component: SupplierFormComponent
    },
    {
      path: 'cashregister',
      component: CashRegisterIndexComponent
    },
    {
      path: 'cashregister/add',
      component: CashRegisterFormComponent
    },
    {
      path: 'cashregister/edit/:id',
      component: CashRegisterFormComponent
    },
    
    {
      path: 'cashregisteropening',
      component: CashRegisterOpeningIndexComponent
    },
    {
      path: 'cashregisteropening/add',
      component: CashRegisterOpeningFormComponent
    },
    {
      path: 'cashregisteropening/edit/:id',
      component: CashRegisterOpeningFormComponent
    },
    {
      path: 'cashregisteropening/close/:id',
      component: CashRegisterOpeningFormComponent
    },
    {
      path: 'expense',
      component: ExpenseIndexComponent
    },
    {
      path: 'expense/add',
      component: ExpenseFormComponent
    },
    {
      path: 'expense/edit/:id',
      component: ExpenseFormComponent
    },
    {
      path: 'expensepayment',
      component: ExpensePaymentIndexComponent
    },
    {
      path: 'expensepayment/add',
      component: ExpensePaymentFormComponent
    },
    {
      path: 'inventoryentry',
      component: InventoryEntryIndexComponent
    },
    {
      path: 'inventoryentry/add',
      component: InventoryEntryFormComponent
    },
    {
      path: 'warehousetransfer',
      component: WarehouseTransferIndexComponent
    },
    {
      path: 'warehousetransfer/add',
      component: WarehouseTransferFormComponent
    },
    {
      path: 'supplierreturn',
      component: SupplierReturnIndexComponent
    },
    {
      path: 'supplierreturn/add',
      component: SupplierReturnFormComponent
    },
    {
      path: 'pricelist',
      component: PriceListIndexComponent
    },
    {
      path: 'customerlist',
      component: CustomerListIndexComponent
    },
    {
      path: 'inventoryreport',
      component: InventoryReportIndexComponent
    },
    {
      path: 'warehousemovements',
      component: WarehouseMovementReportIndexComponent
    },
    {
       path: 'invoice',
      component: InvoiceIndexComponent
     },
    {
      path: 'invoice/edit/:id',
      component: InvoiceFormComponent
    },
    {
      path: 'invoice/add',
      component: InvoiceFormComponent
    },
    {
      path: 'quotes',
     component: QuotesIndexComponent
    },
   {
     path: 'quotes/edit/:id',
     component: QuotesFormComponent
   },
   {
     path: 'quotes/add',
     component: QuotesFormComponent
   },
    {
      path: 'invoice/print/:id',
      component: InvoicePrintComponent
    },
    {
      path: 'invoicepayment',
     component: InvoicePaymentIndexComponent
    },
   {
     path: 'invoicepayment/edit/:id',
     component: InvoicePaymentFormComponent
   },
   {
     path: 'invoicepayment/add',
     component: InvoicePaymentFormComponent
   },
   {
     path: 'invoicepayment/print/:sequence',
     component: InvoicePaymentPrintComponent
   },
   {
    path: 'accountreceivables',
   component: AccountsReceivableIndexComponent
  },
  {
   path: 'salesreport',
  component: SalesReportIndexComponent
 },
 {
  path: 'receiptsreport',
 component: ReceiptsReportIndexComponent
},
{
 path: 'expensesreport',
component: DebtsToPayReportIndexComponent
},
{
 path: 'accountstate',
component: AccountStateIndexComponent
},

{
  path: 'companystate',
 component: CompanyStateIndexComponent
 },

 {
   path: 'taxesreport',
  component: TaxReportIndexComponent
  },

  {
    path: 'comissionsreport',
   component: ComissionsReportIndexComponent
   },
  ],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PagesRoutingModule {
}
