

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, Validator, FormControl, AbstractControl } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes, ODataComparers, BillingStates } from '../../../@core/common/enums';
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
import { Product } from '../../../@core/data/product';
import { ProductService } from '../../../@core/services/ProductService';
import { TRNControl } from '../../../@core/data/trnControlModel';
import { Seller } from '../../../@core/data/seller';
import { Warehouse } from '../../../@core/data/Warehouse';
import { TRNControlService } from '../../../@core/services/TRNControlService';
import { SellerService } from '../../../@core/services/SellerService';
import { WarehouseService } from '../../../@core/services/WarehouseService';


declare const $: any;
@Component({
    selector: "customerreturn-form",
    templateUrl: "./customerReturnForm.component.html",
    styleUrls: ["../customerReturnStyles.component.scss"]
})
export class CustomerReturnFormComponent extends BaseComponent implements OnInit {

    invoice: any={};

    details:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);

  
    invoiceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Invoice`);
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}CustomerReturn`);
   
    isEditing:boolean=false;


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private productService:ProductService,
       modalService:ModalService,
      private  http: HttpClient,
      private customerService:CustomerService,
      private trnControlService:TRNControlService,
      private sellerService:SellerService,
      private warehouseService:WarehouseService
        ){
           
            super(route, langService, AppSections.CustomersReturns,modalService);
            this.verifyUser();
            this.dataToBackup="invoice,details";
            this.isEditing=this.id && this.id>0;
           
        this.itemForm = this.formBuilder.group({
            invoiceNumber: [null,[Validators.required]],
            customerName:[''],
            selectedAmount:[0],
            totalAmount:[0,[Validators.required,Validators.min(1)]],
            currencyName:[''],
            billingDate:['']
        });
    }

    searchInvoice(){
        const {invoiceNumber}= this.itemForm.getRawValue();
        this.invoiceService.getByUrlParameters(["GetByInvoiceNumber",invoiceNumber.toString()]).subscribe(r=>{
            if(r && r.status>=0 && r.data.length>0){
                this.invoice=r.data[0];
                for(let i=0; i<this.details.length;i++){
                    if(this.itemForm.contains(`returnQuantity_${i}`))
                    this.itemForm.removeControl(`returnQuantity_${i}`);

                    if(this.itemForm.contains(`defectiveDetail_${i}`))
                    this.itemForm.removeControl(`defectiveDetail_${i}`);

                }
                if( this.invoice &&  this.invoice.invoiceDetails &&  this.invoice.invoiceDetails.length>0){
                    for(let i=0; i< this.invoice.invoiceDetails.length;i++){
                        this.setDetailFormDefective(i, null);
                        this.setDetailFormAmount(i, null,this.invoice.invoiceDetails[i].quantity);
                      }
                }
                this.details= this.invoice &&  this.invoice.
                invoiceDetails? this.invoice.invoiceDetails:[];
               
                this.itemForm.patchValue({
                    customerName:`${this.invoice.customer.name} - ${this.invoice.customer.code}`,
                    currencyName:this.invoice.currency.code,
                    billingDate:this.invoice.billingDate.split('T')[0],
                    totalAmount:this.invoice.totalAmount
                });

               
            }
            else{
                this.invoice=null;
                this.modalService.showError(r.message);
            }
        },e=>{
            this.modalService.showError('error_msg');
        });
    }
    ngOnInit(): void {
   
     this.onChanges();
        this.verifyUser();
        this.validateFormData();
    }



  

  
    onChanges(): void {
      


      }

    resetForm(deletedetails:boolean=false){
        
        this.itemForm.patchValue({
         
        });
  
    }
    get form() { return this.itemForm.controls; }

    get formValues(){
        let form = this.itemForm.getRawValue();
       
      let result=0;
      for(let i=0;i<this.details.length;i++){
          const selectedQuantity = this.itemForm.getRawValue()[`returnQuantity_${i}`] as number;
          if(selectedQuantity && selectedQuantity>0){
              const {totalAmount,quantity} = this.details[i];
              result+=selectedQuantity* (totalAmount/quantity);
          }
      }
      form.totalAmount=result;
      
        return form;
    }

    verifyTotalAmount(){
        const calculatedAmount= this.itemForm.get('totalAmountCalc')?this.itemForm.get('totalAmountCalc').value:0;
        const total= this.itemForm.get('totalAmount')?this.itemForm.get('totalAmount').value:0;
      
    }

    
    save(){
        if (!this.details || this.details.length==0 || this.itemForm.invalid && !this.invoice)
            return;
            this.updatedetailsValues();
        let form = this.itemForm.getRawValue() as any;
          let toSave ={
              invoiceNumber:this.invoice.invoiceNumber,
              customerId:this.invoice.customerId,
              branchOfficeId:this.invoice.branchOfficeId,
              invoiceId:this.invoice.id,
              beforeTaxesAmount:this.formValues.totalAmount,
              taxesAmount:0,
              totalAmount:this.formValues.totalAmount,
              currencyId:this.invoice.currencyId,
              returnDetails:this.setReturnDetails()
          };

            const subscription =this.service.post(toSave,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/customerreturn');
               }
               else
               this.modalService.showError(r.message);
           })
    }
    setReturnDetails():any[]{
        let details=[];
        for(let i=0;i<this.details.length;i++){
            const selectedQuantity= this.itemForm.getRawValue()[`returnQuantity_${i}`] as number;
            if(selectedQuantity && selectedQuantity>0){
                let selectedDetail=this.details[i];
                selectedDetail.quantity=selectedQuantity;
                selectedDetail.invoiceNumber=this.invoice.invoiceNumber;
                selectedDetail.taxesAmount=0;
                selectedDetail.id=0;
                selectedDetail.beforeTaxesAmount=selectedQuantity* this.details[i].totalAmount/this.details[i].quantity;
                selectedDetail.totalAmount=selectedDetail.beforeTaxesAmount;
                selectedDetail.customerId=this.invoice.customerId;
                selectedDetail.defective = this.itemForm.getRawValue()[`defectiveDetail_${i}`] as boolean;
                selectedDetail.defective = selectedDetail.defective==null?false:selectedDetail.defective;
                details.push(selectedDetail);
            }
        }
        return details;
    }

    updatedetailsValues(){
        const form = this.itemForm.getRawValue();
        for(let i=0;i<this.details.length;i++){
            this.details[i].returnQuantity = form[`returnQuantity_${i}`].value;
            this.details[i].discountAmount= this.details[i].discountRate/100*this.details[i].beforeTaxesAmount;
        }
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/customerreturn');
    }


    setDetailFormAmount(index:number,quantity:number, maxNumber:number){
        if(!this.itemForm.contains(`returnQuantity_${index}`))
        this.itemForm.addControl(`returnQuantity_${index}`,new FormControl(quantity,[ Validators.required,Validators.min(0.0001),Validators.max(maxNumber)]));
    }

     setDetailFormDefective(index:number,selected:boolean, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`defectiveDetail_${index}`))
        this.itemForm.addControl(`defectiveDetail_${index}`,new FormControl(selected));
    }
    refreshAmounts(fromForm:boolean=false){
    
   
      
    }
}