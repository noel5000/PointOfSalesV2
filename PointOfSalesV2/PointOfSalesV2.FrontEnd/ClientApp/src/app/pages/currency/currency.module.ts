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
import { CurrencyIndexComponent } from './index/currencyIndex.component';
import { CurrencyFormComponent } from './form/currencyForm.component';
import { CurrencyService } from '../../@core/services/CurrencyService';


const routes: Routes = [
    {
        path: "",
        component: CurrencyIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: CurrencyFormComponent
    },
    {
        path: "edit/:id",
        component: CurrencyFormComponent
    },
];

@NgModule({

    declarations: [CurrencyFormComponent, CurrencyIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
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


export class CurrencyModule {

}