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
import { TaxService } from '../../@core/services/TaxService';
import { CurrencyService } from '../../@core/services/CurrencyService';
import { UnitService } from '../../@core/services/UnitService';
import { SupplierService } from '../../@core/services/supplierService';
import { HttpClient } from '@angular/common/http';
import { BranchOfficeService } from '../../@core/services/branchOfficeService';
import { InventoryEntryIndexComponent } from './index/inventoryEntryIndex.component';
import { InventoryEntryFormComponent } from './form/inventoryEntryForm.component';
import { ProductService } from '../../@core/services/ProductService';
import { WarehouseService } from '../../@core/services/WarehouseService';


const routes: Routes = [
    {
        path: "",
        component: InventoryEntryIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: InventoryEntryFormComponent
    }
];

@NgModule({

    declarations: [InventoryEntryFormComponent, InventoryEntryIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ProductService,
        ModalService,
        CurrencyService,
        TaxService,
        BranchOfficeService,
        SupplierService,
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


export class InventoryEntryModule {

}