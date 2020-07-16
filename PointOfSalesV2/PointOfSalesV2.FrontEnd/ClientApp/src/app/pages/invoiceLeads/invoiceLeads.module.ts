import { NgModule } from '@angular/core';
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
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { InvoiceLeadsIndexComponent } from './index/invoiceLeadsIndex.component';
import { FlatpickrModule } from 'angularx-flatpickr';
import { MatMenuModule, MatButtonModule, MatButtonToggleModule } from '@angular/material';
import { WarehouseService } from '../../@core/services/WarehouseService';
import { InvoiceLeadFormComponent } from './form/invoiceLeadForm.component';
import { SchoolService } from '../../@core/services/SchoolService';
import { InvoiceLeadPrintComponent } from './print/invoiceLeadsPrint.component';


const routes: Routes = [
    {
        path: "",
        component: InvoiceLeadsIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add/:menuid/:leadid/:schoolid/:branchofficeid/:warehouseid/:date",
        component: InvoiceLeadFormComponent
    },
    {
        path: "edit/:menuid/:leadid/:schoolid/:branchofficeid/:warehouseid/:date",
        component: InvoiceLeadFormComponent
    },
    {
        path: "print/:leadid/:menuid/:schoolid/:date/:sequence",
        component: InvoiceLeadPrintComponent
    },
];

@NgModule({

    declarations: [InvoiceLeadFormComponent, InvoiceLeadsIndexComponent,InvoiceLeadPrintComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        BranchOfficeService,
        WarehouseService,
        ModalService,
        SchoolService
    ],
    imports: [
        NbCardModule,
        MatMenuModule,
        MatButtonModule,
        MatButtonToggleModule,
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
        NgbModalModule,
        FlatpickrModule.forRoot(),
        CalendarModule.forRoot({
          provide: DateAdapter,
          useFactory: adapterFactory
        })
    ],
})


export class InvoiceLeadsModule {

}