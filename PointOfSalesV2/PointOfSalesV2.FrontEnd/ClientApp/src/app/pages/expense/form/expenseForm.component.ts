

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
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


declare const $: any;
@Component({
    selector: "expense-form",
    templateUrl: "./expenseForm.component.html",
    styleUrls: ["../expenseStyles.component.scss"]
})
export class ExpenseFormComponent extends BaseComponent implements OnInit {

    isPaid:boolean=false;
    amountsNotEquals:boolean=false;
    branchOffices:BranchOffice[];
    paymentTypes:any[]; 
    _route:ActivatedRoute;
    currencies:Currency[]=[];//
    expenseTaxes:any[]=[];//
    suppliers:Supplier[]=[];//
    taxes:Tax[]=[];//
    expenseTaxService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}expenseTax`);
    paymentTypeService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}paymentType`);
    


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: ExpenseService,
        private modals:NgbModal,
        private currencyService:CurrencyService,
        private supplierService:SupplierService,
        private branchOfficeService:BranchOfficeService,
        private taxesService:TaxService,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.Expenses,modalService);
            this._route=router;
            this.dataToBackup="expenseTaxes";
        this.itemForm = this.formBuilder.group({
id: [0],
branchOfficeId:[0,[ Validators.required,Validators.min(1)]],
supplierId:[0,[ Validators.required,Validators.min(1)]],
currencyId:[0,[ Validators.required,Validators.min(1)]],
taxId:[0],
date:['',[Validators.required]],
trn:[''],
details:[''],
totalAmount:[0,[ Validators.required,Validators.min(0.0001)]],
beforeTaxesAmount:[0,[ Validators.required,Validators.min(0.0001)]],
totalAmountCalc:[0],
paymentTypeId:[0],
givenAmount:[0],
owedAmount:[0],
returnedAmount:[0]
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

     this.onChanges();
        this.verifyUser();
        this.getTaxes();
        this.getCurrencies();
        this.getSuppliers();
        this.getBranchOffices();
        this.getPaymentTypes();
       
    }

    async getExpenseTaxes(id:number){
        const filter = [{
            property: 'ExpenseId',
            value: id.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "Tax",
            value: "Id,Name,Rate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.expenseTaxService.getAllFiltered(filter).subscribe(r=>{
            this.expenseTaxes=r['value'];
            this.refreshTotalAmount();
        });
    }

   

   async getTaxes(){ 
       this.taxesService.getAll().subscribe(r=>{this.taxes=r});
   }

   
   async getCurrencies(){
    this.currencyService.getAll().subscribe(r=>{
        this.currencies=r;
        if(this.currencies.length==1)
        this.itemForm.patchValue({currencyId:this.currencies[0].id});
    });
}

async getBranchOffices(){
    this.branchOfficeService.getAll().subscribe(r=>{
        this.branchOffices=r;
        if(this.branchOffices.length==1)
        this.itemForm.patchValue({branchOfficeId:this.branchOffices[0].id});
    });
}

async getPaymentTypes(){
    this.paymentTypeService.getAll().subscribe(r=>{this.paymentTypes=r});
}

async getSuppliers(){
    this.supplierService.getAll().subscribe(r=>{this.suppliers=r});
}
   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue(this.item);
           this.getExpenseTaxes(this.item.id);
           
           
        }
        
        this.validateFormData();
    })
    }
    onChanges(): void {
        this.itemForm.get('beforeTaxesAmount').valueChanges.subscribe(val => {
         this.refreshTotalAmount();
        });
        this.itemForm.get('totalAmount').valueChanges.subscribe(val => {
            this.verifyTotalAmount();
           });
           
        this.itemForm.get('givenAmount').valueChanges.subscribe(val => {
          let {totalAmount} = this.itemForm.value;
          totalAmount=!totalAmount?0:totalAmount;
          const givenAmount=val?val:0;
          const toUpdate = {
              owedAmount:givenAmount>totalAmount?0:givenAmount-totalAmount,
              returnedAmount:givenAmount<totalAmount?0:givenAmount-totalAmount
          }
          this.itemForm.patchValue(toUpdate);
            });

        this.itemForm.get('paymentTypeId').valueChanges.subscribe(val => {
                this.isPaid=!val?false:(val>0);
                 });
      }
    get form() { return this.itemForm.controls; }

    verifyTotalAmount(){
        const calculatedAmount= this.itemForm.get('totalAmountCalc')?this.itemForm.get('totalAmountCalc').value:0;
        const total= this.itemForm.get('totalAmount')?this.itemForm.get('totalAmount').value:0;
        this.amountsNotEquals=(total!=calculatedAmount);
    }
    save(){
        if (this.itemForm.invalid || this.amountsNotEquals) {
            return;
        }
       const formValue = this.itemForm.value as Expense;
      
           if(!this.item)
           this.item = new Expense();
           this.item=  this.updateModel<Expense>(formValue,this.item);
           this.item.currencyId=parseInt(this.item.currencyId.toString());
           this.item.supplierId=parseInt(this.item.supplierId.toString());
           this.item.branchOfficeId=parseInt(this.item.branchOfficeId.toString());
           this.item.paymentTypeId=this.item.paymentTypeId?parseInt(this.item.paymentTypeId.toString()):0;
           this.item.paymentTypeId=this.item.paymentTypeId<=0?null:this.item.paymentTypeId;
           this.item.taxes=this.expenseTaxes;
          
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/expense');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/expense');
    }

    saveTax(){
        const tax =this.taxes.find(x=>x.id==this.form.taxId.value);
        const currentTax= {
            id:0,
            ExpenseId:parseInt(this.form.id.value.toString()),
            taxId:parseInt(this.form.taxId.value.toString()),
            tax:tax,
            taxAmount:(tax.rate * this.form.beforeTaxesAmount.value)
        };
        if(currentTax.taxId<=0)
        return;

      
        let index = this.expenseTaxes.findIndex(x=>x.taxId==currentTax.taxId);
        
        if(index<0)
        this.expenseTaxes.push(currentTax);
        else {
            this.expenseTaxes.splice(index,1);
            this.expenseTaxes.push(currentTax);
        }
        this.refreshTotalAmount();
      
    }
    deleteTax(tax:any){
        const index = this.expenseTaxes.findIndex(x=>x.taxId==tax.taxId);
        this.expenseTaxes.splice(index,1);
        this.refreshTotalAmount();
    }

    refreshTotalAmount(){
        let totalFromTaxes=0;
        this.expenseTaxes.forEach(t=>{
            totalFromTaxes+=t.taxAmount;
        });
        const beforeTaxesAmount =this.itemForm.get('beforeTaxesAmount')? this.itemForm.get('beforeTaxesAmount').value:0;
        this.itemForm.patchValue({totalAmountCalc:(beforeTaxesAmount+totalFromTaxes)});
        this.verifyTotalAmount();
    }
}