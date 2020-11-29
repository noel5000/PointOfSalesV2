import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';


declare const $: any;
@Component({
    selector: "inventory-entry-list",
    templateUrl: "./inventoryEntryIndex.component.html",
    styleUrls: ["../inventoryEntryStyles.component.scss"]
})
export class InventoryEntryIndexComponent extends BaseComponent implements OnInit {
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
            property: "BranchOffice",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        {
            property: "Warehouse",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        {
            property: "Product",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        {
            property: "Supplier",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        {
            property: "Unit",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        {
            property: "Currency",
            value: "Name,Id,Code",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        }
    ];
    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    InventoryEntries:any[]=[];
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}InventoryEntry`);

    constructor(
        route: Router,
        private  http: HttpClient,
        langService: LanguageService,
        private modals:NgbModal,
       modalService:ModalService
    ) {
        super(route, langService, AppSections.InventoryIncomes,modalService);
        let scope = this;
       
        this.tableConfig=[
            {
                visible:false,
                id:'id',
                type:'number',
                isTranslated:false,
                name:this.lang.getValueByKey('id_lbl'),
                sorting:'desc',
                toSort:true,
                objectType:ObjectTypes.Number,
                filterIsActive:false
              },
{
  visible:true,
  id:'sequence',
  type:'text',
  isTranslated:false,
  name:scope.lang.getValueByKey('sequence_lbl'),
  sorting:'desc',
  toSort:true,
  objectType:ObjectTypes.String,
  filterIsActive:true
},
{
    visible:true,
    id:'branchOfficeId',
    type:'text',
    fieldToShow:'branchOffice.name',
    isTranslated:false,
    name:this.lang.getValueByKey('branchOffice_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:false
  },
  {
      visible:true,
      id:'warehouseId',
      type:'text',
      fieldToShow:'warehouse.name',
      isTranslated:false,
      name:this.lang.getValueByKey('warehouse_lbl'),
      sorting:'desc',
      toSort:true,
      objectType:ObjectTypes.String,
      filterIsActive:false
    },
{
    visible:true,
    id:'productId',
    type:'text',
    fieldToShow:'product.name',
    isTranslated:false,
    name:this.lang.getValueByKey('product_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:false
  },
    {
        visible:true,
        id:'quantity',
        type:'number',
        isTranslated:false,
        name:this.lang.getValueByKey('quantity_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:false
      },
      {
        visible:true,
        id:'unitId',
        type:'text',
        fieldToShow:'unit.name',
        isTranslated:false,
        name:this.lang.getValueByKey('unit_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:false
      },
    {
        visible:true,
        id:'date',
        type:'dateTime',
        isTranslated:false,
        name:this.lang.getValueByKey('date_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:false
      },
      {
        visible:true,
        id:'currencyId',
        type:'text',
        fieldToShow:'currency.code',
        isTranslated:false,
        name:this.lang.getValueByKey('currency_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:false
      },
  {
    visible:true,
    id:'totalAmount',
    type:'number',
    isTranslated:false,
    name:scope.lang.getValueByKey('totalAmount_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:false
  }
        ];
this.actions=[
    {
        title:scope.lang.getValueByKey('reverse_btn'),
        class:'btn btn-danger',
        icon:'',
        id:'delete'
    }
];
       
    }

    rowAction(e){
        if(e && e.action && e.item){
            switch(e.action.id){
                case 'delete':
                    this.onDeleteConfirm(e.item);
                    break;
            }
        }
    }

    getData() {
        this.service.getFiltered(this.pageNumber, this.pageSize, this.filters, this.orderBy, this.orderDirection).subscribe(r => {

            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            this.InventoryEntries=r['value'];
          
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
    getPagedData(page:number) {

        const expandFilters =[
            {
                property: "BranchOffice",
                value: "Name",
                type: ObjectTypes.ChildObject,
                isTranslated:false
            },
            {
                property: "Warehouse",
                value: "Name",
                type: ObjectTypes.ChildObject,
                isTranslated:false
            },
            {
                property: "Product",
                value: "Name",
                type: ObjectTypes.ChildObject,
                isTranslated:false
            },
            {
                property: "Supplier",
                value: "Name",
                type: ObjectTypes.ChildObject,
                isTranslated:false
            },
            {
                property: "Unit",
                value: "Name",
                type: ObjectTypes.ChildObject,
                isTranslated:false
            },
            {
                property: "Currency",
                value: "Name,Id,Code",
                type: ObjectTypes.ChildObject,
                isTranslated:false
            }
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

    addNew() {
        this.router.navigateByUrl(`pages/inventoryentry/add`);
    }
    source:any={};
    onDeleteConfirm(event:any): void {
 var result =       this.modalService.confirmationModal({
            titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
            bodyText:this.lang.getValueByKey('areYouSure_lbl'),
            cancelButtonText:this.lang.getValueByKey('cancel_btn'),
            okText:this.lang.getValueByKey('ok_btn'),
        });
  result.subscribe(r=>{
      if(r)
      this.delete(event.sequence);
  })
   
    }

    delete(id: string) {
        this.service.deleteGeneric(id,"","DeleteEntries").subscribe(r => {
            if (r.status >= 0) {
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'))
                this.getData();
            }
            else
             this.modalService.showError(r.message);
        },
            error => {
                this.modalService.showError();
            })
    }
}