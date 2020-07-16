import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { SellerService } from './../../@core/services/SellerService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { SellerIndexComponent } from './index/sellerIndex.component';
import { SellerFormComponent } from './form/sellerForm.component';
import { ZoneService } from '../../@core/services/zoneService';


const routes: Routes = [
    {
        path: "",
        component: SellerIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: SellerFormComponent
    },
    {
        path: "edit/:id",
        component: SellerFormComponent
    },
];

@NgModule({

    declarations: [SellerFormComponent, SellerIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        SellerService,
        ModalService,
        ZoneService
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


export class SellerModule {

}