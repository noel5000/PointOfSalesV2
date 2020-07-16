import { NgModule } from '@angular/core';
import { CustomerFormComponent } from './form/CustomerForm.component';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { CustomerService } from './../../@core/services/CustomerService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { CustomerIndexComponent } from './index/customerIndex.component';
import { CurrencyService } from '../../@core/services/CurrencyService';
import { TRNControlService } from '../../@core/services/TRNControlService';


const routes: Routes = [
    {
        path: "",
        component: CustomerIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: CustomerFormComponent
    },
    {
        path: "edit/:id",
        component: CustomerFormComponent
    },
];

@NgModule({

    declarations: [CustomerFormComponent, CustomerIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        CustomerService,
        TRNControlService,
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


export class CustomerModule {

}