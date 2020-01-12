import { Component, OnDestroy, OnInit } from '@angular/core';

import { map, takeUntil, filter } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { LanguageService } from '../../../@core/services/translateService';
import { BaseService } from '../../../@core/services/baseService';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { HttpClient } from '@angular/common/http';
import { endpointControllers, endpointUrl } from '../../../@core/common/constants';
import { AuthModel } from '../../../@core/data/authModel';
import { AppSections } from '../../../@core/common/enums';

@Component({
  selector: 'custom-pagination',
  styleUrls: ['./pagination.component.scss'],
  templateUrl: './pagination.component.html',
})
export class CustomPagination{
    ngOnDestroy(): void {
        throw new Error("Method not implemented.");
    }
    ngOnInit(): void {
        throw new Error("Method not implemented.");
    }

    constructor(
      private  route:Router,
       private lang:LanguageService
    ){
      

    }
}