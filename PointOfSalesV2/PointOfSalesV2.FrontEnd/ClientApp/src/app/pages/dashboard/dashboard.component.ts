import { Component } from '@angular/core';
import { BaseComponent } from './../../@core/common/baseComponent';
import { Router } from '@angular/router';
import { AppSections } from '../../@core/common/enums';
import { LanguageService } from './../../@core/services/translateService';
import { ModalService } from '../../@core/services/modal.service';

@Component({
  selector: 'ngx-dashboard',
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent extends BaseComponent {
  constructor(route: Router, lang: LanguageService, modaService:ModalService) {
    super(route, lang, AppSections.DashBoard,modaService);
  }
}
