import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { ProductService } from '../../@core/services/ProductService';
import { BranchOfficeService } from '../../@core/services/branchOfficeService';
import { WarehouseService } from '../../@core/services/WarehouseService';
import { CustomerService } from '../../@core/services/CustomerService';
import { CurrencyService } from '../../@core/services/CurrencyService';
import { SupplierService } from '../../@core/services/supplierService';
import { AccountStateIndexComponent } from './index/accountStateIndex.component';


const routes: Routes = [
    {
        path: "",
        component: AccountStateIndexComponent,
        pathMatch: "full"
    },
];

@NgModule({

    declarations: [AccountStateIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ModalService,
        CustomerService,
    ],
    imports: [
        NbCardModule,
        NgbDropdownModule,
        NgbAlertModule,
        NbIconModule,
        NbInputModule,
        ThemeModule,
        CommonModule,
        RouterModule.forChild(routes),
        ReactiveFormsModule,
        FormsModule,
        TranslateModule,
    ],
})


export class AccountStateModule {

}