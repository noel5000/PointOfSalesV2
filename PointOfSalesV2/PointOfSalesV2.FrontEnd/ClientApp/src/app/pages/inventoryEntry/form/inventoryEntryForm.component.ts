

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
import { Warehouse } from '../../../@core/data/Warehouse';
import { Product } from '../../../@core/data/product';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { ProductService } from '../../../@core/services/ProductService';


declare const $: any;
@Component({
    selector: "inventory-entry-form",
    templateUrl: "./inventoryEntryForm.component.html",
    styleUrls: ["../inventoryEntryStyles.component.scss"]
})
export class InventoryEntryFormComponent extends BaseComponent implements OnInit {

    branchOffices:BranchOffice[];
    warehouses:Warehouse[]=[];
    _route:ActivatedRoute;
    products:Product[]=[];//
    suppliers:Supplier[]=[];//
    productUnits:any[]=[];//
    entries:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    currentProductCost:any={cost:0};
    inventoryEntryService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}InventoryEntry`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productCostService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductCost`);
    oldProductCost:number=0;


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private productService:ProductService,
        private supplierService:SupplierService,
        private branchOfficeService:BranchOfficeService,
        private warehouseService:WarehouseService,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.InventoryIncomes,modalService);
            this._route=router;
            this.dataToBackup="entries,warehouses,productUnits,currentProductCost,oldProductCost";
        this.itemForm = this.formBuilder.group({
id: [0],
branchOfficeId:[null,[ Validators.required,Validators.min(1)]],
warehouseId:[null,[ Validators.required,Validators.min(1)]],
supplierId:[null,[ Validators.required,Validators.min(1)]],
productId:[null,[ Validators.required,Validators.min(1)]],
unitId:[null,[ Validators.required,Validators.min(1)]],
reference:[''],
currencyCode:[''],
details:[''],
quantity:[0,[ Validators.required,Validators.min(0.0001)]],
productCost:[0],
beforeTaxesAmount:[0],
noTaxes:[false],
taxAmount:[0,[ Validators.required,Validators.min(0.0001)]],
totalAmount:[0,[ Validators.required,Validators.min(0.0001)]],
        });
    }
    ngOnInit(): void {
   
     this.onChanges();
        this.verifyUser();
        this.getProducts();
        this.getSuppliers();
        this.getBranchOffices();
        this.validateFormData();
       
    }
    async pepe(id:number){
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
        this.warehouseService.getAllFiltered(filter).subscribe(r=>{
            this.warehouses=r['value'];
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
            this.productUnits=[{id:0, unitId:0,unit:{id:0, name:''}}];
            this.productUnits=this.productUnits.concat( r['value']);
        });
    }

    async GetProductSupplierCost(supplierId:number,productId:number){
        const filter = [{
            property: 'ProductId',
            value: productId.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: 'SupplierId',
            value: supplierId.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
    ]
        this.productCostService.getAllFiltered(filter).subscribe(r=>{
            this.currentProductCost=r['value'][0]?r['value'][0]:this.currentProductCost;
            const currentProduct=this.products.find(x=>x.id==productId);
            if(!r['value'][0] && currentProduct)
            this.currentProductCost.cost=currentProduct.cost;
            this.refreshAmounts();
        });
    }

    async getWarehouses(id:number){
        const filter = [{
            property: 'BranchOfficeId',
            value: id.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: 'Code',
            value: 'DEF',
            type: ObjectTypes.String,
            isTranslated:false,
            comparer: ODataComparers.NotEqual
        } as QueryFilter
    ]
        this.warehouseService.getAllFiltered(filter).subscribe(r=>{
            this.warehouses=[{id:0, name:''} as Warehouse];
            this.warehouses= this.warehouses.concat(r['value']);
        });
    }

    async getProducts(){
        const filter = [{
            property: 'IsService',
            value: 'false',
            type: ObjectTypes.Boolean,
            isTranslated:false
        } as QueryFilter,
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

async getBranchOffices(){
    this.branchOfficeService.getAll().subscribe(r=>{
        this.branchOffices=r;
        if(this.branchOffices.length==1)
        this.itemForm.patchValue({branchOfficeId:this.branchOffices[0].id});
    });
}


async getSuppliers(){
    this.supplierService.getAll().subscribe(r=>{this.suppliers=r});
}
  
    onChanges(): void {
        this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
         if(val && val>0){
            this.itemForm.patchValue({warehouseId:null});
            this.getWarehouses(val);
         }
        });
        this.itemForm.get('supplierId').valueChanges.subscribe(val => {
           if(val && val>0){
               const {productId} = this.itemForm.getRawValue() as any;
               if(productId && productId>0)
               this.GetProductSupplierCost(val,productId);
           }
           });

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

                this.itemForm.get('noTaxes').valueChanges.subscribe(val => {
                   
                    if(val)
                   this.itemForm.setControl('taxAmount',new FormControl(0))
                   else
                   this.itemForm.setControl('taxAmount',this.defaultTaxAmountValidator);
                
                });
         
        this.itemForm.get('productId').valueChanges.subscribe(val => {
            if(val && val>0){
                const product= this.products.find(x=>x.id==val);
                this.itemForm.patchValue({currencyCode:product.currency.code})
                this.GetProductUnits(val);
                this.itemForm.patchValue({unitId:null});
                const {supplierId} = this.itemForm.getRawValue() as any;
                if(supplierId && supplierId>0)
                this.GetProductSupplierCost(supplierId,val);
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
        const form = this.itemForm.getRawValue() as any;
           const ToSave ={
               reference:form.reference,
               details:form.details,
               entries:this.entries
           }
          
            const subscription =this.inventoryEntryService.post(ToSave,"","AddEntries");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/inventoryentry');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/inventoryentry');
    }

    addEntry(){
       let entry = this.itemForm.getRawValue() as any;
        if(this.itemForm.invalid)
        return;
      entry.product= this.products.find(x=>x.id==entry.productId);
      entry.currencyId=entry.product?parseInt(entry.product.currencyId.toString()):null;
      entry.branchOfficeId=parseInt(entry.branchOfficeId.toString());
      entry.warehouseId=parseInt(entry.warehouseId.toString());
      entry.supplierId=parseInt(entry.supplierId.toString());
      entry.productId=parseInt(entry.productId.toString());
      entry.unitId=parseInt(entry.unitId.toString());
      entry.product=this.products.find(x=>x.id==entry.productId);
      entry.warehouse=this.warehouses.find(x=>x.id==entry.warehouseId);
      entry.unit=this.productUnits.find(x=>x.unitId==entry.unitId).unit;
      
        let index = this.entries.findIndex(x=>x.productId==entry.productId && x.warehouseId==entry.warehouseId);
        
        if(index<0)
        this.entries.push(entry);
        else {
            this.entries.splice(index,1);
            this.entries.push(entry);
        }
      
    }
    deleteEntry(index:number){
      
        this.entries.splice(index,1);
    }

    refreshAmounts(fromForm:boolean=false){
    
        let {productId,productCost,quantity,unitId,beforeTaxesAmount, totalAmount, taxAmount} = this.itemForm.getRawValue() as any;

       const equivalence =unitId && unitId>0? this.productUnits.find(x=>x.unitId==unitId).equivalence:1;
            productCost=fromForm?productCost:this.currentProductCost.cost>0?(this.currentProductCost.cost/equivalence):productCost;
            beforeTaxesAmount= quantity * productCost;
            totalAmount= beforeTaxesAmount + taxAmount;
            this.oldProductCost=productCost;
            this.itemForm.patchValue({
                productCost,
                beforeTaxesAmount,
                totalAmount
            })
        
            
      
      
    }
}