import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { UserService } from '../../../@core/services/UserService';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { User } from '../../../@core/data/users';


declare const $: any;
@Component({
    selector: "user-list",
    templateUrl: "./userIndex.component.html",
    styleUrls: ["../userStyles.component.scss"]
})
export class UserIndexComponent extends BaseComponent implements OnInit {
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
    filters: QueryFilter[] = [];
    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    Users:User[]=[];


    constructor(
        route: Router,
        langService: LanguageService,
        private service: UserService,
        private modals:NgbModal,
       modalService:ModalService
    ) {
        super(route, langService, AppSections.Users,modalService);
        let scope = this;
       
        this.tableConfig=[
{
  visible:true,
  id:'userId',
  type:'text',
  isTranslated:false,
  name:scope.lang.getValueByKey('id_lbl'),
  sorting:'desc',
  toSort:false,
  objectType:ObjectTypes.String,
  filterIsActive:false
},
{
    visible:true,
    id:'name',
    type:'text',
    isTranslated:false,
    name:this.lang.getValueByKey('name_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
  },
  {
      visible:true,
      id:'lastName',
      type:'text',
      isTranslated:false,
      name:this.lang.getValueByKey('lastName_lbl'),
      sorting:'desc',
      toSort:true,
      objectType:ObjectTypes.String,
      filterIsActive:true
    },
    {
        visible:true,
        id:'email',
        type:'text',
        isTranslated:false,
        name:this.lang.getValueByKey('email_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:true
      },
      {
        visible:true,
        id:'userName',
        type:'text',
        isTranslated:false,
        name:this.lang.getValueByKey('userName_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:true
      },
      
      {
        visible:true,
        id:'active',
        type:'bool',
        isTranslated:true,
        name:this.lang.getValueByKey('isActive_lbl'),
        sorting:'desc',
        toSort:true,
        objectType:ObjectTypes.String,
        filterIsActive:false
      },
    ];
this.actions=[
    {
        title:scope.lang.getValueByKey('edit_btn'),
        class:'btn btn-primary',
        icon:'',
        id:'edit'
    },{
        title:scope.lang.getValueByKey('addRole_btn'),
        class:'btn btn-warning',
        icon:'',
        id:'addRole'
    },
    {
        title:scope.lang.getValueByKey('delete_btn'),
        class:'btn btn-danger',
        icon:'',
        id:'delete'
    }
];
       
    }

    rowAction(e){
        if(e && e.action && e.item){
            switch(e.action.id){
                case 'edit':
                    this.edit(e.item);
                    break;

                    case 'addRole':
                        this.addRoles(e.item);
                        break;
                case 'delete':
                    this.onDeleteConfirm(e.item);
                    break;
            }
        }
    }

    getData() {
        this.service.getFiltered(this.pageNumber, this.pageSize, this.filters, this.orderBy, this.orderDirection).subscribe(r => {

            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            this.Users = r['value'];
          
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

    addNew() {
        this.router.navigateByUrl(`pages/user/add`);
    }
    edit(e:User) {
        this.router.navigateByUrl(`pages/user/edit/${e.userId}`);
    }

    addRoles(e:User) {
        this.router.navigateByUrl(`pages/userrole/${e.userId}`);
    }
    source:any={};
    onDeleteConfirm(event:User): void {
 var result =       this.modalService.confirmationModal({
            titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
            bodyText:this.lang.getValueByKey('areYouSure_lbl'),
            cancelButtonText:this.lang.getValueByKey('cancel_btn'),
            okText:this.lang.getValueByKey('ok_btn'),
        });
  result.subscribe(r=>{
      if(r)
      this.delete(event.userId);
  })
   
    }

    delete(id: string) {
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