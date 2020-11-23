

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes, ODataComparers } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Currency } from '../../../@core/data/currencyModel';
import { Unit } from '../../../@core/data/unitModel';
import { Supplier } from '../../../@core/data/Supplier';
import { Tax } from '../../../@core/data/taxModel';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { UnitService } from '../../../@core/services/UnitService';
import { SupplierService } from '../../../@core/services/supplierService';
import { TaxService } from '../../../@core/services/TaxService';
import { endpointUrl } from '../../../@core/common/constants';
import { Role } from '../../../@core/data/roleModel';


declare const $: any;
@Component({
    selector: "role-form",
    templateUrl: "./roleForm.component.html",
    styleUrls: ["../roleStyles.component.scss"]
})
export class RoleFormComponent extends BaseComponent implements OnInit {

    isServiceFlag:boolean=false;
    isCompositeFlag:boolean=false;

    _route:ActivatedRoute;
    roleSectionOperations:any[]=[];
    sections:any[]=[];
    sectionOperations:any[]=[];
    roleService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Role`);
    sectionOperationService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}SectionOperation`);
    sectionService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}Section`);
    roleSectionOperationService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}RoleSectionOperation`);
    


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.Roles,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            id: [0],
            sectionId: [0],
            sectionOperationId:[0],
            name:['',[Validators.required,Validators.minLength(3),Validators.maxLength(100)]]
        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        this.id=urlId;
        this.getItem(urlId);
     }
     else
     this.validateFormData();

     this.onChanges();
        this.verifyUser();
        this.getAllSections();
       
    }
async getAllSections(){
    this.sectionService.getAll().subscribe(r=>{this.sections=r});
}

async getRoleSectionOperations(id:number){
    this.roleSectionOperationService.getAllFiltered(
        [
            {
                property: 'RoleId',
                value: id.toString(),
                type: ObjectTypes.Number,
                isTranslated:false
            } as QueryFilter,
            {
                property: "Section",
                value: "Id,Name",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter,
            {
                property: "Operation",
                value: "Id,Name",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter,
        ]
    ).subscribe(r=>{
        this.roleSectionOperations=r['value'];
    });
}

async getSectionOperations(id:number){
    this.sectionOperationService.getAllFiltered(
        [
            {
                property: 'SectionId',
                value: id.toString(),
                type: ObjectTypes.Number,
                isTranslated:false
            } as QueryFilter,
            {
                property: "Operation",
                value: "Name,Id",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter
        ]
    ).subscribe(r=>{
        let sectionOperations=[
            {id:0,
            operation:{
                id:0,
                name:''
            }}];
        this.sectionOperations = sectionOperations.concat(r['value'])});
}
   async getItem(id:number, refreshForm=true){
    this.roleService.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name,
            });
            this.getRoleSectionOperations(this.item.id);
        }
        
        this.validateFormData();
    })
    }
    onChanges(): void {
        this.itemForm.valueChanges.subscribe(val => {
         
          if(!isNaN(val.sectionId)){
             let section =parseInt(val.sectionId);
              if(section>0)
              this.getSectionOperations(section);
          }
        });
      }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as Role;
      
           if(!this.item)
           this.item = new Role();
           this.item=  this.updateModel<Role>(formValue,this.item);
            const subscription = this.id>0?this.roleService.put(this.item):this.roleService.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl(`pages/role/edit/${r.id}`);
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
    this.router.navigateByUrl(`pages/role`);
    }


    deleteSectionOperation(operation:any){
       this.roleSectionOperationService.delete(operation.id).subscribe(r=>{this.getItem(this.id)});
    }

    saveSectionOperation(){
        const formVal = this.itemForm.value;
        const toSave ={
            id:0,
            roleId:formVal.id,
            sectionOperationId:formVal.sectionOperationId,
            active:true
        };

        this.roleSectionOperationService.post(toSave).subscribe(r=>{

            if(r.status>=0)
            this.modalService.showSuccess('success_msg')
            else
            this.modalService.showError(r.message);

            this.getItem(this.id);
        });
    }
}