import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter, BillingStates } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl, endpointViewsUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';


declare const $: any;
@Component({
    selector: "Invoice-payment-list",
    templateUrl: "./invoicePaymentIndex.component.html",
    styleUrls: ["../invoicePaymentStyles.component.scss"]
})
export class InvoicePaymentIndexComponent extends BaseComponent implements OnInit {

    ngOnInit(): void {
        this.verifyUser();
        this.getPagedData(1);
    }
    modalRef:NgbModalRef=null;
    tableConfig:IPaginationModel[]=[]
    actions:IActionButtonModel[]=[];
    
    service:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}CustomerPayment`);
    pageNumber:number=1;
    pageSize:number=10;
    maxCount:number=0;
    filters: QueryFilter[] = [
        {
            property: "Customer",
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
    InvoicePayments:any[]=[];


    constructor(
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService
    ) {
        super(route, langService, AppSections.CustomerPayments,modalService);
        let scope = this;
       
        this.tableConfig=[
{
  visible:false,
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
      id:'customerId',
      type:'text',
      fieldToShow:'customer.name',
      isTranslated:false,
      name:this.lang.getValueByKey('customer_lbl'),
      sorting:'desc',
      toSort:true,
      objectType:ObjectTypes.String,
      filterIsActive:false
    },
    {
        visible:true,
        id:'sequence',
        type:'text',
        isTranslated:false,
        name:this.lang.getValueByKey('sequence_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:true
      },
      {
          visible:true,
          id:'invoiceNumber',
          type:'text',
          isTranslated:false,
          name:this.lang.getValueByKey('invoiceNumber_lbl'),
          sorting:'desc',
          toSort:true,
          objectType:ObjectTypes.String,
          filterIsActive:true
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
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('totalAmount_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:false
  },
  {
    visible:true,
    id:'paidAmount',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('paidAmount_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:false
  },
  {
    visible:true,
    id:'outstandingAmount',
    type:'currency',
    isTranslated:false,
    name:scope.lang.getValueByKey('owedAmount_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:false
  },
        ];
this.actions=[
       {
        title:scope.lang.getValueByKey('delete_btn'),
        class:'btn btn-danger',
        icon:'',
        id:'delete',
        visible:(item)=>{
            return item.state != BillingStates.Nulled;
        }
    },
    {
        title:scope.lang.getValueByKey('print_btn'),
        class:'btn btn-success',
        icon:'',
        id:'print'
    }
];
       
    }

    getStatusDescription(state:string):string{
        return this.lang.getValueByKey(`billingState${state}_lbl`);
      }

    rowAction(e){
        if(e && e.action && e.item){
            switch(e.action.id){
                    case 'delete':
                    this.onDeleteConfirm(e.item);
                    break;
                    case 'print':
                    this.print(e.item);
                    break;
            }
        }
    }

    getData() {
        this.service.getFiltered(this.pageNumber, this.pageSize, this.filters, this.orderBy, this.orderDirection).subscribe(r => {

            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            this.InvoicePayments=r['value'];
          
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
                property: "Customer",
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
        this.router.navigateByUrl(`pages/invoicepayment/add`);
    }
    print(e:any) {
     const user = JSON.parse(localStorage.getItem("currentUser"));
     this.router.navigate(['/externalRedirect', { externalUrl: `${endpointViewsUrl}views/InvoicePayment?sequence=${e.sequence}&language=${user.languageId}` }], {
        skipLocationChange: true,
    });
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

    delete(sequence: string) {
        this.service.deleteGeneric(`${sequence}/${this.authModel.user.userId}`,'','ReversePayment').subscribe(r => {
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
