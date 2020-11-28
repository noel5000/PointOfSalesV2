

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, Validator, FormControl } from '@angular/forms';
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
    selector: "invoice-form",
    templateUrl: "./invoiceForm.component.html",
    styleUrls: ["../invoiceStyles.component.scss"]
})
export class InvoiceFormComponent extends BaseComponent implements OnInit {

    branchOfficeId:number=0;
    warehouseId:number=0;
    currentDate:string='';
    productQuantity:number=0;
    showProductQuantity:boolean=false;
    _route:ActivatedRoute;
    localCurrency:Currency=null;
    products:Product[]=[];//
    customers:Customer[]=[];
    trnControls:TRNControl[]=[];
    sellers:Seller[]=[];
    productPrices:any[]=[];
    warehouses:Warehouse[]=[];
    productUnits:any[]=[];//
    productTaxes:any[]=[];//
    inventories=[];
    entries:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);
    currentProductCost:any={cost:0};
    currentProductPrice:any={sellingPrice:0,costPrice:0, equivalence:0};
    inventoryService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Inventory`);
    creditNoteService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}CreditNote`);
    invoiceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Invoice`);
    menuService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Menu`);
    currencyService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Currency`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productTaxService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductTax`);
    oldProductCost:number=0;
    oldProductPrice:number=0;
    selectedProductCurrency:Currency=null;
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
           
            super(route, langService, AppSections.Invoices,modalService);
            this.verifyUser();
            this.dataToBackup="entries,sellers,productUnits,productTaxes,inventories,warehouses,productPrices,currentProductCost,currentProductPrice,oldProductCost,oldProductPrice,selectedProductCurrency,isEditing";
            this._route=router;
            this.id=parseInt( this._route.snapshot.paramMap.get('id'))>0?parseInt( this._route.snapshot.paramMap.get('id')):0;
            this.isEditing=this.id && this.id>0;
            this.currentDate = new Date().toDateString();
            if( this.id && this.id>0){
                this.getCurrentInvoice(this.id);
                
            }
            else
            this.validateFormData();
            
           this.branchOfficeId=this.authModel.user.branchOfficeId;
           this.warehouseId=this.authModel.user.warehouseId;
            
        this.itemForm = this.formBuilder.group({
id: [0],
customerId:[{value:null, disabled:this.isEditing},[ Validators.required,Validators.min(1)]],
trnType:[{value:null, disabled:this.isEditing},[ Validators.required]],
nrc:[null,[ Validators.required]],
productId:[null,[ Validators.required,Validators.min(1)]],
unitId:this.defaultUnitValidator,
branchOfficeId:[this.branchOfficeId],
warehouseId:[{value:null, disabled:this.isEditing}],
sellerId:[{value:null, disabled:this.isEditing}],
billingDate:[this.currentDate],
inventoryModified:[true],
discountRate:[{value:0, disabled:this.isEditing},[Validators.min(0),Validators.max(100)]],
discountAmount:[0],
currencyName:[''],
cashRegisterId:[0],
invoiceNumber:[''],
documentNumber:[''],
currencyId:[0],
active:[true],
exchangeRate:[0],
sellerRate:[0],
paidDate:[null],
receivedAmount:[0],
appliedCreditNote:[''],
cost:[0],
Month:[0],
appliedCreditNoteAmount:[{value:0, disabled:true}],
trn:[null],
trnControlId:[0],
details:[null],
state:[''],
quantity:[0,[ Validators.required,Validators.min(0.0001)]],
productCost:[0],
productPrice:[0],
selectedPrice:[0],
beforeTaxesAmount:[0],
paidAmount:[0],
returnedAmount:[0],
owedAmount:[0],
noTaxes:[false],
taxesAmount:[0],
totalAmount:[0],
free:[false]
        });
    }
    ngOnInit(): void {
   
     this.onChanges();
        this.verifyUser();
        this.getProducts();
        this.getCustomers();
        this.getTrnControls();
        this.getWarehouses();
       this.getLocalCurrency();
    }

    async getCustomers(){
        const filter = [
        {
            property: "Currency",
            value: "Id,Name,Code,ExchangeRate,IsLocalCurrency",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.customerService.getAllFiltered(filter).subscribe(r=>{
            this.customers=[{id:0, name:''} as Customer];
            this.customers=this.customers.concat( r['value']);
            const {customerId} = this.itemForm.getRawValue();
            if(customerId && customerId>0)
            this.getSellers(customerId);
        });
    }
    setAdditionalBackupData(){
        for(let i=0; i<this.entries.length;i++){
            this.setDetailFormAmount(i,this.entries[i].quantity);
            this.setDetailFormDiscount(i,this.entries[i].discountRate);
          }
    }

    async getTrnControls(){
      
        this.trnControlService.getAll().subscribe(r=>{
            this.trnControls=[{id:0, name:''} as TRNControl];
            this.trnControls=this.trnControls.concat( r);
        });
    }

    async getWarehouses(){
        let filter = [
        {
            property: 'Code',
            value: 'DEF',
            type: ObjectTypes.String,
            isTranslated:false,
            comparer: ODataComparers.NotEqual
        } as QueryFilter
    ];

    const user = this.authModel.user;
    if(user.branchOfficeId)
    filter.push({
        property: 'BranchOfficeId',
        value: user.branchOfficeId.toString(),
        type: ObjectTypes.Number,
        isTranslated:false
    } as QueryFilter);


        this.warehouseService.getAllFiltered(filter).subscribe(r=>{
            this.warehouses=[{id:0, name:''} as Warehouse];
            this.warehouses= this.warehouses.concat(r['value']);
        });
    }

    async getSellers(customerId:number){
        const customer = this.customers.find(x=>x.id==customerId);
        this.itemForm.patchValue({
            currencyId:customer.currencyId,
            currencyName:customer.currency.name,
            trnType:customer.trnType,
            nrc:customer.cardId,
            warehouseId:customer.warehouseId?customer.warehouseId:this.warehouseId
        })
        const filter = [{
            property: 'ZoneId',
            value:customer.zoneId? customer.zoneId.toString():0,
            type: ObjectTypes.Number,
            comparer:customer.zoneId?null:ODataComparers.NotEqual,
            isTranslated:false
        } as QueryFilter
    ]
        this.sellerService.getAllFiltered(filter).subscribe(r=>{
            this.sellers=[{id:0, name:''} as Seller];
            this.sellers= this.sellers.concat(r['value']);
        });
    }

    async GetProductUnits(id:number){
        const filter = [{
            property: 'ProductId',
            value: id.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "Unit",
            value: "Id,Name",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.productUnitService.getAllFiltered(filter).subscribe(r=>{
            this.productUnits=[{id:0, unitId:0,unit:{id:0, name:''},sellingPrice:0, costPrice:0, equivalence:0}];
            this.productUnits=this.productUnits.concat( r['value']);
        });
    }

    async GetProductTaxes(id:number){
        const filter = [{
            property: 'ProductId',
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
        this.productTaxService.getAllFiltered(filter).subscribe(r=>{
            this.productTaxes=r['value'];
        });
    }

  
    async GetDetailProductTaxes(index:number){
        let entry = this.entries[index];
        const filter = [{
            property: 'ProductId',
            value: entry.productId.toString(),
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
        this.productTaxService.getAllFiltered(filter).subscribe(r=>{
           const taxes=r['value'];
           entry.quantity = this.itemForm.getRawValue()[`unitQuantity_${index}`];
           entry.discountRate = this.itemForm.getRawValue()[`unitDiscountRate_${index}`];
           entry.beforeTaxesAmount= entry.quantity * entry.amount;
           entry.discountAmount = entry.beforeTaxesAmount /100 * entry.discountRate;
           entry.taxesAmount= taxes.length<=0?0:taxes.reduce(function(a,b){return a+(b.tax.rate*(entry.beforeTaxesAmount -entry.discountAmount))},0);
           entry.totalAmount = entry.beforeTaxesAmount + entry.taxesAmount- entry.discountAmount;
           this.entries[index]=entry;
        });
    }

    async getLocalCurrency(){
        const filter = [{
            property: 'IsLocalCurrency',
            value: 'true',
            type: ObjectTypes.Boolean,
            isTranslated:false
        } as QueryFilter
    ]
        this.currencyService.getAllFiltered(filter).subscribe(r=>{
          this.localCurrency=r['value'][0]
        });
    }

    async GetDetailDiscount(index:number){
        let entry = this.entries[index];
        entry.quantity = this.itemForm.getRawValue()[`unitQuantity_${index}`];
           entry.discountRate = this.itemForm.getRawValue()[`unitDiscountRate_${index}`];
           entry.discountAmount = entry.beforeTaxesAmount /100 * entry.discountRate;
           entry.beforeTaxesAmount= entry.quantity * entry.amount;
           entry.totalAmount = entry.beforeTaxesAmount + entry.taxesAmount - entry.discountAmount;
           this.entries[index]=entry;
    }

    CalculateProductTax():number{
        const {productPrice,discountRate}= this.itemForm.getRawValue();
        return this.productTaxes.length<=0?0:this.productTaxes.reduce(function(a,b){return a+(b.tax.rate*productPrice-(b.tax.rate*productPrice*discountRate/100))},0);
    }



    

    async GetProductCost(productId:number){
        const currentProduct = this.products.find(x=>x.id==productId);
        this.currentProductCost.cost=currentProduct.cost;
        const {unitId,productPrice} = this.itemForm.getRawValue();
        this.currentProductPrice.sellingPrice= unitId && unitId>0 && this.productUnits.length>0?currentProduct.price/this.productUnits.find(x=>x.unitId==unitId).equivalence: currentProduct.price;
        this.refreshAmounts();
    }

  

    async getProducts(){
        const filter = [
        {
            property: "Currency",
            value: "Id,Name,Code,ExchangeRate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.productService.getAllFiltered(filter).subscribe(r=>{
            this.products=[{id:0, name:''} as Product];
            this.products=this.products.concat( r['value']);
        });
    }

    async getCreditNote(){
        const formVal= this.itemForm.getRawValue();
        const filter = [
        {
            property: "Sequence",
            value: formVal.appliedCreditNote,
            type: ObjectTypes.String,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter,
        {
            property: "CustomerId",
            value: formVal.customerId,
            type: ObjectTypes.Number,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter,
        {
            property: "Applied",
            value: "false",
            type: ObjectTypes.Boolean,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter,
        
        {
            property: "CurrencyId",
            value: formVal.currencyId,
            type: ObjectTypes.Number,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter
    ]
        this.creditNoteService.getAllFiltered(filter).subscribe(r=>{
            const result = r['value'][0];
            if(result)
            this.itemForm.patchValue({
                appliedCreditNoteAmount:result.amount
            });
           
        });
    }

    async getProductInventory(branchOfficeId:number,warehouseId:number=0,productId:number=0){
        this.inventoryService.patchGenericByUrlParameters(['GetCompanyInventory',branchOfficeId.toString(),warehouseId.toString(),productId.toString()]).subscribe(r=>{
            const result = r.data[0];
            if(result.warehouses){
                const warehouses = result.warehouses.filter(x=>x.code!='DEF');
                this.inventories=[];
                warehouses.forEach(w=>{
                    const productInventory= w.inventory.filter(x=>x.productId == productId);
                    if(productInventory.length>0)
                    this.inventories = this.inventories.concat(productInventory);
                });
            }
        })
    }

  
    onChanges(): void {
      

           this.itemForm.get('quantity').valueChanges.subscribe(val => {
            if(val){
                this.refreshAmounts(true);
            }
            });

            this.itemForm.get('appliedCreditNote').valueChanges.subscribe(val => {
                if(val){
                    this.getCreditNote();
                }
                else
                this.itemForm.patchValue({appliedCreditNoteAmount:0});
                });

            this.itemForm.get('discountRate').valueChanges.subscribe(val => {
                // if(val!=null && val<=100){
                //     for(let i=0; i<this.entries.length;i++){
                //         this.entries[i].discountRate=val;
                //         this.itemForm.get(`unitDiscountRate_${i}`).setValue(val);
                //         this.entries[i].discountAmount =this.entries[i].discountRate>1?( (val/100)* this.entries[i].beforeTaxesAmount):((val)* this.entries[i].beforeTaxesAmount);
                //         this.entries[i].totalAmount =  this.entries[i].beforeTaxesAmount +  this.entries[i].taxesAmount -  this.entries[i].discountAmount;
                //     }
                //    }
                });

            this.itemForm.get('unitId').valueChanges.subscribe(val => {

                this.inventories=[];
                if(val && val!="0"){
                    this.refreshAmounts();
                    const currentUnit = this.productUnits.find(x=>x.unitId==val);
                   const {productId,warehouseId,selectedPrice}= this.itemForm.getRawValue();
                   this.updateSelectedPrice(selectedPrice);
                   const user = this.getUser();
                   const product = this.products.find(x=>x.id==productId);
                  
                   if(!product.isService){
                    this.getProductInventory(user.branchOfficeId,warehouseId==null?0:warehouseId,productId)
                   }
                }
                });

                this.itemForm.get('customerId').valueChanges.subscribe(val => {
                  //  this.resetForm(this.id>0?false:true);
                    if(val && this.customers && this.customers.length>0){
                        this.getSellers(val);
                        const customer = this.customers.find(x=>x.id==val);
                        if(customer)
                        this.itemForm.patchValue({
                            trnControlId:   customer.trnControlId
                        })
                    }
                    });
         
            this.itemForm.get('taxesAmount').valueChanges.subscribe(val => {
               
                    this.refreshAmounts(true);
                
                });
                this.itemForm.get('productCost').valueChanges.subscribe(val => {
                   
                    if(val!=this.oldProductCost)
                    this.refreshAmounts(true);
                
                });

                this.itemForm.get('productPrice').valueChanges.subscribe(val => {
                   
                    if(val!=this.oldProductPrice)
                    this.refreshAmounts(true);
                
                });

                this.itemForm.get('noTaxes').valueChanges.subscribe(val => {
                   
                    if(val)
                   this.itemForm.setControl('taxesAmount',new FormControl(0))
                   else{
                    this.itemForm.setControl('taxesAmount',new FormControl(0));
                    this.refreshAmounts(true);
                   }
                
                });

                this.itemForm.get('selectedPrice').valueChanges.subscribe(val => {
                   
                   if(val){
                     this.updateSelectedPrice(val);
                   }
                
                });

        this.itemForm.get('productId').valueChanges.subscribe(val => {
            if(val && val>0){
                this.inventories=[];
                this.productUnits=[];
                this.productPrices=[];
                this.selectedProductCurrency=null;
                this.itemForm.patchValue({quantity:0, productPrice:0});
                this.productQuantity=0;
                this.showProductQuantity=false;
                const product= this.products.find(x=>x.id==val);
                this.selectedProductCurrency=product.currency;
                this.productPrices=[{ id:1,price:product.price, currency:product.currency.code},{id:2, price:product.price2, currency:product.currency.code},{id:3,price:product.price3, currency:product.currency.code}].filter(x=>x.price>0);
                this.itemForm.patchValue({selectedPrice:this.productPrices[0].price});
               if( product.isService){
                this.itemForm.removeControl('unitId');
                this.itemForm.addControl('unitId', new FormControl(null))
               }
               else{
                this.itemForm.removeControl('unitId');
                this.itemForm.addControl('unitId',this.defaultUnitValidator)   
                this.GetProductUnits(val);
            }
                this.productTaxes=[];
                this.GetProductTaxes(val);
                this.itemForm.patchValue({unitId:null});
                
                this.GetProductCost(val);
            }
        });
      
      }

      updateSelectedPrice(val){
        const {productId,unitId}= this.itemForm.getRawValue();
        if(productId && productId>0){
            let price =val;
         if (unitId){
          const productUnit = this.productUnits.find(x=>x.unitId==unitId);
          price = val/productUnit.equivalence;
         }

         this.itemForm.patchValue({productPrice:price});

        }
      }
    resetForm(deleteEntries:boolean=false){
        
        this.itemForm.patchValue({
            trnType:null,
            nrc:null,
            productId:null,
            unitId:null,
            warehouseId:null,
            sellerId:null,
            discountRate:0,
            discountAmount:0,
            currencyName:'',
            currencyId:0,
            exchangeRate:0,
            appliedCreditNote:'',
            sellerRate:0,
            paidDate:null,
            receivedAmount:0,
            cost:0,
            appliedCreditNoteAmount:0,
            trn:null,
            trnControlId:null,
            details:null,
            quantity:0,
            productCost:0,
            productPrice:0,
            selectedPrice:0,
            beforeTaxesAmount:0,
            paidAmount:0,
            returnedAmount:0,
            owedAmount:0,
            noTaxes:false,
            taxesAmount:0,
            totalAmount:0,
            free:false
        });
        if(deleteEntries)
        this.entries=[];
    }
    get form() { return this.itemForm.controls; }

    get formValues(){
        let form = this.itemForm.getRawValue();
        form.beforeTaxesAmount= this.getTotalAmount(this.entries,'beforeTaxesAmount');
        form.taxesAmount= this.getTotalAmount(this.entries,'taxesAmount');
        form.discountAmount = this.getTotalAmount(this.entries,'discountAmount')
        form.totalAmount= this.getTotalAmount(this.entries,'totalAmount');
        form.owedAmount= form.totalAmount - form.paidAmount - form.appliedCreditNoteAmount;
        form.owedAmount = form.owedAmount <0?0:form.owedAmount;
        form.owedAmount= form.owedAmount<0?0:form.owedAmount;
        form.returnedAmount = form.paidAmount - form.totalAmount;
        form.returnedAmount = form.returnedAmount>0?form.returnedAmount:0;
        return form;
    }

    verifyTotalAmount(){
        const calculatedAmount= this.itemForm.get('totalAmountCalc')?this.itemForm.get('totalAmountCalc').value:0;
        const total= this.itemForm.get('totalAmount')?this.itemForm.get('totalAmount').value:0;
      
    }

    
    save(){
        if (!this.entries || this.entries.length==0 )
            return;
            this.updateEntriesValues();
        let form = this.itemForm.getRawValue() as any;
           form.warehouseId=form.warehouseId==0?null:form.warehouseId;
           form.invoiceDetails=this.entries;
           form.discountAmount=0;
           form.state=!form.state?(form.inventoryModified?BillingStates.Billed:BillingStates.Quoted):form.state;
            const subscription =window.location.href.split('/').findIndex(x=>x.toLowerCase()=='add')>=0? this.invoiceService.post(form,"",""):this.invoiceService.put(form,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/invoice');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    updateEntriesValues(){
        const form = this.itemForm.getRawValue();
        for(let i=0;i<this.entries.length;i++){
            this.entries[i].quantity = form[`unitQuantity_${i}`];
            this.entries[i].quantity = !this.entries[i].quantity?0:this.entries[i].quantity;
            this.entries[i].discountRate = form[`unitDiscountRate_${i}`];
            this.entries[i].discountRate = !this.entries[i].discountRate?0:this.entries[i].discountRate;
            this.entries[i].discountAmount= this.entries[i].discountRate/100*this.entries[i].beforeTaxesAmount;
            this.entries[i].discountAmount = !this.entries[i].discountAmount?0:this.entries[i].discountAmount;
        }
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/invoice');
    }

    addEntry(){
       let entry = this.itemForm.getRawValue() as any;
        if(this.itemForm.invalid)
        return;
        const customerCurrency =entry.customerId && entry.customerId>0? this.customers.find(x=>x.id==entry.customerId).currency:null;
        const rate =!customerCurrency?0:  customerCurrency.isLocalCurrency? this.selectedProductCurrency.exchangeRate:(this.selectedProductCurrency.exchangeRate/customerCurrency.exchangeRate);
      entry.product= this.products.find(x=>x.id==entry.productId);
      entry.amount = entry.productPrice * rate;
      entry.productId=parseInt(entry.productId.toString());
      entry.unitId=entry.product.isService || !entry.unitId?null: parseInt(entry.unitId.toString());
      entry.unit=entry.unitId?this.productUnits.find(x=>x.unitId==entry.unitId).unit:{id:0, name:''};
      entry.id=0;
      entry.product.taxes=this.productTaxes;
      entry.taxesAmount= entry.product.taxes.length<=0?0:entry.product.taxes.reduce(function(a,b){return a+(b.tax.rate*(entry.beforeTaxesAmount -entry.discountAmount))},0);
      entry.product.productUnits = this.productUnits;
      entry.discountAmount = entry.discountRate>1?( entry.discountRate/100 * entry.beforeTaxesAmount):(entry.discountRate* entry.beforeTaxesAmount);
      const currentIndex =this.entries.length;
        let index = this.entries.findIndex(x=>x.productId==entry.productId && x.warehouseId==entry.warehouseId);
        
        if(index<0){
            this.setDetailFormAmount(currentIndex,entry.quantity,true);
            this.setDetailFormDiscount(currentIndex,entry.discountRate,true);
            this.entries.push(entry);
        }
        else {
            this.entries.splice(index,1);
            this.entries.push(entry);
        }

        this.itemForm.patchValue({
            productId:null,
            quantity:0,
            beforeTaxesAmount:0,
            taxesAmount:0,
            totalAmount:0,
            unitId:null,
            noTaxes:false,
            free:false,
            productCost:0,
            productPrice:0

        });
      
    }
    deleteEntry(index:number){
        this.itemForm.removeControl(`unitQuantity_${index}`);
        this.itemForm.removeControl(`unitDiscountRate_${index}`);
        this.entries.splice(index,1);
    }
  

    getCurrentInvoice(invoiceId:number){
        this.invoiceService.getByUrlParameters(['GetForPrint',invoiceId.toString()])
        .subscribe(r=>{
            
            if(r.status>=0){
                for(let i=0; i<this.entries.length;i++){
                    if(this.itemForm.contains(`unitQuantity_${i}`))
                    this.itemForm.removeControl(`unitQuantity_${i}`);

                    if(this.itemForm.contains(`unitDiscountRate_${i}`))
                    this.itemForm.removeControl(`unitDiscountRate_${i}`);
                }
                if(r.data[0] && r.data[0].invoiceDetails && r.data[0].invoiceDetails.length>0){
                    for(let i=0; i<r.data[0].invoiceDetails.length;i++){
                        this.setDetailFormAmount(i,r.data[0].invoiceDetails[i].quantity);
                        this.setDetailFormDiscount(i,r.data[0].invoiceDetails[i].discountRate);
                      }
                }
                this.entries=r.data[0] && r.data[0].
                invoiceDetails?r.data[0].invoiceDetails:[];
                this.item=r.data[0];
                this.itemForm.patchValue(this.item);

               
            }
            else
            this.modalService.showError(r.message);
            
        this.validateFormData();
           
        })
    }



    setDetailFormAmount(index:number,quantity:number, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`unitQuantity_${index}`))
        this.itemForm.addControl(`unitQuantity_${index}`,new FormControl({value:quantity, disabled:isNewEntry?false: this.isEditing},[ Validators.required,Validators.min(0.0001)]));
    }

     setDetailFormDiscount(index:number,discount:number, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`unitDiscountRate_${index}`))
        this.itemForm.addControl(`unitDiscountRate_${index}`,new FormControl({value:discount, disabled:isNewEntry?false: this.isEditing},[Validators.max(100) ,Validators.min(0)]));
    }
    refreshAmounts(fromForm:boolean=false){
    
        let {productPrice,productCost,quantity,unitId,beforeTaxesAmount, totalAmount, taxesAmount,discountAmount, discountRate,customerId} = this.itemForm.getRawValue() as any;
        
       const equivalence =unitId && unitId>0? this.productUnits.find(x=>x.unitId==unitId).equivalence:1;
            const customerCurrency =customerId && customerId>0 && this.customers.length>0? this.customers.find(x=>x.id==customerId).currency:null;
            const rate =!customerCurrency?0:  customerCurrency.isLocalCurrency? this.selectedProductCurrency.exchangeRate:(this.selectedProductCurrency.exchangeRate/customerCurrency.exchangeRate);
            productPrice=productPrice*rate;
            productCost=(fromForm?productCost:this.currentProductCost.cost>0?(this.currentProductCost.cost/equivalence):productCost)*rate;
            beforeTaxesAmount= quantity * productPrice;
            discountAmount= beforeTaxesAmount* (discountRate>1?discountRate/100:discountRate);
            taxesAmount=(this.CalculateProductTax() * quantity)*rate;
            taxesAmount= (taxesAmount - (discountRate>1?taxesAmount*discountRate/100:taxesAmount*discountRate));
            totalAmount= beforeTaxesAmount + taxesAmount - discountAmount;
            this.oldProductCost=productCost;
            this.oldProductPrice=productPrice;
            this.itemForm.patchValue({
                productCost,
                beforeTaxesAmount,
                totalAmount,
                taxesAmount,
                discountAmount
            })
        
            
      
      
    }
}