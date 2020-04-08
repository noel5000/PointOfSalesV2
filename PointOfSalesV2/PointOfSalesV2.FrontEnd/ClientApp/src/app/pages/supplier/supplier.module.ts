import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { SupplierService } from './../../@core/services/supplierService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { SupplierIndexComponent } from './index/supplierIndex.component';
import { SupplierFormComponent } from './form/supplierForm.component';


const routes: Routes = [
    {
        path: "",
        component: SupplierIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: SupplierFormComponent
    },
    {
        path: "edit/:id",
        component: SupplierFormComponent
    },
];

@NgModule({

    declarations: [SupplierFormComponent, SupplierIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        SupplierService,
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


export class SupplierModule {

}