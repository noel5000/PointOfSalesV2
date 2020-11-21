import { NgModule } from '@angular/core';
import { NbMenuModule } from '@nebular/theme';

import { ThemeModule } from '../@theme/theme.module';
import { PagesComponent } from './pages.component';
import { DashboardModule } from './dashboard/dashboard.module';
import { PagesRoutingModule } from './pages-routing.module';
import { LanguageService } from './../@core/services/translateService';
import { SecurityService } from '../@core/services/securityService';
import { BranchOfficeModule } from './branchOffice/branchOffice.module';
import { TranslateModule } from '@ngx-translate/core';
import { NgbdModalConfirmAutofocus } from '../@theme/components/modal/modal.component';
import { ReactiveFormsModule } from '@angular/forms';
import { WarehouseModule } from './warehouse/warehouse.module';
import { TRNControlModule } from './trnControl/trnControl.module';
import { ZoneModule } from './zone/zone.module';
import { CurrencyModule } from './currency/currency.module';
import { TaxModule } from './tax/tax.module';
import { UnitModule } from './unit/unit.module';
import { CustomerModule } from './customer/customer.module';
import { ProductModule } from './product/product.module';
import { SupplierModule } from './supplier/supplier.module';
import { SellerModule } from './seller/seller.module';
import { UserModule } from './user/user.module';
import { RoleModule } from './role/role.module';
import { UserRoleModule } from './userRole/userRole.module';
import { CashRegisterModule } from './cashRegister/cashRegister.module';
import { CashRegisterOpeningModule } from './cashRegisterOpening/cashRegisterOpening.module';
import { ExpenseModule } from './expense/expense.module';
import { ExpensePaymentService } from '../@core/services/expensePaymentService';
import { ExpensePaymentModule } from './expensePayment/expensePayment.module';
import { InventoryEntryModule } from './inventoryEntry/inventoryEntry.module';
import { WarehouseTransferModule } from './warehouseTransfers/warehouseTransfers.module';
import { SupplierReturnModule } from './supplierReturn/supplierReturn.module';
import { PriceListModule } from './priceListReport/priceListReport.module';
import { CustomerListModule } from './customerListReport/customerListReport.module';
import { InventoryReportModule } from './inventoryReport/inventoryReport.module';
import { WarehouseMovementReportModule } from './warehouseMovementReport/warehouseMovementReport.module';
import{MatMenuModule} from '@angular/material/menu'
import { MatButtonModule } from '@angular/material/button';
import { MatButtonToggleModule } from '@angular/material';
import { InvoiceModule } from './invoice/invoice.module';
import { InvoicePaymentModule } from './invoicePayment/invoicePayment.module';
import { AccountsReceivableModule } from './accountsReceivablesReport/accountsReceivable.module';
import { SalesReportModule } from './salesReport/salesReport.module';
import { ReceiptsReportModule } from './receiptsReport/receiptsReport.module';
import { DebtsToPayReportModule } from './debtsToPayReport/debtsToPayReport.module';
import { AccountStateModule } from './accountState/accountState.module';
import { CompanyStateModule } from './companyState/companyState.module';
import { TaxReportModule } from './taxesReport/taxesReport.module';
import { ComissionsReportModule } from './comissionsReport/comissionsReport.module';
import { quotesModule } from './quotes/quote.module';
import { CustomerReturnModule } from './customerReturn/customerReturn.module';
import { httpInterceptorProviders } from '../@core/services/baseService';

@NgModule({
  imports: [

    PagesRoutingModule,
    ThemeModule,
    NbMenuModule,
    DashboardModule,
    BranchOfficeModule,
    UnitModule,
    TaxModule,
    CurrencyModule,
    ZoneModule,
    TRNControlModule,
    WarehouseModule,
    UserModule,
    CustomerModule,
    ProductModule,
    RoleModule,
    UserRoleModule,
    SupplierModule,
    SellerModule,
    CashRegisterModule,
    CashRegisterOpeningModule,
    ReactiveFormsModule,
    ExpenseModule,
    ExpensePaymentModule,
    InventoryEntryModule,
    WarehouseTransferModule,
    SupplierReturnModule,
    PriceListModule,
    CustomerListModule,
    InventoryReportModule,
    WarehouseMovementReportModule,
    InvoiceModule,
    quotesModule,
    InvoicePaymentModule,
    AccountsReceivableModule,
    SalesReportModule,
    ReceiptsReportModule,
    DebtsToPayReportModule,
    AccountStateModule,
    CompanyStateModule,
    TaxReportModule,
    CustomerReturnModule,
    ComissionsReportModule
  ],
  declarations: [
    PagesComponent,
  ],
  providers: [
    LanguageService,
    SecurityService,
  ],
  entryComponents:[NgbdModalConfirmAutofocus],
  exports:[MatMenuModule,
    MatButtonModule,
    MatButtonToggleModule,],
})
export class PagesModule {
}
