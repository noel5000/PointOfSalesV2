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
import { AppSections, ObjectTypes } from '../../../@core/common/enums';



export interface IPaginationModel{
  visible:boolean;
  id:string;
  type:string;
  isTranslated:boolean,
  name:string;
  sorting:string;
  toSort:boolean;
  objectType:ObjectTypes
}
export interface IActionButtonModel{
  title:string;
  class:string;
  icon:string;
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
    @Input() tableConfig:IPaginationModel[]=[];
    @Input() actions:IActionButtonModel[]=[];
    @Input() pageNumber:number=1;
    @Input() pageSize:number=10;
    @Input() maxCount:number=0;
    @Input() data:any[]=[];
    @Output() getPagedDataEvent: EventEmitter<any> = new EventEmitter<any>();
    @Output() addFilterEvent: EventEmitter<any> = new EventEmitter<any>();
    @Output() onSortEvent: EventEmitter<any> = new EventEmitter<any>();
    @ViewChildren(NgbdSortableHeader) headers: QueryList<NgbdSortableHeader>;

   
    getPagedData(e){
      this.getPagedDataEvent.emit(e);
    }
    addFilter(config:IPaginationModel,val:any){
      this.addFilterEvent.emit({config:config,value:val.target.value});
    }
    onSort(e){
      this.onSortEvent.emit(e);
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

