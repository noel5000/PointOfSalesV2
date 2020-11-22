import {
   Component,
  OnDestroy,
  OnInit,
  Input,
  Output,
  EventEmitter,
  Directive,
  QueryList, 
  ViewChildren 
} from '@angular/core';

import { map, takeUntil, filter } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { LanguageService } from '../../../@core/services/translateService';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointControllers, endpointUrl } from '../../../@core/common/constants';
import { AuthModel } from '../../../@core/data/authModel';
import { AppSections, ObjectTypes, BillingStates } from '../../../@core/common/enums';
import { DatePipe, CurrencyPipe } from '@angular/common';



export interface IPaginationModel{
  visible:boolean;
  filterIsActive:boolean;
  id:string;
  type:string;
  isTranslated:boolean,
  fieldToShow?:string;
  name:string;
  sorting:string;
  toSort:boolean;
  objectType:ObjectTypes,
  customText?(item:any):string
}
export interface IActionButtonModel{
  title:string;
  class:string;
  icon:string;
  id:string;
 visible? (item:any):boolean
}

export type SortDirection = 'asc' | 'desc' | '';
const rotate: {[key: string]: SortDirection} = { 'asc': 'desc', 'desc': '', '': 'asc' };
export const compare = (v1, v2) => v1 < v2 ? -1 : v1 > v2 ? 1 : 0;

export interface SortEvent {
column: string;
direction: SortDirection;
}

@Directive({
selector: 'th[sortable]',
host: {
  '[class.asc]': 'direction === "asc"',
  '[class.desc]': 'direction === "desc"',
  '(click)': 'rotate()'
}
})
export class NgbdSortableHeader {

@Input() sortable: string;
@Input() direction: SortDirection = '';
@Output() sort = new EventEmitter<SortEvent>();

rotate() {
  this.direction = rotate[this.direction];
  this.sort.emit({column: this.sortable, direction: this.direction});
}
}


@Component({
  selector: 'custom-pagination',
  styleUrls: ['./pagination.component.scss'],
  templateUrl: './pagination.component.html',
})
export class PaginationCompoment{
  datePipe = new DatePipe('en-US');
  currencyPipe = new CurrencyPipe('en-US');
    @Input() tableConfig:IPaginationModel[]=[];
    @Input() actions:IActionButtonModel[]=[];
    @Input() pageNumber:number=1;
    @Input() pageSize:number=10;
    @Input() isPaginated:boolean=true;
    @Input() showActions:boolean=true;
    @Input() maxCount:number=0;
    @Input() data:any[]=[];
    @Output() getPagedDataEvent: EventEmitter<any> = new EventEmitter<any>();
    @Output() addFilterEvent: EventEmitter<any> = new EventEmitter<any>();
    @Output() onSortEvent: EventEmitter<any> = new EventEmitter<any>();
    @Output() actionFuncEvent:EventEmitter<any>= new EventEmitter<any>();
    @ViewChildren(NgbdSortableHeader) headers: QueryList<NgbdSortableHeader>;

    constructor(private lang:LanguageService){}

    getTranslation(key:string){
      return this.lang.getValueByKey(key);
    }
   
    getPagedData(e){
      this.getPagedDataEvent.emit(e);
    }
    addFilter(config:IPaginationModel,val:any){
      this.addFilterEvent.emit({config:config,value:val.target.value});
    }
    onSort(e){
      this.onSortEvent.emit(e);
    }
    onActionClick(action:string, item:any){
      this.actionFuncEvent.emit({action:action, item:item});
    }
    showValue(item:any,prop:IPaginationModel):any{
      let result="";
      const property = prop.fieldToShow?prop.fieldToShow:prop.id;
      if(!property.includes('.'))
      result= item[property];
      else{
        const properties = property.split('.');
        let temp=item;
        properties.forEach(p=>{
          if(!temp[p])
          return '';

          temp= temp[p];
        });
        result= temp;
      }
      switch(prop.type){
        case 'bool':
          result=result?this.lang.getValueByKey('yes_lbl'):this.lang.getValueByKey('no_lbl');
          break;
          case 'date':
            result=result?this.datePipe.transform(new Date(result),'shortDate'):'';
          break;
          case 'dateTime':
            result=result?this.datePipe.transform(new Date(result),'short'):'';
          break;
          case 'currency':
            result=result?this.currencyPipe.transform(result,''):'';
          break;

      }
      if(prop.customText!=null){
        result = prop.customText(item);
      }
      return result;
    }

    verifyAction(action: IActionButtonModel, item:any):boolean{
      return action.visible?action.visible(item):true;
    }

    hideColumn(config:IPaginationModel,e:any){
      const index= this.tableConfig.findIndex(x=>x.id==config.id);
     
      if(index>=0){
        let currentConfig=this.tableConfig[index];
        currentConfig.visible=e.target.checked;
      this.tableConfig[index]=currentConfig;
      const data = this.data;
      this.data=[];
      this.data=data;
      }
    }

}


