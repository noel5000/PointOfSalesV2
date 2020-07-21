

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
    itemForm: FormGroup;
    item: any;
    id:number=0;
    branchOfficeId:number=0;
    warehouseId:number=0;
    currentDate:string='';
    _route:ActivatedRoute;
    products:Product[]=[];//
    customers:Customer[]=[];
    trnControls:TRNControl[]=[];
    sellers:Seller[]=[];
    warehouses:Warehouse[]=[];
    productUnits:any[]=[];//
    productTaxes:any[]=[];//
    entries:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);
    currentProductCost:any={cost:0};
    currentProductPrice:any={sellingPrice:0,costPrice:0};
    invoiceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Invoice`);
    menuService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Menu`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productTaxService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductTax`);
    oldProductCost:number=0;
    oldProductPrice:number=0;

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private productService:ProductService,
        private modalService:ModalService,
      private  http: HttpClient,
      private customerService:CustomerService,
      private trnControlService:TRNControlService,
      private sellerService:SellerService,
      private warehouseService:WarehouseService
        ){
           
            super(route, langService, AppSections.InvoiceLeads);
            this.verifyUser();
            this._route=router;
            this.id=parseInt( this._route.snapshot.paramMap.get('id'))>0?parseInt( this._route.snapshot.paramMap.get('id')):0;
            this.currentDate = new Date().toDateString();
            if( this.id && this.id>0){
                this.getCurrentInvoice(this.id);
                
            }
            
           this.branchOfficeId=this.authModel.user.branchOfficeId;
           this.warehouseId=this.authModel.user.warehouseId;
            
        this.itemForm = this.formBuilder.group({
id: [0],
customerId:[null,[ Validators.required,Validators.min(1)]],
trnType:[null,[ Validators.required]],
nrc:[null,[ Validators.required]],
productId:[null,[ Validators.required,Validators.min(1)]],
unitId:this.defaultUnitValidator,
branchOfficeId:[this.branchOfficeId],
warehouseId:[null],
sellerId:[null],
billingDate:[this.currentDate],
inventoryModified:[true],
discountRate:[0],
currencyName:[''],
cashRegisterId:[0],
invoiceNumber:[''],
documentNumber:[''],
currencyId:[0],
state:[''],
quantity:[0,[ Validators.required,Validators.min(0.0001)]],
productCost:[0],
productPrice:[0],
beforeTaxesAmount:[0],
noTaxes:[false],
taxAmount:[0],
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
       
    }

    async getCustomers(){
        const filter = [
        {
            property: "Currency",
            value: "Id,Name,Code,ExchangeRate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.customerService.getAllFiltered(filter).subscribe(r=>{
            this.customers=[{id:0, name:''} as Customer];
            this.customers=this.customers.concat( r['value']);
        });
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
            this.productUnits=[{id:0, unitId:0,unit:{id:0, name:''},sellingPrice:0, costPrice:0}];
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

    CalculateProductTax():number{
        const {productPrice}= this.itemForm.getRawValue();
        return this.productTaxes.length<=0?0:this.productTaxes.reduce(function(a,b){return a+(b.tax.rate*productPrice)},0);
    }

    

    async GetProductCost(productId:number){
        const currentProduct = this.products.find(x=>x.id==productId);
        this.currentProductCost.cost=currentProduct.cost;
        const {unitId} = this.itemForm.getRawValue();
        this.currentProductPrice.sellingPrice= unitId && unitId>0 && this.productUnits.length>0?this.productUnits.find(x=>x.unitId==unitId).sellingPrice: currentProduct.price;
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

  
    onChanges(): void {
      

           this.itemForm.get('quantity').valueChanges.subscribe(val => {
            if(val){
                this.refreshAmounts(true);
            }
            });

            this.itemForm.get('unitId').valueChanges.subscribe(val => {
                if(val){
                    this.refreshAmounts();
                }
                });

                this.itemForm.get('customerId').valueChanges.subscribe(val => {
                    if(val){
                        this.getSellers(val);
                    }
                    });
         
            this.itemForm.get('taxAmount').valueChanges.subscribe(val => {
               
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
                   this.itemForm.setControl('taxAmount',new FormControl(0))
                   else{
                    this.itemForm.setControl('taxAmount',this.defaultTaxAmountValidator);
                    this.refreshAmounts(true);
                   }
                
                });
         
        this.itemForm.get('productId').valueChanges.subscribe(val => {
            if(val && val>0){
                this.itemForm.patchValue({quantity:0});
                const product= this.products.find(x=>x.id==val);
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
    
    get form() { return this.itemForm.controls; }

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
           form.state=!form.state?(form.inventoryModified?BillingStates.Quoted:BillingStates.Billed):form.state;
            const subscription =window.location.href.split('/').findIndex(x=>x.toLowerCase()=='add')>=0? this.invoiceService.post(form,"",""):this.invoiceService.put(form,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
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
        }
    }

    cancel(){
    this.router.navigateByUrl('pages/invoice');
    }

    addEntry(){
       let entry = this.itemForm.getRawValue() as any;
        if(this.itemForm.invalid)
        return;
       
      entry.product= this.products.find(x=>x.id==entry.productId);
      entry.productId=parseInt(entry.productId.toString());
      entry.unitId=entry.product.isService || !entry.unitId?null: parseInt(entry.unitId.toString());
      entry.unit=entry.unitId?this.productUnits.find(x=>x.unitId==entry.unitId).unit:{id:0, name:''};
      entry.id=0;
      entry.product.taxes=this.productTaxes;
      entry.product.productUnits = this.productUnits;
      const currentIndex =this.entries.length;
        let index = this.entries.findIndex(x=>x.productId==entry.productId && x.warehouseId==entry.warehouseId);
        
        if(index<0){
            this.setDetailFormAmount(currentIndex,entry.quantity);
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
            taxAmount:0,
            totalAmount:0,
            unitId:null,
            noTaxes:false,
            free:false,
            productCost:0,
            productPrice:0

        });
      
    }
    deleteEntry(index:number){
      
        this.entries.splice(index,1);
    }
  

    getCurrentInvoice(invoiceId:number){
        this.invoiceService.getById(invoiceId)
        .subscribe(r=>{
            
            if(r.status>=0){
                for(let i=0; i<this.entries.length;i++){
                    if(this.itemForm.contains(`unitQuantity_${i}`))
                    this.itemForm.removeControl(`unitQuantity_${i}`);
                }
                if(r.data[0] && r.data[0].invoiceDetails && r.data[0].invoiceDetails.length>0){
                    for(let i=0; i<r.data[0].leadDetails.length;i++){
                        this.setDetailFormAmount(i,r.data[0].leadDetails[i].quantity);
                          
                      }
                }
                this.entries=r.data[0] && r.data[0].
                invoiceDetails?r.data[0].invoiceDetails:[];
                this.item=r.data[0];
                this.itemForm.patchValue(this.item);

               
            }
            else
            this.modalService.showError(r.message);
           
        })
    }



    setDetailFormAmount(index:number,quantity:number){
        if(!this.itemForm.contains(`unitQuantity_${index}`))
        this.itemForm.addControl(`unitQuantity_${index}`,new FormControl(quantity,[ Validators.required,Validators.min(0.0001)]));
    }
    refreshAmounts(fromForm:boolean=false){
    
        let {productPrice,productCost,quantity,unitId,beforeTaxesAmount, totalAmount, taxAmount} = this.itemForm.getRawValue() as any;

       const equivalence =unitId && unitId>0? this.productUnits.find(x=>x.unitId==unitId).equivalence:1;
            productCost=fromForm?productCost:this.currentProductCost.cost>0?(this.currentProductCost.cost/equivalence):productCost;
            productPrice=fromForm?productPrice:this.currentProductPrice.sellingPrice>0?(this.currentProductPrice.sellingPrice/equivalence):productPrice;
            beforeTaxesAmount= quantity * productPrice;
            taxAmount=this.CalculateProductTax() * quantity;
            totalAmount= beforeTaxesAmount + taxAmount;
            this.oldProductCost=productCost;
            this.oldProductPrice=productPrice;
            this.itemForm.patchValue({
                productCost,
                beforeTaxesAmount,
                totalAmount,
                productPrice,
                taxAmount
            })
        
            
      
      
    }
}