

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { CustomerService } from '../../../@core/services/CustomerService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Customer } from '../../../@core/data/customer';
import { BaseService } from '../../../@core/services/baseService';
import { TRNControl } from '../../../@core/data/trnControlModel';
import { TRNControlService } from '../../../@core/services/TRNControlService';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { Currency } from '../../../@core/data/currencyModel';
import { ZoneService } from '../../../@core/services/zoneService';
import { Zone } from '../../../@core/data/zoneModel';


declare const $: any;
@Component({
    selector: "customer-form",
    templateUrl: "./customerForm.component.html",
    styleUrls: ["../customerStyles.component.scss"]
})
export class CustomerFormComponent extends BaseComponent implements OnInit {

    zones:Zone[]=[];
    _route:ActivatedRoute;
    trnControls:TRNControl[]=[];
    currencies:Currency[]=[];

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: CustomerService,
        private modals:NgbModal,
        private zoneService:ZoneService,
        private trnService:TRNControlService,
        private currencyService:CurrencyService,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.Customers,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            phoneNumber: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            cardId: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            address: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(200)]],
            code: [''],
            zoneId:[null],
            currencyId: [0,[ Validators.required]],
            trnControlId: [0,[ Validators.required]],
            invoiceDueDays: [0],
            billingAmountLimit: [0],
            creditAmountLimit: [0],
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
        this.getZones();
        this.getTrnControls();
        this.getCurrencies();
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name: this.item.name,
                phoneNumber: this.item.phoneNumber,
                cardId: this.item.cardId,
                address: this.item.address,
                code: this.item.code,
                currencyId: this.item.currencyId,
                trnControlId: this.item.trnControlId,
                invoiceDueDays: this.item.invoiceDueDays,
                billingAmountLimit: this.item.billingAmountLimit,
                creditAmountLimit:this.item.creditAmountLimit,
            });

        }
        this.validateFormData();
    })
    }
    getTrnControls(){
        this.trnService.getAll().subscribe(r=>{this.trnControls=r});
    }

    getCurrencies(){
        this.currencyService.getAll().subscribe(r=>{
            this.currencies=r;
            if(this.currencies.length==1)
            this.itemForm.patchValue({currencyId:this.currencies[0].id});
        });
    }

    getZones(){
        this.zoneService.getAll().subscribe(r=>{
            this.zones=r;
            if(this.zones.length==1)
            this.itemForm.patchValue({zoneId:this.zones[0].id});
        });
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as Customer;
      
           if(!this.item)
           this.item = new Customer();
           this.item=  this.updateModel<Customer>(formValue,this.item);
           this.item.trnType= this.trnControls.find(x=>x.id==this.item.trnControlId).type;
           this.item.currencyId=parseInt(this.item.currencyId.toString());
           this.item.trnControlId=parseInt(this.item.trnControlId.toString());
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/customer');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/customer');
    }
}