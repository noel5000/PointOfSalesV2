

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { TRNControlService } from '../../../@core/services/TRNControlService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { TRNControl } from '../../../@core/data/trnControlModel';


declare const $: any;
@Component({
    selector: "trn-control-form",
    templateUrl: "./trnControlForm.component.html",
    styleUrls: ["../trnControlStyles.component.scss"]
})
export class TRNControlFormComponent extends BaseComponent implements OnInit {

    _route:ActivatedRoute;

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: TRNControlService,
        private modals:NgbModal,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.TRNControl,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            quantity:  [0,[ Validators.required,Validators.min(1)]],
            numericControl:  [0,[ Validators.required,Validators.min(0)]],
            sequence: [0,[ Validators.required,Validators.min(0)]],
            type: ['',[ Validators.required]],
            series: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(1)]],
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
                name:this.item.name,
                quantity:this.item.quantity,
                numericControl:this.item.numericControl,
                sequence:this.item.sequence,
                type:this.item.type,
                series:this.item.series
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
       const formValue = this.itemForm.value as TRNControl;
      
           if(!this.item)
           this.item = new TRNControl();
          this.item=  this.updateModel<TRNControl>(formValue,this.item);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/trncontrol');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/trncontrol');
    }

   
}