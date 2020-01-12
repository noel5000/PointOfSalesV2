import { Component, OnDestroy, OnInit, Input, Output, EventEmitter } from '@angular/core';

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
export class PaginationCompoment{
    @Input() tableConfig:IPaginationModel[]=[];
    @Input() actions:IActionButtonModel[]=[];
    @Input() pageNumber:number=1;
    @Input() pageSize:number=10;
    @Input() maxCount:number=0;
    @Input() data:any[]=[];
    @Output() getPagedData: EventEmitter<any> = new EventEmitter<any>();
    @Output() addFilter: EventEmitter<any> = new EventEmitter<any>();
    @Output() onSort: EventEmitter<any> = new EventEmitter<any>();

    constructor(
      private  route:Router,
       private lang:LanguageService
    ){
      

    }


}



export interface IPaginationModel{
    visible:boolean;
    id:string;
    type:string;
    search:string;
    name:string;
}
export interface IActionButtonModel{
    title:string;
    class:string;
    icon:string;
}