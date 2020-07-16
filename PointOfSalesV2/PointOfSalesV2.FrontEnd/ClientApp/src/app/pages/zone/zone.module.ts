import { NgModule } from '@angular/core';
import { ZoneIndexComponent } from './index/zoneIndex.component';
import { ZoneFormComponent } from './form/zoneForm.component';
import { LanguageService } from '../../@core/services/translateService';
import { SecurityService } from '../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { ZoneService } from '../../@core/services/zoneService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';


const routes: Routes = [
    {
        path: "",
        component: ZoneIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: ZoneFormComponent
    },
    {
        path: "edit/:id",
        component: ZoneFormComponent
    },
];

@NgModule({

    declarations: [ZoneFormComponent, ZoneIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ZoneService,
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


export class ZoneModule {

}