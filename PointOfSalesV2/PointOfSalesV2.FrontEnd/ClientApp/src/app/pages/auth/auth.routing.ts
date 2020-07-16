import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';



export const AuthRoutes: Routes = [

    {
        path: '',
        children: [{
            path: 'login',
            component: LoginComponent
        },
            // {
            //     path: 'register',
            //     component: RegisterPageComponent
            // },
            // {
            //     path: 'changepassword',
            //     component: ChangePasswordComponent
            // },
            // {
            //     path: 'lock',
            //     component: LockComponent,
            //     canActivate: [AuthGuard]
            // },
        ]
    }
];
