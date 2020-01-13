import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';


declare const $: any;
@Component({
    selector: "branch-Office-list",
    templateUrl: "./branchOfficeIndex.component.html",
    styleUrls: ["../branchOfficeStyles.component.scss"]
})
export class BranchOfficeIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getPagedData(1);
    }
    tableConfig:IPaginationModel[]=[]
    actions:IActionButtonModel[]=[];
    pageNumber:number=1;
    pageSize:number=10;
    maxCount:number=0;
    filters: QueryFilter[] = [];
    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    branchOffices:BranchOffice[]=[];


    constructor(
        route: Router,
        langService: LanguageService,
        private service: BranchOfficeService
    ) {
        super(route, langService, AppSections.BranchOffices);
        this.section=AppSections.BranchOffices;
        let scope = this;
       
        this.tableConfig=[
{
  visible:true,
  id:'id',
  type:'number',
  isTranslated:false,
  name:scope.lang.getValueByKey('id_label'),
  sorting:'desc',
  toSort:true,
  objectType:ObjectTypes.Number
},
{
    visible:true,
    id:'name',
    type:'text',
    isTranslated:true,
    name:this.lang.getValueByKey('name_label'),
    sorting:'desc',
    toSort:false,
    objectType:ObjectTypes.String
  }
        ];
this.actions=[
    {
        title:scope.lang.getValueByKey('edit_label'),
        class:'btn btn-primary',
        icon:''
    },
    {
        title:scope.lang.getValueByKey('delete_label'),
        class:'btn btn-danger',
        icon:''
    }
];
       
    }

    getData() {
        this.service.getFiltered(this.pageNumber, this.pageSize, this.filters, this.orderBy, this.orderDirection).subscribe(r => {

            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            this.branchOffices=r['value'];
          
        },
            error => {
                alert(`${this.lang.getValueByKey('error_msg')}: ${error.message}`);
            }
        )
    }
addFilter(e){
const config = e.config as IPaginationModel;
if(e.value)
this.filterData(e.value,config.id,config.objectType,config.isTranslated);
else{
  const index=  this.filters.findIndex(x=>x.property==config.id);
  if(index>-1){
      this.filters.splice(index,1);
    this.getPagedData(1);
  }
}


}
    getPagedData(page:number) {
        this.pageNumber = page?page:1;
        this.orderBy=this.tableConfig.find(x=>x.toSort).id;
        this.orderDirection=this.tableConfig.find(x=>x.toSort).sorting;
        this.getData();
    }

    onSort(e){
        let temp = e as IPaginationModel;
       let config = {
           sorting:temp.sorting,
           toSort:true,
           visible:temp.visible,
            id:temp.id,
  type:temp.type,
  isTranslated:temp.isTranslated,
  name:temp.name,
  objectType:temp.objectType
       };
       config.sorting=config.sorting=='desc'?'asc':'desc';
       config.toSort=true;
       this.tableConfig.forEach(c=>c.toSort=false);
       const index = this.tableConfig.findIndex(x=>x.id==config.id);
       if(index!== -1)
       this.tableConfig[index]=config;

       this.getPagedData(1);
    }
 

    filterData(currentValue: string, propertyName: string, propertyType: ObjectTypes, isTranslated:boolean=false) {
        const scope = this;
        let currentFilter = {
            property: propertyName,
            value: currentValue,
            type: propertyType,
            isTranslated:isTranslated
        } as QueryFilter;
        const index = this.filters.findIndex(x => x.property == currentFilter.property);
        if (index >= 0) {
            this.filters.splice(index, 1);
            this.filters.push(currentFilter);
        }
        else {
            this.filters.push(currentFilter);
        }
                scope.getData();  
       
      
           
      
        


    }

    addNew(e: any) {
        this.router.navigateByUrl(`pages/branchoffice/add`);
    }
    edit(e) {
        this.router.navigateByUrl(`pages/branchoffice/edit/${e.data.id}`);
    }
    source:any={};
    onDeleteConfirm(event): void {
        if (window.confirm(this.lang.getValueByKey('deleteConfirm_msg'))) {
            this.delete(event.data.id);

        }
    }

    delete(id: number) {
        this.service.delete(id).subscribe(r => {
            if (r.status >= 0) {
                alert(this.lang.getValueByKey('success_msg'))
                this.getData();
            }
            else
                alert(r.message);
        },
            error => {
                alert(this.lang.getValueByKey('error_msg'));
            })
    }
}