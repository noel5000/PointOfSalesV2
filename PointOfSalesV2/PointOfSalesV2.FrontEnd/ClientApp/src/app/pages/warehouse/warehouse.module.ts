import { NgModule } from '@angular/core';
import { WarehouseIndexComponent } from './index/warehouseIndex.component';
import { WarehouseFormComponent } from './form/warehouseForm.component';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { WarehouseService } from './../../@core/services/WarehouseService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';


const routes: Routes = [
    {
        path: "",
        component: WarehouseIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: WarehouseFormComponent
    },
    {
        path: "edit/:id",
        component: WarehouseFormComponent
    },
];

@NgModule({

    declarations: [WarehouseFormComponent, WarehouseIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        WarehouseService,
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


export class WarehouseModule {

}