

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { SupplierService } from '../../../@core/services/supplierService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Supplier } from '../../../@core/data/Supplier';


declare const $: any;
@Component({
    selector: "supplier-form",
    templateUrl: "./supplierForm.component.html",
    styleUrls: ["../supplierStyles.component.scss"]
})
export class SupplierFormComponent extends BaseComponent implements OnInit {

    _route:ActivatedRoute;

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: SupplierService,
        private modals:NgbModal,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.Suppliers,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            phoneNumber: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            cardId: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            address: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(200)]],
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
                name: this.item.name,
                phoneNumber: this.item.phoneNumber,
                cardId: this.item.cardId,
                address: this.item.address,
                id: this.item.id
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
       const formValue = this.itemForm.value as Supplier;
      
           if(!this.item)
           this.item = new Supplier();
           this.item=  this.updateModel<Supplier>(formValue,this.item);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/supplier');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/supplier');
    }
}