import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter, BillingStates, CashRegisterOpeningStates } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { CashRegisterOpening } from '../../../@core/data/CashRegisterOpening';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';


declare const $: any;
@Component({
    selector: "cash-register-opening-list",
    templateUrl: "./cashRegisterOpeningIndex.component.html",
    styleUrls: ["../cashRegisterOpeningStyles.component.scss"]
})
export class CashRegisterOpeningIndexComponent extends BaseComponent implements OnInit {
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
            property: "user",
            value: "UserName",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        {
            property: "CashRegister",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        }
    ];
    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    CashRegisterOpenings:CashRegisterOpening[]=[];

    service:BaseService<CashRegisterOpening,number>=new BaseService<CashRegisterOpening,number>(this.http, `${endpointUrl}CashRegisterOpening`);

    constructor(
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private  http: HttpClient,
       modalService:ModalService
    ) {
        super(route, langService, AppSections.CashRegisterOpenings,modalService);
        let scope = this;
       
        this.tableConfig=[
{
  visible:true,
  id:'id',
  type:'number',
  isTranslated:false,
  name:scope.lang.getValueByKey('id_lbl'),
  sorting:'desc',
  toSort:true,
  objectType:ObjectTypes.Number,
  filterIsActive:true
},
{
    visible:true,
    id:'userId',
    type:'text',
    fieldToShow:'user.userName',
    isTranslated:false,
    name:this.lang.getValueByKey('user_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:false
  },
  {
    visible:true,
    id:'branchOfficeId',
    fieldToShow:'branchOffice.name',
    type:'text',
    isTranslated:false,
    name:scope.lang.getValueByKey('branchOffice_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:false
  },
  {
    visible:true,
    id:'cashRegisterId',
    fieldToShow:'cashRegister.name',
    type:'text',
    isTranslated:false,
    name:scope.lang.getValueByKey('cashRegister_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:false
  },
  {
    visible:true,
    id:'openingDate',
    type:'dateTime',
    isTranslated:false,
    name:scope.lang.getValueByKey('openingDate_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Date,
    filterIsActive:false
  },
  
  {
    visible:true,
    id:'maxClosureDate',
    type:'dateTime',
    isTranslated:false,
    name:scope.lang.getValueByKey('maxClosureDate_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Date,
    filterIsActive:false
  },
  
  {
    visible:true,
    id:'closureDate',
    type:'dateTime',
    isTranslated:false,
    name:scope.lang.getValueByKey('closureDate_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Date,
    filterIsActive:false
  },
  {
    visible:true,
    id:'totalOpeningAmount',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('openingAmount_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:false
  },
  {
    visible:true,
    id:'totalClosureAmount',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('closureAmount_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:false
  },
        ];
this.actions=[
    {
        title:scope.lang.getValueByKey('edit_btn'),
        class:'btn btn-primary',
        icon:'',
        id:'edit',
        visible:(item)=>{
            return item.state == CashRegisterOpeningStates.Open;
         }
   
    },
    {
        title:scope.lang.getValueByKey('closeCashRegister_btn'),
        class:'btn btn-warning',
        icon:'',
        id:'closeRegister',
        visible:(item)=>{
            return item.state == CashRegisterOpeningStates.Open;
         }
    },
    {
        title:scope.lang.getValueByKey('delete_btn'),
        class:'btn btn-danger',
        icon:'',
        id:'delete',
        visible:(item)=>{
            return item.state == CashRegisterOpeningStates.Open;
         }
    }
];
       
    }

    rowAction(e){
        if(e && e.action && e.item){
            switch(e.action.id){
                case 'edit':
                    this.edit(e.item);
                    break;
                case 'delete':
                    this.onDeleteConfirm(e.item);
                    break;
                case 'closeRegister':
                        this.closeCashRegister(e.item);
                        break;
            }
        }
    }

    getData() {
        this.service.getFiltered(this.pageNumber, this.pageSize, this.filters, this.orderBy, this.orderDirection).subscribe(r => {

            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            this.CashRegisterOpenings = r['value'];
          
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
        const expandFilters =[ {
            property: "BranchOffice",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        } as QueryFilter,
        {
            property: "CashRegister",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        } as QueryFilter,
        {
            property: "User",
            value: "UserName",
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
            fieldToShow:temp.fieldToShow,
  type:temp.type,
  filterIsActive:temp.filterIsActive,
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
       // &$expand=Press($select=Name)
      
        const currentFilter = {
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
    closeCashRegister(e:CashRegisterOpening) {
        this.router.navigateByUrl(`pages/cashregisteropening/close/${e.id}`);
    }

    addNew() {
        this.router.navigateByUrl(`pages/cashregisteropening/add`);
    }
    edit(e:CashRegisterOpening) {
        this.router.navigateByUrl(`pages/cashregisteropening/edit/${e.id}`);
    }
    source:any={};
    onDeleteConfirm(event:CashRegisterOpening): void {
 var result =       this.modalService.confirmationModal({
            titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
            bodyText:this.lang.getValueByKey('areYouSure_lbl'),
            cancelButtonText:this.lang.getValueByKey('cancel_btn'),
            okText:this.lang.getValueByKey('ok_btn'),
        });
  result.subscribe(r=>{
      if(r)
      this.delete(event.id);
  })
   
    }

    delete(id: number) {
        this.service.delete(id).subscribe(r => {
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