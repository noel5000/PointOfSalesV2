import { NgModule } from '@angular/core';
import { BranchOfficeIndexComponent } from './index/branchOfficeIndex.component';
import { BranchOfficeFormComponent } from './form/branchOfficeForm.component';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { BranchOfficeService } from './../../@core/services/branchOfficeService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';


const routes: Routes = [
    {
        path: "",
        component: BranchOfficeIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: BranchOfficeFormComponent
    },
    {
        path: "edit/:id",
        component: BranchOfficeFormComponent
    },
];

@NgModule({

    declarations: [BranchOfficeFormComponent, BranchOfficeIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        BranchOfficeService,
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


export class BranchOfficeModule {

}