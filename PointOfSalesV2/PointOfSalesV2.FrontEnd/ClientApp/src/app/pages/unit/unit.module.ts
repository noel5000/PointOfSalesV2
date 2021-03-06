import { NgModule } from '@angular/core';
import { UnitIndexComponent } from './index/unitIndex.component';
import { UnitFormComponent } from './form/unitForm.component';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { UnitService } from './../../@core/services/UnitService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';


const routes: Routes = [
    {
        path: "",
        component: UnitIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: UnitFormComponent
    },
    {
        path: "edit/:id",
        component: UnitFormComponent
    },
];

@NgModule({

    declarations: [UnitFormComponent, UnitIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        UnitService,
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


export class UnitModule {

}