

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
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
import { Warehouse } from '../../../@core/data/Warehouse';
import { Product } from '../../../@core/data/product';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { ProductService } from '../../../@core/services/ProductService';
import { Item } from '../../../@core/data/itemModel';
import { SchoolService } from '../../../@core/services/SchoolService';
import { School } from '../../../@core/data/school';


declare const $: any;
@Component({
    selector: "invoice-lead-form",
    templateUrl: "./invoiceLeadForm.component.html",
    styleUrls: ["../invoiceLeadsStyles.component.scss"]
})
export class InvoiceLeadFormComponent extends BaseComponent implements OnInit {
    itemForm: FormGroup;
    item: any;
    menuId:number=0;
    leadId:number=0;
    schoolId:number=0;
    branchOfficeId:number=0;
    warehouseId:number=0;
    currentDate:string='';
    _route:ActivatedRoute;
    products:Product[]=[];//
    productUnits:any[]=[];//
    productTaxes:any[]=[];//
    entries:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);
    currentProductCost:any={cost:0};
    currentProductPrice:any={sellingPrice:0,costPrice:0};
    invoiceLeadsService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}InvoiceLead`);
    menuService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Menu`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productTaxService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductTax`);
    oldProductCost:number=0;
    oldProductPrice:number=0;
    menu:any=null;
    school:School=null;
    weeksOfMonth:Item[]=[
        {
            id:null,
            name:``
        },
        {
            id:0,
            name:`${this.lang.getValueByKey('week_lbl')} 1`
        },
         {
            id:1,
            name:`${this.lang.getValueByKey('week_lbl')} 2`
        },
        {
            id:2,
            name:`${this.lang.getValueByKey('week_lbl')} 3`
        },
        {
            id:3,
            name:`${this.lang.getValueByKey('week_lbl')} 4`
        },
        {
            id:4,
            name:`${this.lang.getValueByKey('week_lbl')} 5`
        },
    ];

    daysOfWeek:Item[]=[
        {
            id:null,
            name:``
        },
        {
            id:1,
            name:`${this.lang.getValueByKey('monday_lbl')}`
        },
         {
            id:2,
            name:`${this.lang.getValueByKey('tusday_lbl')}`
        },
        {
            id:3,
            name:`${this.lang.getValueByKey('wendsday_lbl')}`
        },
        {
            id:4,
            name:`${this.lang.getValueByKey('thursday_lbl')}`
        },
        {
            id:5,
            name:`${this.lang.getValueByKey('friday_lbl')}`
        },
    ];

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private schoolService:SchoolService,
        private productService:ProductService,
        private modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.InvoiceLeads);
            this._route=router;
            this.menuId= parseInt( this._route.snapshot.paramMap.get('menuid'))>=0?parseInt( this._route.snapshot.paramMap.get('menuid')):0;
            this.schoolId =parseInt( this._route.snapshot.paramMap.get('schoolid'))>0?parseInt( this._route.snapshot.paramMap.get('schoolid')):0;
            this.branchOfficeId =parseInt( this._route.snapshot.paramMap.get('branchofficeid'))>0?parseInt( this._route.snapshot.paramMap.get('branchofficeid')):0;
            this.warehouseId =parseInt( this._route.snapshot.paramMap.get('warehouseid'))>0?parseInt( this._route.snapshot.paramMap.get('warehouseid')):0;
            this.leadId=parseInt( this._route.snapshot.paramMap.get('leadid'))>0?parseInt( this._route.snapshot.paramMap.get('leadid')):0;
            this.currentDate = this._route.snapshot.paramMap.get('date');
            if( this.menuId && this.menuId>0){
                if(window.location.href.split('/').findIndex(x=>x.toLowerCase()=='add')>=0)
                this.getCurrentMenu(this.menuId);
                else
                this.getCurrentLead(this.leadId);
                
            }
            if(this.schoolId &&this.schoolId>0)
            this.getSchool(this.schoolId);
            
        this.itemForm = this.formBuilder.group({
id: [0],
weekNumber:[null,[ Validators.required,Validators.min(0), Validators.max(4)]],
dayOfWeek:[null,[ Validators.required,Validators.min(1), Validators.max(5)]],
productId:[null,[ Validators.required,Validators.min(1)]],
unitId:this.defaultUnitValidator,
schoolId:[this.schoolId],
menuId:[this.menuId],
leadId:[this.leadId],
branchOfficeId:[this.branchOfficeId],
warehouseId:[this.warehouseId],
sellerId:[0],
date:[this.currentDate],
inventoryModified:[false],
billingDate:[''],
invoiceId:[null],
cashRegisterId:[null],
invoiceNumber:[''],
currencyId:[0],
schoolName:[''],
state:[''],
currencyCode:[''],
quantity:[0,[ Validators.required,Validators.min(0.0001)]],
productCost:[0],
productPrice:[0],
beforeTaxesAmount:[0],
noTaxes:[false],
taxAmount:[0],
totalAmount:[0],
sequence:[''],
documentNumber:['']
        });
    }
    ngOnInit(): void {
   
     this.onChanges();
        this.verifyUser();
        this.getProducts();
       
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
                this.itemForm.patchValue({currencyCode:product.currency.code})
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
           form.currencyId=this.school.currencyId;
           form.customerId=this.school.customerId;
           form.zoneId=this.school.zoneId;
           form.leadDetails=this.entries;
           form.state=!form.state?(form.inventoryModified?BillingStates.Generated:BillingStates.GeneratedWithoutInventory):form.state;
            const subscription =window.location.href.split('/').findIndex(x=>x.toLowerCase()=='add')>=0? this.invoiceLeadsService.post(form,"",""):this.invoiceLeadsService.put(form,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl('pages/invoiceleads');
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
    this.router.navigateByUrl('pages/invoiceleads');
    }

    addEntry(){
       let entry = this.itemForm.getRawValue() as any;
        if(this.itemForm.invalid)
        return;
       
      entry.product= this.products.find(x=>x.id==entry.productId);
      entry.currencyId=entry.product?parseInt(entry.product.currencyId.toString()):null;
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
      
    }
    deleteEntry(index:number){
      
        this.entries.splice(index,1);
    }
    getCurrentMenu(menuId:number){
        this.menuService.getById(menuId)
        .subscribe(r=>{
            
            if(r.status>=0){
                for(let i=0; i<this.entries.length;i++){
                    if(this.itemForm.contains(`unitQuantity_${i}`))
                    this.itemForm.removeControl(`unitQuantity_${i}`);
                }
                if(r.data[0] && r.data[0].menuDetails && r.data[0].menuDetails.length>0){
                    for(let i=0; i<r.data[0].menuDetails.length;i++){
                        this.setDetailFormAmount(i,r.data[0].menuDetails[i].quantity);
                          
                      }
                }
                this.entries=r.data[0] && r.data[0].
                menuDetails?r.data[0].menuDetails:[];
                this.menu=r.data[0]
                this.itemForm.patchValue(this.menu);
                this.itemForm.patchValue({id:0,menuId:this.menu.id});
               
            }
            else
            this.modalService.showError(r.message);
           
        })
    }

    getCurrentLead(menuId:number){
        this.invoiceLeadsService.getById(menuId)
        .subscribe(r=>{
            
            if(r.status>=0){
                for(let i=0; i<this.entries.length;i++){
                    if(this.itemForm.contains(`unitQuantity_${i}`))
                    this.itemForm.removeControl(`unitQuantity_${i}`);
                }
                if(r.data[0] && r.data[0].leadDetails && r.data[0].leadDetails.length>0){
                    for(let i=0; i<r.data[0].leadDetails.length;i++){
                        this.setDetailFormAmount(i,r.data[0].leadDetails[i].quantity);
                          
                      }
                }
                this.entries=r.data[0] && r.data[0].
                leadDetails?r.data[0].leadDetails:[];
                this.menu=r.data[0];
                this.itemForm.patchValue(this.menu);
               
            }
            else
            this.modalService.showError(r.message);
           
        })
    }

    getSchool(id:number){
        this.schoolService.getById(id)
        .subscribe(r=>{
            
            if(r.status>=0){
               this.school=r.data[0];
                this.itemForm.patchValue({schoolName:this.school.nameAndCode});
               
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
            beforeTaxesAmount= quantity * productCost;
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