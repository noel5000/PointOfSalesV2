import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { UserService } from './../../@core/services/UserService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { WarehouseService } from '../../@core/services/WarehouseService';
import { BranchOfficeService } from '../../@core/services/branchOfficeService';
import { UserFormComponent } from './form/userForm.component';
import { UserIndexComponent } from './index/userIndex.component';
import { CashRegisterService } from '../../@core/services/CashRegisterService';


const routes: Routes = [
    {
        path: "",
        component: UserIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: UserFormComponent
    },
    {
        path: "edit/:id",
        component: UserFormComponent
    },
];

@NgModule({

    declarations: [UserFormComponent, UserIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        UserService,
        WarehouseService,
        BranchOfficeService,
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


export class UserModule {

}