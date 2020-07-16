import { NgModule } from '@angular/core';
import { TaxIndexComponent } from './index/taxIndex.component';
import { TaxFormComponent } from './form/taxForm.component';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { TaxService } from './../../@core/services/TaxService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';


const routes: Routes = [
    {
        path: "",
        component: TaxIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: TaxFormComponent
    },
    {
        path: "edit/:id",
        component: TaxFormComponent
    },
];

@NgModule({

    declarations: [TaxFormComponent, TaxIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        TaxService,
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


export class TaxModule {

}