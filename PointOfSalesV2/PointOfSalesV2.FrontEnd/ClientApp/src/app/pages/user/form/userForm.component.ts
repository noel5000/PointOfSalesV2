

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { UserService } from '../../../@core/services/UserService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes, ODataComparers } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { User } from '../../../@core/data/users';
import { HttpClient } from '@angular/common/http';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { Warehouse } from '../../../@core/data/Warehouse';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { CashRegisterService } from '../../../@core/services/CashRegisterService';
import { CashRegister } from '../../../@core/data/cashRegister';


declare const $: any;
@Component({
    selector: "user-form",
    templateUrl: "./userForm.component.html",
    styleUrls: ["../userStyles.component.scss"]
})
export class UserFormComponent extends BaseComponent implements OnInit {

    userId:string='';
    _route:ActivatedRoute;
    branchOffices:BranchOffice[]=[];
    warehouses:Warehouse[]=[];
    cashRegisters:any[]=[];
    languages:any[]=[];
    languagesService:BaseService<any,number>=new BaseService<any,number>(this.http, `${endpointUrl}language`);
    genders:any[]=[
        {
            name:this.lang.getValueByKey('male_lbl'),
             id:'M'
        },
        {
            name:this.lang.getValueByKey('female_lbl'),
             id:'F'
        }    
    ]

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: UserService,
        private modals:NgbModal,
        private warehouseService:WarehouseService,
        private http:HttpClient,
        private branchOfficeService: BranchOfficeService,
       modalService:ModalService,
        private cashRegisterService:CashRegisterService
        ){
            super(route, langService, AppSections.Users,modalService);
            this.dataToBackup="warehouses,cashRegisters";
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(30)]],
            lastName: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(30)]],
            address: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(200)]],
            phone: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(15)]],
            mobile: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(15)]],
            email: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(150)]],
            userName: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(30)]],
            password: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(30)]],
            branchOfficeId: [null,[ Validators.required,Validators.min(1)]],
            cashRegisterId: [null],
            cashRegisterOpenningTimeHours:[0],
            warehouseId: [null],
            languageCode: ['',[ Validators.required]],
            active:[false],
            birthDay:[''],
            gender: ['',[ Validators.required]],
            userId: ['']
        });
    }
    ngOnInit(): void {
        this.onChanges();
     const urlId=  this._route.snapshot.paramMap.get('id');
     if(urlId){
        this.userId=urlId;
        this.getItem(urlId);
     }
     else
     this.validateFormData();
     
        this.verifyUser();
        this.getBranchOffices();
        this.getLanguages();
    }
    onChanges(): void {
        this.itemForm.valueChanges.subscribe(val => {
         
          if(!isNaN(val.branchOfficeId)){
              const id=parseInt(val.branchOfficeId);
              if(id>0){
                  
        this.getCashRegisters(id);
        this.getBranchOfficeWarehouses(id);
              }
          }
        });
      }

   async getItem(id:string){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue(this.item);

        }
        this.validateFormData();
    })
    }
    getBranchOfficeWarehouses(branchOfficeId: number){
       this.warehouseService.getAllFiltered(
           [
            {
                property: 'BranchOfficeId',
                value: branchOfficeId.toString(),
                type: ObjectTypes.Number,
                isTranslated:false
            } as QueryFilter ,
            {
                property: 'Code',
                value: 'DEF',
                type: ObjectTypes.String,
                isTranslated:false,
                comparer: ODataComparers.NotEqual
            } as QueryFilter
           ]
       ).subscribe(x=>{
        this.warehouses= [{ name:'', id:null} as Warehouse];
        this.warehouses= this.warehouses.concat(x['value']);
        
        })
    }
    async getBranchOffices (){
        this.branchOfficeService.getAll().subscribe(r=>{
            this.branchOffices= [{id:null, name:''} as BranchOffice];
            this.branchOffices=this.branchOffices.concat(r);
        })
    }
    async getCashRegisters (branchId:number){
        this.cashRegisterService.getAllFiltered(
            [
                {
                    property: "BranchOfficeId",
                    value: branchId.toString(),
                    type: ObjectTypes.Number,
                    isTranslated: false
                } as QueryFilter
            ]
        ).subscribe(r=>{
            this.cashRegisters=[{id:null, name:''}];
           this.cashRegisters = this.cashRegisters.concat(r['value']);
        })
    }

    async getLanguages (){
        this.languagesService.getAll().subscribe(r=>{
            this.languages=[{id:null, name:''}];
            this.languages=this.languages.concat(r);
        })
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as User;
      
           if(!this.item)
           this.item = new User();

           this.item = this.updateModel<User>(formValue,this.item);
           this.item.branchOfficeId= parseInt(this.item.branchOfficeId.toString());
           this.item.warehouseId=this.item.warehouseId? parseInt(this.item.warehouseId.toString()):null;
           this.item.cashRegisterId=this.item.cashRegisterId? parseInt(this.item.cashRegisterId.toString()):null;
           this.item.cashRegister=null;
           this.item.branchOffice=null;
           this.item.warehouse=null;
           this.item.claims=null;
           this.item.permissions=null;
           this.item.tokenKey=null;
           this.item.userId=!this.item.userId?'00000000-0000-0000-0000-000000000000':this.item.userId;
            const subscription = this.userId?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/user');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/user');
    }
}