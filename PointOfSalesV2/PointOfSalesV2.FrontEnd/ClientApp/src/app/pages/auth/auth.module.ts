import { NgModule, ChangeDetectorRef } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthRoutes } from './auth.routing';
import { LoginComponent } from './components/login/login.component';
import { BaseService } from '../../@core/services/baseService';
import { NbAlertModule, NbCheckboxModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { NbAuthService } from '@nebular/auth';


@NgModule({
    imports: [

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

    ],
})

export class AuthModule { }
