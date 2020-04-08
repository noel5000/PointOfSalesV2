import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { CashRegisterService } from './../../@core/services/CashRegisterService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { CashRegisterOpeningIndexComponent } from './index/cashRegisterOpeningIndex.component';
import { CashRegisterOpeningFormComponent } from './form/cashRegisterOpeningForm.component';
import { UserService } from '../../@core/mock/users.service';
import { CurrencyService } from '../../@core/services/CurrencyService';


const routes: Routes = [
    {
        path: "",
        component: CashRegisterOpeningIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: CashRegisterOpeningFormComponent
    },
    {
        path: "edit/:id",
        component: CashRegisterOpeningFormComponent
    },
    {
        path: "close/:id",
        component: CashRegisterOpeningFormComponent
    },
];

@NgModule({

    declarations: [CashRegisterOpeningFormComponent, CashRegisterOpeningIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        CashRegisterService,
        UserService,
        CurrencyService,
        ModalService
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


export class CashRegisterOpeningModule {

}