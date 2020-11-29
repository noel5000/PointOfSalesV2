import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { ProductService } from '../../../@core/services/ProductService';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { Product } from '../../../@core/data/product';


declare const $: any;
@Component({
    selector: "price-list",
    templateUrl: "./priceListReportIndex.component.html",
    styleUrls: ["../priceListReportStyles.component.scss"]
})
export class PriceListIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getPagedData(1);
    }
    modalRef:NgbModalRef=null;
    tableConfig:IPaginationModel[]=[]
    actions:IActionButtonModel[]=[];
    pageNumber:number=1;
    pageSize:number=10;
    maxCount:number=0;
    filters: QueryFilter[] = [
        {
            property: "Currency",
            value: "Name,Id,Code",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        }
    ];
    isPaginated:boolean=false;
    showActions:boolean=false;
    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    Products:Product[]=[];


    constructor(
        route: Router,
        langService: LanguageService,
        private service: ProductService,
        private modals:NgbModal,
       modalService:ModalService
    ) {
        super(route, langService, AppSections.PriceList,modalService);
        let scope = this;
       
        this.tableConfig=[
{
  visible:true,
  id:'id',
  type:'number',
  isTranslated:false,
  name:scope.lang.getValueByKey('id_lbl'),
  sorting:'desc',
  toSort:false,
  objectType:ObjectTypes.Number,
  filterIsActive:true
},
{
    visible:true,
    id:'name',
    type:'text',
    isTranslated:true,
    name:this.lang.getValueByKey('name_lbl'),
    sorting:'desc',
    toSort:false,
    objectType:ObjectTypes.String,
    filterIsActive:true
  },
  {
      visible:true,
      id:'description',
      type:'text',
      isTranslated:true,
      name:this.lang.getValueByKey('description_lbl'),
      sorting:'desc',
      toSort:false,
      objectType:ObjectTypes.String,
      filterIsActive:true
    },
    {
        visible:true,
        id:'sequence',
        type:'text',
        isTranslated:false,
        name:this.lang.getValueByKey('sequence_lbl'),
        sorting:'desc',
        toSort:false,
        objectType:ObjectTypes.String,
        filterIsActive:true
      },

      {
        visible:true,
        id:'currencyId',
        type:'text',
        fieldToShow:'currency.code',
        isTranslated:false,
        name:this.lang.getValueByKey('currency_lbl'),
        sorting:'desc',
        toSort:false,
        objectType:ObjectTypes.String,
        filterIsActive:false
      },
  {
    visible:true,
    id:'cost',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('cost_lbl'),
    sorting:'desc',
    toSort:false,
    objectType:ObjectTypes.Number,
    filterIsActive:true
  },
  {
    visible:true,
    id:'price',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('price_lbl'),
    sorting:'desc',
    toSort:false,
    objectType:ObjectTypes.Number,
    filterIsActive:true
  },
  {
    visible:true,
    id:'price2',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('price_lbl'),
    sorting:'desc',
    toSort:false,
    objectType:ObjectTypes.Number,
    filterIsActive:true
  },
  {
    visible:true,
    id:'price3',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('price_lbl'),
    sorting:'desc',
    toSort:false,
    objectType:ObjectTypes.Number,
    filterIsActive:true
  },
        ];
this.actions=[];
       
    }

 

    getData() {
        this.service.getAllFiltered(this.filters).subscribe(r => {

            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            this.Products=r['value'];
          
        },
            error => {  this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }

    
    getDataToExport() {
        this.service.getAllFilteredToExport(this.filters).subscribe(r => {

          this.service.downLoadFile(r,"application/ms-excel",`${this.lang.getValueByKey('pricesList_menu')}`);
          
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
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


 print(){
    window.print();
}

exportToCSV(){
   this.getDataToExport(); 
}
    getPagedData(page:number) {
        const expandFilters =[ {
            property: "Currency",
            value: "Name,Id,Code",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        } as QueryFilter
    ];
    expandFilters.forEach(expandFilter=>{
        const expandIndex = this.filters.findIndex(x => x.property == expandFilter.property);
        if (expandIndex >= 0) {
            this.filters.splice(expandIndex, 1);
            this.filters.push(expandFilter);
        }
        else {
            this.filters.push(expandFilter);
        }
    });
        
    

        this.pageNumber = page?page:1;
        this.orderBy='sequence';
        this.orderDirection='asc';
        this.getData();
    }

    onSort(e){
        let temp = e as IPaginationModel;
       let config = {
           sorting:temp.sorting,
           toSort:false,
           visible:temp.visible,
            id:temp.id,
  type:temp.type,
  isTranslated:temp.isTranslated,
  name:temp.name,
  objectType:temp.objectType,
  filterIsActive:temp.filterIsActive
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

   
    source:any={};
}