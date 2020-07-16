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
import { ProductService } from '../../@core/services/ProductService';
import { WarehouseService } from '../../@core/services/WarehouseService';
import { MenuEntryIndexComponent } from './index/menuEntryIndex.component';
import { MenuEntryFormComponent } from './form/menuEntryForm.component';
import{MatMenuModule} from '@angular/material/menu'
import { MatButtonModule } from '@angular/material/button';
import { MatButtonToggleModule } from '@angular/material';



const routes: Routes = [
    {
        path: "",
        component: MenuEntryIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: MenuEntryFormComponent
    }
];

@NgModule({

    declarations: [MenuEntryFormComponent, MenuEntryIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ProductService,
        ModalService,
        CurrencyService,
        TaxService,
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
        MatMenuModule,
        MatButtonModule,
        MatButtonToggleModule,
    ],
})


export class MenuEntryModule {

}