import { NgModule } from '@angular/core';
import { LanguageService } from '../../@core/services/translateService';
import { SecurityService } from '../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { TRNControlService } from '../../@core/services/TRNControlService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { TRNControlFormComponent } from '../trnControl/form/trnControlForm.component';
import { TRNControlIndexComponent } from './index/trnControlIndex.component';


const routes: Routes = [
    {
        path: "",
        component: TRNControlIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: TRNControlFormComponent
    },
    {
        path: "edit/:id",
        component: TRNControlFormComponent
    },
];

@NgModule({

    declarations: [TRNControlFormComponent, TRNControlIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        TRNControlService,
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


export class TRNControlModule {

}