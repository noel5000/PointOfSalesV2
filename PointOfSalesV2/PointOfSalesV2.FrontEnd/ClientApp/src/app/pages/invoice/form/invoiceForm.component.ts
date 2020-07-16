

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, Validator, FormControl } from '@angular/forms';
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
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { Customer } from '../../../@core/data/customer';
import { School } from '../../../@core/data/school';
import { CustomerService } from '../../../@core/services/CustomerService';
import { SchoolService } from '../../../@core/services/SchoolService';


declare const $: any;
@Component({
    selector: "invoice-form",
    templateUrl: "./invoiceForm.component.html",
    styleUrls: ["../invoiceStyles.component.scss"]
})
export class InvoiceFormComponent extends BaseComponent implements OnInit {
    itemForm: FormGroup;
    item: any={};
    id:number=0;
    branchOffices:BranchOffice[];
    service:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}Invoice`);
    _route:ActivatedRoute;
    customers:Customer[]=[];
    months:any[]=[
        {
            id:0,
            name:this.lang.getValueByKey('pleaseSelect_lbl')
        }, 
        {
            id:1,
            name:this.lang.getValueByKey('jan_lbl')
        },
        {
            id:2,
            name:this.lang.getValueByKey('feb_lbl')
        },
        {
            id:3,
            name:this.lang.getValueByKey('march_lbl')
        },
        {
            id:4,
            name:this.lang.getValueByKey('april_lbl')
        },
        {
            id:5,
            name:this.lang.getValueByKey('may_lbl')
        },
        {
            id:6,
            name:this.lang.getValueByKey('jun_lbl')
        },
        {
            id:7,
            name:this.lang.getValueByKey('jul_lbl')
        },
        {
            id:8,
            name:this.lang.getValueByKey('aug_lbl')
        },
        {
            id:9,
            name:this.lang.getValueByKey('sep_lbl')
        },
        {
            id:10,
            name:this.lang.getValueByKey('oct_lbl')
        },
        {
            id:11,
            name:this.lang.getValueByKey('nov_lbl')
        },
        {
            id:12,
            name:this.lang.getValueByKey('dec_lbl')
        },
    ];
    currencies:Currency[]=[];
    invoiceLeads:any[]=[];
    defaultCheckValidator:FormControl=new FormControl(true);


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private currencyService:CurrencyService,
        private customerService:CustomerService,
        private branchOfficeService:BranchOfficeService,
        private schoolService:SchoolService,
        private modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.Invoices);
            this._route=router;
        this.itemForm = this.formBuilder.group({
id: [0],
branchOfficeId:[0,[ Validators.required,Validators.min(1)]],
customerId:[0,[ Validators.required,Validators.min(1)]],
currencyId:[0,[ Validators.required,Validators.min(1)]],
month:[0,[ Validators.required,Validators.min(1)]],
details:[''],
totalAmount:[0],
beforeTaxesAmount:[0],
taxAmount:[0],
        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        this.id=urlId;
        if(this.id>0)
        this.getItem(urlId);
     }
     this.onChanges();
        this.verifyUser();
        this.getCurrencies();
        this.getCustomers();
        this.getBranchOffices();
       
    }


 async getLeads(){
     const form = this.itemForm.getRawValue();
     this.service.getByUrlParameters(['GetBillingLeads',form.branchOfficeId,form.customerId,form.currencyId,form.month])
     .subscribe(r=>{
        this.invoiceLeads.forEach((d,i)=>{
            if(this.itemForm.contains(`leadChecked_${i}`))
            this.itemForm.removeControl(`leadChecked_${i}`);
        });

         r.data.forEach((d,i)=>{
                if(!this.itemForm.contains(`leadChecked_${i}`))
            this.itemForm.addControl(`leadChecked_${i}`,this.defaultCheckValidator);
         });
         this.invoiceLeads=r.data;
     });
 }
   
   async getCurrencies(){
    this.currencyService.getAll().subscribe(r=>{
        this.currencies=r;
        if(this.currencies.length==1)
        this.itemForm.patchValue({currencyId:this.currencies[0].id});
    });
}

async getCustomers(){
    this.customerService.getAll().subscribe(r=>{
        this.customers=r;
        if(this.customers.length==1)
        this.itemForm.patchValue({customerId:this.customers[0].id});
    });
}

async getBranchOffices(){
    this.branchOfficeService.getAll().subscribe(r=>{
        this.branchOffices=r;
        if(this.branchOffices.length==1)
        this.itemForm.patchValue({branchOfficeId:this.branchOffices[0].id});
    });
}

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue(this.item);
        }
    })
    }
    onChanges(): void {
        this.itemForm.get('beforeTaxesAmount').valueChanges.subscribe(val => {
         this.refreshTotalAmount();
        });
        this.itemForm.get('totalAmount').valueChanges.subscribe(val => {
            this.verifyTotalAmount();
           });

        this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
            this.getLeads();
           });
        
        this.itemForm.get('customerId').valueChanges.subscribe(val => {
            this.getLeads();
           });

        this.itemForm.get('currencyId').valueChanges.subscribe(val => {
            this.getLeads();
           });
           
        this.itemForm.get('month').valueChanges.subscribe(val => {
            this.getLeads();
           });
     

  
      }

      async getSchools(customerId:number){
        const filter = [{
            property: 'CustomerId',
            value: customerId.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
    ]
        this.schoolService.getAllFiltered(filter).subscribe(r=>{
         
        });
    }
    get form() { return this.itemForm.controls; }

    verifyTotalAmount(){
        const calculatedAmount= this.itemForm.get('totalAmountCalc')?this.itemForm.get('totalAmountCalc').value:0;
        const total= this.itemForm.get('totalAmount')?this.itemForm.get('totalAmount').value:0;
      
    }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value;
      
           if(!this.item)
           this.item ={};
           this.item=  this.updateModel<any>(formValue,this.item);
           this.item.currencyId=parseInt(this.item.currencyId.toString());
           this.item.branchOfficeId=parseInt(this.item.branchOfficeId.toString());
           this.item.customerId=parseInt(this.item.customerId.toString());
           this.invoiceLeads.forEach((l,i)=>{
                l[`leadChecked`]= formValue[`leadChecked_${i}`];
           });
           this.item.invoiceLeads=this.invoiceLeads.filter(l=>l.leadChecked);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl('pages/invoice');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
    this.router.navigateByUrl('pages/invoice');
    }


    refreshTotalAmount(){
        let totalFromTaxes=0;
    
        const beforeTaxesAmount =this.itemForm.get('beforeTaxesAmount')? this.itemForm.get('beforeTaxesAmount').value:0;
        this.itemForm.patchValue({totalAmountCalc:(beforeTaxesAmount+totalFromTaxes)});
        this.verifyTotalAmount();
    }
}