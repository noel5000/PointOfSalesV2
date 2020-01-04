import { NgModule } from '@angular/core';
import { NbMenuModule } from '@nebular/theme';

import { ThemeModule } from '../@theme/theme.module';
import { PagesComponent } from './pages.component';
import { DashboardModule } from './dashboard/dashboard.module';
import { PagesRoutingModule } from './pages-routing.module';
import { LanguageService } from './../@core/services/translateService';

@NgModule({
  imports: [

    PagesRoutingModule,
    ThemeModule,
    NbMenuModule,
    DashboardModule,
  ],
  declarations: [
    PagesComponent,
  ],
  providers: [LanguageService]
})
export class PagesModule {
}
