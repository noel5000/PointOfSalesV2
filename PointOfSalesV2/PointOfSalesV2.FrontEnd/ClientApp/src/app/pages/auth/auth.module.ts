import { NgModule, ChangeDetectorRef } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthRoutes } from './auth.routing';
import { LoginComponent } from './components/login/login.component';
import { BaseService } from '../../@core/services/baseService';
import { NbAlertModule, NbCheckboxModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { NbAuthService } from '@nebular/auth';
import { TranslateModule } from '@ngx-translate/core';
import { LanguageService } from '../../@core/services/translateService';


@NgModule({
    imports: [

        TranslateModule,
        CommonModule,
        RouterModule.forChild(AuthRoutes),
        FormsModule,
        ReactiveFormsModule,
        NbAlertModule,
        NbCheckboxModule,
        NbIconModule,
        NbInputModule,
    ],
    declarations: [
        LoginComponent
    ],
    providers: [
        BaseService,
        NbAuthService,
        LanguageService

    ],
})

export class AuthModule { }
