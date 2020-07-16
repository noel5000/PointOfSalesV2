import { NgModule } from '@angular/core';
import { CashRegisterIndexComponent } from './index/cashRegisterIndex.component';
import { CashRegisterFormComponent } from './form/cashRegisterForm.component';
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


const routes: Routes = [
    {
        path: "",
        component: CashRegisterIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: CashRegisterFormComponent
    },
    {
        path: "edit/:id",
        component: CashRegisterFormComponent
    },
];

@NgModule({

    declarations: [CashRegisterFormComponent, CashRegisterIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        CashRegisterService,
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


export class CashRegisterModule {

}