

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes, ODataComparers } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';
import { Role, UserRole } from '../../../@core/data/roleModel';
import { User } from '../../../@core/data/users';


declare const $: any;
@Component({
    selector: "userRole-form",
    templateUrl: "./userRoleForm.component.html",
    styleUrls: ["../userRoleStyles.component.scss"]
})
export class UserRoleFormComponent extends BaseComponent implements OnInit {

    userId:string='';
    user:User;
    isServiceFlag:boolean=false;
    isCompositeFlag:boolean=false;

    _route:ActivatedRoute;
    userRoles:any[]=[];
    roles:any[]=[];
    userRoleService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}userRole`);
    userService:BaseService<any,string>= new BaseService<any,string>(this.http,`${endpointUrl}user`);
    roleService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}role`);
    


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.UserRoles,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            userName: [''],
            userId:[''],
            active:true,
            roleId:[0,[Validators.required,Validators.min(1)]]
        });
    }
    ngOnInit(): void {
     const urlId=  this._route.snapshot.paramMap.get('id');
     if(urlId){
        this.userId=urlId;
        this.getItem(urlId);
     }
     else
     this.validateFormData();
     
        this.verifyUser();
        this.getAllRoles();
       
    }
async getAllRoles(){
    this.roleService.getAll().subscribe(r=>{this.roles=r});
}

async getuserRoles(id:string){
    this.userRoleService.getAllFiltered(
        [
            {
                property: 'UserId',
                value: id.toString(),
                type: ObjectTypes.Number,
                isTranslated:false
            } as QueryFilter,
            {
                property: "Role",
                value: "Id,Name",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter,
           
        ]
    ).subscribe(r=>{
        this.userRoles=r['value'];
    });
}


   async getItem(id:string){
    this.userService.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.user=r.data[0];
            this.itemForm.patchValue({
                userName:this.user.userName,
                userId:this.user.userId
            });
            this.getuserRoles(this.user.userId);
        }
        this.validateFormData();
    })
    }

    get form() { return this.itemForm.controls; }
    saveRole(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as UserRole;
      
           if(!this.item)
           this.item = new UserRole();
           this.item=  this.updateModel<UserRole>(formValue,this.item);
           this.item.roleId=parseInt(this.item.roleId.toString());
           if(this.userRoles.findIndex(x=>x.roleId==this.item.roleId)<0){
            const subscription = this.userRoleService.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.getItem(this.userId);
               }
               else
               this.modalService.showError(r.message);
           })
           }
           
    }

    cancel(){
    this.router.navigateByUrl(`pages/user`);
    }


    deleteRole(userRole:UserRole){
       this.userRoleService.delete(userRole.id).subscribe(r=>{
           this.getItem(this.userId);
        });
    }

  
}