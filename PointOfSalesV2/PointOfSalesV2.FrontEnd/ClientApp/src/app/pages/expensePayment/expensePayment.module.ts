import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { ExpenseService } from './../../@core/services/ExpenseService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { TaxService } from '../../@core/services/TaxService';
import { CurrencyService } from '../../@core/services/CurrencyService';
import { UnitService } from '../../@core/services/UnitService';
import { SupplierService } from '../../@core/services/supplierService';
import { HttpClient } from '@angular/common/http';
import { BranchOfficeService } from '../../@core/services/branchOfficeService';
import { ExpensePaymentFormComponent } from './form/expensePaymentForm.component';
import { ExpensePaymentIndexComponent } from './index/expensePaymentIndex.component';
import { ExpensePaymentService } from '../../@core/services/expensePaymentService';
import { SchoolService } from '../../@core/services/SchoolService';


const routes: Routes = [
    {
        path: "",
        component: ExpensePaymentIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: ExpensePaymentFormComponent
    },
    {
        path: "edit/:id",
        component: ExpensePaymentFormComponent
    },
];

@NgModule({

    declarations: [ExpensePaymentFormComponent, ExpensePaymentIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ExpenseService,
        ModalService,
        CurrencyService,
        TaxService,
        BranchOfficeService,
        SupplierService,
        SchoolService,
        ExpensePaymentService
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


export class ExpensePaymentModule {

}