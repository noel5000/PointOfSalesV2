

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
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
import { CustomerService } from '../../../@core/services/CustomerService';
import { Customer } from '../../../@core/data/customer';


declare const $: any;
@Component({
    selector: "invoice-payment-form",
    templateUrl: "./invoicePaymentForm.component.html",
    styleUrls: ["../invoicePaymentStyles.component.scss"]
})
export class InvoicePaymentFormComponent extends BaseComponent implements OnInit {

    canPay:boolean=false;
    paymentTypes:any[]=[]; 
    invoices:any[]=[];
    _route:ActivatedRoute;
    currencies:Currency[]=[];
    customers:Customer[]=[];
    branchOffices:BranchOffice[]=[];
    paymentWithReference:boolean=false;
    paymentTypeService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}paymentType`);
    service:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}Invoice`);
    paymentService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}CustomerPayment`);
    


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private currencyService:CurrencyService,
        private customerService:CustomerService,
       modalService:ModalService,
        private brancOfficeService:BranchOfficeService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.CustomerPayments,modalService);
            this._route=router;
            this.dataToBackup="invoices,canPay,paymentWithReference";
        this.itemForm = this.formBuilder.group({
id: [0],
branchOfficeId:[null,[ Validators.required,Validators.min(1)]],
paymentDestinationId:[null,[ Validators.required,Validators.min(1)]],
currencyId:[null,[ Validators.required,Validators.min(1)]],
details:[''],
reference:[''],
destinationType:[0],
paymentTypeId:[null,[Validators.required, Validators.min(1)]],
givenAmount:[null],
returnedAmount:[0],
positiveBalance:[0],
paidAmount:[0]
});
    }
    ngOnInit(): void {
     
     this.onChanges();
        this.verifyUser();
        this.getBranchOffices();
        this.getCurrencies();
        this.getCustomers();
        this.getPaymentTypes();
        this.validateFormData();
    }

    async getinvoices(){
        const filter ={
            branchOfficeId:this.itemForm.get('branchOfficeId').value?this.itemForm.get('branchOfficeId').value:0,
            currencyId:this.itemForm.get('currencyId').value?this.itemForm.get('currencyId').value:0,
            customerId:this.itemForm.get('paymentDestinationId').value?this.itemForm.get('paymentDestinationId').value:0
        }
        this.invoices.forEach(e=>{
            this.itemForm.removeControl(`selectedInvoice-${e.id}`);
        });
        this.service.getByUrlParameters(['GetInvoicesToPay',filter.branchOfficeId,filter.customerId,filter.currencyId]).subscribe(r=>{

            r.data.forEach(e=>{
                this.itemForm.addControl(`selectedInvoice-${e.id}`,new FormControl(0));
                this.itemForm.controls[`selectedInvoice-${e.id}`].valueChanges.subscribe(val=>{
                    this.payInvoice(val,e.id);
                })
            });
            this.invoices=r.data;
        });
    }

   
   async getCurrencies(){
    this.currencyService.getAll().subscribe(r=>{
        this.currencies=r;
        if(this.currencies.length==1)
        this.itemForm.patchValue({currencyId:this.currencies[0].id});
    });
}

async getBranchOffices(){
    this.brancOfficeService.getAll().subscribe(r=>{
        this.branchOffices=r;
        if(this.branchOffices.length==1)
        this.itemForm.patchValue({branchOfficeId:this.branchOffices[0].id});
    });
}



async getPaymentTypes(){
    this.paymentTypeService.getAll().subscribe(r=>{this.paymentTypes=r});
}

async getCustomers(){
    this.customerService.getAll().subscribe(r=>{
        this.customers=r;
        if(this.customers.length==1)
        this.itemForm.patchValue({paymentDestinationId:this.customers[0].id});
    });
}
    onChanges(): void {
           
       

         this.itemForm.get('paymentTypeId').valueChanges.subscribe(val => {
            this.itemForm.removeControl('reference');
           if(val && val>0){
               const paymentType= this.paymentTypes.find(x=>x.id==val);
               this.paymentWithReference= paymentType && paymentType.code!=1;

               if(this.paymentWithReference){
                   this.itemForm.addControl(`reference`,new FormControl(null,[Validators.required]))
               }
               else
               this.itemForm.addControl(`reference`,new FormControl(''))

           }
           });

        this.itemForm.get('currencyId').valueChanges.subscribe(val => {
            const {currencyId} = this.itemForm.getRawValue();
            if(currencyId && currencyId>0)
                this.getinvoices();
         });

         this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
            const {branchOfficeId} = this.itemForm.getRawValue();
            if(branchOfficeId && branchOfficeId>0)
                this.getinvoices();
         });
        this.itemForm.get('paymentDestinationId').valueChanges.subscribe(val => {
            if(val && val>0)
                this.getinvoices();
         });
         this.itemForm.get('givenAmount').valueChanges.subscribe(val => {
            this.canPay = val && val>0;
            if((!val ||val<=0) ){
                this.invoices.forEach(e=>{
                    let toUpdate ={};
                    toUpdate[`selectedInvoice-${e.id}`]=false;
                    this.itemForm.patchValue(toUpdate);
                })
            }
            else{
                const paidAmount= this.itemForm.get('paidAmount')?this.itemForm.get('paidAmount').value:0;
                this.itemForm.patchValue({
                    positiveBalance:paidAmount?val-paidAmount:val
                })
            }
         });

         }
    get form() { return this.itemForm.controls; }

    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.getRawValue();
      
     
          const toPost ={
              payment:{
                branchOfficeId: formValue.branchOfficeId,
                currencyId:   formValue.currencyId,
                paymentTypeId:    formValue.paymentTypeId,
                customerId:formValue.paymentDestinationId,
                reference:formValue.reference,
                details:formValue.details,
                positiveBalance:formValue.positiveBalance,
                givenAmount:formValue.givenAmount,
            },
              invoices:this.invoices.filter(x=>x.currentPaidAmount>0),
              userId:this.authModel.user.userId
          };
            const subscription =this.paymentService.post(toPost,null,'PayInvoices');
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.clearBackupData();
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl('pages/invoicepayment');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/invoicepayment');
    }

    payInvoice(checked:boolean,id:number){
        const index = this.invoices.findIndex(x=>x.id==id);
        if(checked){
        const givenAmount = this.itemForm.get('givenAmount').value;
        const paidAmount=this.itemForm.get('paidAmount').value;
        if((givenAmount-paidAmount)>0)
            this.invoices[index].currentPaidAmount=(givenAmount-paidAmount)>this.invoices[index].owedAmount?this.invoices[index].owedAmount:(givenAmount-paidAmount);
            else{
                let toUpdate ={};
                toUpdate[`selectedInvoice-${id}`]=false;
                this.itemForm.patchValue(toUpdate);
            }            
          
        }
        this.refreshTotalAmount(index,checked);
      
    }

    refreshTotalAmount(index:number,hasValue:boolean){
        this.invoices[index].currentPaidAmount=hasValue? this.invoices[index].currentPaidAmount:0;
        const paidSumm = this.invoices.reduce(function(a,b){return a+b.currentPaidAmount},0);
        const givenAmount = this.itemForm.get('givenAmount')?this.itemForm.get('givenAmount').value?this.itemForm.get('givenAmount').value:0:0;
        this.itemForm.patchValue({
            paidAmount:paidSumm,
            positiveBalance:givenAmount-paidSumm
        });
     
    }
}