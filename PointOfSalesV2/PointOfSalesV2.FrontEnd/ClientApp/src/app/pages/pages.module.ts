import { NgModule } from '@angular/core';
import { NbMenuModule } from '@nebular/theme';

import { ThemeModule } from '../@theme/theme.module';
import { PagesComponent } from './pages.component';
import { DashboardModule } from './dashboard/dashboard.module';
import { PagesRoutingModule } from './pages-routing.module';
import { LanguageService } from './../@core/services/translateService';
import { SecurityService } from '../@core/services/securityService';
import { BranchOfficeModule } from './branchOffice/branchOffice.module';
import { TranslateModule } from '@ngx-translate/core';
import { NgbdModalConfirmAutofocus } from '../@theme/components/modal/modal.component';

@NgModule({
  imports: [

    PagesRoutingModule,
    ThemeModule,
    NbMenuModule,
    DashboardModule,
    BranchOfficeModule
  ],
  declarations: [
    PagesComponent,
  ],
  providers: [
    LanguageService,
    SecurityService
  ],
  entryComponents:[NgbdModalConfirmAutofocus]
})
export class PagesModule {
}
