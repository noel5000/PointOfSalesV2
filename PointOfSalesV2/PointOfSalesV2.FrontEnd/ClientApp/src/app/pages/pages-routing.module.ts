import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { PagesComponent } from './pages.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { BranchOfficeIndexComponent } from './branchOffice/branchOfficeIndex.component';
import { BranchOfficeFormComponent } from './branchOffice/branchOfficeForm.component';

const routes: Routes = [{
  path: '',
  component: PagesComponent,
  children: [
    {
      path: 'dashboard',
      component: DashboardComponent,
    },
    {
      path: '',
      redirectTo: 'dashboard',
      pathMatch: 'full',
    },
    {
      path: 'branchoffice',
      component: BranchOfficeIndexComponent
    },
    {
      path: 'branchoffice/add',
      component: BranchOfficeFormComponent
    },
    {
      path: 'branchoffice/edit/:id',
      component: BranchOfficeFormComponent
    }
  ],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PagesRoutingModule {
}
