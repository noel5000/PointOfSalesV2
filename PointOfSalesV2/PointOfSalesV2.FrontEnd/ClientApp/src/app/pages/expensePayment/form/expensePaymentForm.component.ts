

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ExpenseService } from '../../../@core/services/ExpenseService';
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
import { Expense } from '../../../@core/data/expenseModel';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { ExpensePayment } from '../../../@core/data/expensePayment';
import { ExpensePaymentService, ISupplierPayment } from '../../../@core/services/expensePaymentService';


declare const $: any;
@Component({
    selector: "expense-payment-form",
    templateUrl: "./expensePaymentForm.component.html",
    styleUrls: ["../expensePaymentStyles.component.scss"]
})
export class ExpensePaymentFormComponent extends BaseComponent implements OnInit {

    canPay:boolean=false;
    paymentTypes:any[]=[]; 
    expenses:Expense[]=[];
    _route:ActivatedRoute;
    currencies:Currency[]=[];
    paymentWithReference:boolean=false;
    suppliers:Supplier[]=[];
    paymentTypeService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}paymentType`);
    


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private expenseService: ExpenseService,
        private service:ExpensePaymentService,
        private modals:NgbModal,
        private currencyService:CurrencyService,
        private supplierService:SupplierService,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.ExpensesPayments,modalService);
            this._route=router;
            this.dataToBackup="expenses";
        this.itemForm = this.formBuilder.group({
id: [0],
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
        this.getCurrencies();
        this.getSuppliers();
        this.getPaymentTypes();
        this.validateFormData();
    }

    async getExpenses(){
        const filter ={
            branchOfficeId:this.itemForm.get('branchOfficeId')?this.itemForm.get('branchOfficeId').value:null,
            currencyId:this.itemForm.get('currencyId')?this.itemForm.get('currencyId').value:null,
            supplierId:this.itemForm.get('paymentDestinationId')?this.itemForm.get('paymentDestinationId').value:null
        }
        if(this.expenses && this.expenses.length>0)
        this.expenses.forEach(e=>{
            this.itemForm.removeControl(`selectedExpense-${e.id}`);
        });
        this.expenseService.getExpensesToPay(filter).subscribe(r=>{

            r['data'].forEach(e=>{
                this.itemForm.addControl(`selectedExpense-${e.id}`,new FormControl(0));
                this.itemForm.controls[`selectedExpense-${e.id}`].valueChanges.subscribe(val=>{
                    this.payExpense(val,e.id);
                })
            });
            this.expenses=r['data'];
        });
    }

   
    async getCurrencies(){
        this.currencyService.getAll().subscribe(r=>{
            this.currencies=r;
            if(this.currencies.length==1)
            this.itemForm.patchValue({currencyId:this.currencies[0].id});
        });
    }



async getPaymentTypes(){
    this.paymentTypeService.getAll().subscribe(r=>{this.paymentTypes=r});
}

async getSuppliers(){
    this.supplierService.getAll().subscribe(r=>{this.suppliers=r});
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
            const {paymentDestinationId} = this.itemForm.getRawValue();
            if(paymentDestinationId && paymentDestinationId>0)
                this.getExpenses();
         });
        this.itemForm.get('paymentDestinationId').valueChanges.subscribe(val => {
                this.getExpenses();
         });
         this.itemForm.get('givenAmount').valueChanges.subscribe(val => {
            this.canPay = val && val>0;
            if((!val ||val<=0) ){
                this.expenses.forEach(e=>{
                    let toUpdate ={};
                    toUpdate[`selectedExpense-${e.id}`]=false;
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
              payment:formValue,
              expenses:this.expenses.filter(x=>x.currentPaidAmount>0)
          } as ISupplierPayment;
            const subscription =this.service.PayExpenses(toPost);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/expensepayment');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/expensepayment');
    }

    payExpense(checked:boolean,id:number){
        const index = this.expenses.findIndex(x=>x.id==id);
        if(checked){
        const givenAmount = this.itemForm.get('givenAmount').value;
        const paidAmount=this.itemForm.get('paidAmount').value;
        if((givenAmount-paidAmount)>0)
            this.expenses[index].currentPaidAmount=(givenAmount-paidAmount)>this.expenses[index].owedAmount?this.expenses[index].owedAmount:(givenAmount-paidAmount);
            else{
                let toUpdate ={};
                toUpdate[`selectedExpense-${id}`]=false;
                this.itemForm.patchValue(toUpdate);
            }            
          
        }
        this.refreshTotalAmount(index,checked);
      
    }

    refreshTotalAmount(index:number,hasValue:boolean){
        this.expenses[index].currentPaidAmount=hasValue? this.expenses[index].currentPaidAmount:0;
        const paidSumm = this.expenses.reduce(function(a,b){return a+b.currentPaidAmount},0);
        const givenAmount = this.itemForm.get('givenAmount')?this.itemForm.get('givenAmount').value?this.itemForm.get('givenAmount').value:0:0;
        this.itemForm.patchValue({
            paidAmount:paidSumm,
            positiveBalance:givenAmount-paidSumm
        });
     
    }
}