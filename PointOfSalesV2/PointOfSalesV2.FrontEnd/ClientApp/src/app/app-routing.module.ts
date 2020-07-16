import { ExtraOptions, RouterModule, Routes, ActivatedRouteSnapshot } from '@angular/router';
import { NgModule, InjectionToken } from '@angular/core';
import {
  NbAuthComponent,
  NbLoginComponent,
  NbLogoutComponent,
  NbRegisterComponent,
  NbRequestPasswordComponent,
  NbResetPasswordComponent,
} from '@nebular/auth';
import { LoginComponent } from './pages/auth/components/login/login.component';
import { NotFoundComponent } from './not-found.component';

const externalUrlProvider= new InjectionToken('externalUrlRedirectResolver');
const deactivateGuard = new InjectionToken('deactivateGuard');

const routes: Routes = [
  {
    path: 'pages',
    loadChildren: () => import('./pages/pages.module')
      .then(m => m.PagesModule),
  },
  {
    path: 'auth',
    component: NbAuthComponent,
    children: [
      {
        path: '',
        component: LoginComponent,
      },
      {
        path: 'login',
        component: LoginComponent,
      },
      {
        path: 'register',
        component: NbRegisterComponent,
      },
      {
        path: 'logout',
        component: NbLogoutComponent,
      },
      {
        path: 'request-password',
        component: NbRequestPasswordComponent,
      },
      {
        path: 'reset-password',
        component: NbResetPasswordComponent,
      },
    ],
  },
  {path:'externalRedirect',
   canActivate:[externalUrlProvider],
     component:NotFoundComponent
    },
    { path: '', redirectTo: 'pages', pathMatch: 'full' },
];

const config: ExtraOptions = {
  useHash: false,
};

@NgModule({
  imports: [RouterModule.forRoot(routes, config)],
  exports: [RouterModule],
  providers:[
    {
      provide:externalUrlProvider,
      useValue:(route:ActivatedRouteSnapshot)=>{
        const externalUrl=route.paramMap.get('externalUrl');
        window.open(externalUrl,'_blank')
      }
    }
  ]
})
export class AppRoutingModule {
}

