

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { LanguageService } from '../../../@core/services/translateService';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';


declare const $: any;
@Component({
    selector: "branch-Office-form",
    templateUrl: "./branchOfficeForm.component.html",
    styleUrls: ["../branchOfficeStyles.component.scss"]
})
export class BranchOfficeFormComponent extends BaseComponent implements OnInit {

    _route:ActivatedRoute;

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: BranchOfficeService,
        private modals:NgbModal,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.BranchOffices,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            id: [0]
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
    
     this.verifyUser();
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name
            });
           
        }
        
        this.validateFormData();
    })
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as BranchOffice;
      
           if(!this.item)
           this.item = new BranchOffice();

          
           this.item=  this.updateModel<BranchOffice>(formValue,this.item);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/branchoffice');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/branchoffice');
    }
}