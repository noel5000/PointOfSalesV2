import { NgModule } from '@angular/core';
import { NbCardModule } from '@nebular/theme';

import { ThemeModule } from '../../@theme/theme.module';
import { DashboardComponent } from './dashboard.component';
import { LanguageService } from './../../@core/services/translateService';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
  imports: [
    TranslateModule,
    NbCardModule,
    ThemeModule,
  ],
  declarations: [
    DashboardComponent,
  ],
  providers: [LanguageService]
})
export class DashboardModule { }
