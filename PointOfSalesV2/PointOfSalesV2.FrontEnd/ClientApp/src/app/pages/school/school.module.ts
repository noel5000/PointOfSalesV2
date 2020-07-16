import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { SchoolService } from './../../@core/services/SchoolService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { SchoolIndexComponent } from './index/schoolIndex.component';
import { SchoolFormComponent } from './form/schoolForm.component';
import { ZoneService } from '../../@core/services/zoneService';
import { BranchOfficeService } from '../../@core/services/branchOfficeService';
import { CustomerService } from '../../@core/services/CustomerService';
import { WarehouseService } from '../../@core/services/WarehouseService';


const routes: Routes = [
    {
        path: "",
        component: SchoolIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: SchoolFormComponent
    },
    {
        path: "edit/:id",
        component: SchoolFormComponent
    },
];

@NgModule({

    declarations: [SchoolFormComponent, SchoolIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        SchoolService,
        ModalService,
        ZoneService,
        BranchOfficeService,
        CustomerService,
        WarehouseService
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


export class SchoolModule {

}