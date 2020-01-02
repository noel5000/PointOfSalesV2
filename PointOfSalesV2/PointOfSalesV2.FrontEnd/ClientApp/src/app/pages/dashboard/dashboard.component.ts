import { Component } from '@angular/core';
import { BaseComponent } from './../../@core/common/baseComponent';
import { basename } from 'path';
import { Router } from '@angular/router';
import { AppSections } from '../../@core/common/enums';

@Component({
  selector: 'ngx-dashboard',
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent extends BaseComponent {
  constructor(route: Router) {
    super(route, AppSections.DashBoard);
  }
}
