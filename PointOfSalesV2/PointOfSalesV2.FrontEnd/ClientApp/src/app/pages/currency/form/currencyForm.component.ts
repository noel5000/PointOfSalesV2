

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Currency } from '../../../@core/data/currencyModel';


declare const $: any;
@Component({
    selector: "currency-form",
    templateUrl: "./currencyForm.component.html",
    styleUrls: ["../currencyStyles.component.scss"]
})
export class CurrencyFormComponent extends BaseComponent implements OnInit {

    _route:ActivatedRoute;

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: CurrencyService,
        private modals:NgbModal,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.Currencies,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            code: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(3)]],
            exchangeRate: [0,[ Validators.required, Validators.min(1)]],
            isLocalCurrency: [false],
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
                code:this.item.code,
                isLocalCurrency:this.item.isLocalCurrency,
                exchangeRate:this.item.exchangeRate
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
       const formValue = this.itemForm.value as Currency;
      
           if(!this.item)
           this.item = new Currency();

         
           this.item=  this.updateModel<Currency>(formValue,this.item);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/currency');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/currency');
    }
}