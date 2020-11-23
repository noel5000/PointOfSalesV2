/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
import { Component, OnInit } from '@angular/core';
import { AnalyticsService } from './@core/utils/analytics.service';
import { TranslateService } from '@ngx-translate/core';
import { BaseComponent } from './@core/common/baseComponent';
import { Router } from '@angular/router';
import { LanguageService } from './@core/services/translateService';
import { AppSections } from './@core/common/enums';
import { BaseService } from './@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from './@core/common/constants';
import { ModalService } from './@core/services/modal.service';

@Component({
  selector: 'ngx-app',
  template: '<router-outlet></router-outlet>',
})
export class AppComponent extends BaseComponent implements OnInit {

  
  sessionService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Login`);
  constructor(private analytics: AnalyticsService, 
    translate: TranslateService,
    route: Router,
   modalService:ModalService,
    private  http: HttpClient,
    langService: LanguageService,) {
    super(route, langService, AppSections.DashBoard,modalService);
    translate.setDefaultLang('ES');
    translate.use('ES')
  }
  ngOnInit() {
    this.analytics.trackPageViews();
    this.validateSession();
  }

  validateSession(){
    const scope = this;
    setInterval(function () {
      scope.sessionService.getByUrlParameters(["VerifySession"]).subscribe(x=>{
        if(x.status<0){
          scope.modalService.showError('sessionTimeOut_error');
         scope.returnToLogin(); 
        }
      });
   
  }, 60000);
  }
}
