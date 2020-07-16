import { NgModule } from '@angular/core';
import { NbCardModule } from '@nebular/theme';

import { ThemeModule } from '../../@theme/theme.module';
import { DashboardComponent } from './dashboard.component';
import { LanguageService } from './../../@core/services/translateService';
import { TranslateModule } from '@ngx-translate/core';
import { NgbPaginationModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  imports: [
    TranslateModule,
    NbCardModule,
    ThemeModule,
    NgbPaginationModule,
NgbDropdownModule
  ],
  declarations: [
    DashboardComponent,
  ],
  providers: [LanguageService]
})
export class DashboardModule { }
