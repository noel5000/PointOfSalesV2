

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
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
    selector: "warehouse-transfer-form",
    templateUrl: "./warehouseTransfersForm.component.html",
    styleUrls: ["../warehouseTransfersStyles.component.scss"]
})
export class WarehouseTransferFormComponent extends BaseComponent implements OnInit {

    originBranchOffices:BranchOffice[];
    destinyBranchOffices:BranchOffice[];
    originWarehouses:Warehouse[]=[];
    destinyWarehouses:Warehouse[]=[];
    _route:ActivatedRoute;
    products:Product[]=[];//
    productUnits:any[]=[];//
    entries:any[]=[];
    originInventory:any={id:0,currentUnitEquivalence:0};
    destinyInventory:any={id:0,currentUnitEquivalence:0};
    warehouseTransferService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}WarehouseTransfer`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    inventoryService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Inventory`);
  


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private productService:ProductService,
        private branchOfficeService:BranchOfficeService,
        private warehouseService:WarehouseService,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.InventoryIncomes,modalService);
            this.dataToBackup="entries,productUnits,originBranchOffice,destinyBranchOffice,originWarehouses,destinyWarehouses,originInventory,destinyInventory";
            this._route=router;
        this.itemForm = this.formBuilder.group({
id: [0],
originBranchOfficeId:[null,[ Validators.required,Validators.min(1)]],
originId:[null,[ Validators.required,Validators.min(1)]],
destinyBranchOfficeId:[null],
destinyId:[null,[ Validators.required,Validators.min(1)]],
productId:[null,[ Validators.required,Validators.min(1)]],
unitId:[null,[ Validators.required,Validators.min(1)]],
reference:[''],
details:[''],
quantity:[0,[ Validators.required,Validators.min(0.0001)]],
        });
    }
    ngOnInit(): void {
   
     this.onChanges();
        this.verifyUser();
        this.getProducts();
        this.getBranchOffices();
        this.validateFormData();
       
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

   

    async getWarehouses(id:number,destiny:boolean=false){
        const filter = [{
            property: 'BranchOfficeId',
            value: id.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter
    ]
        this.warehouseService.getAllFiltered(filter).subscribe(r=>{
            if(destiny || !this.itemForm.getRawValue().destinyBranchOfficeId){
                this.destinyWarehouses=[{id:0, name:''} as Warehouse];
                this.destinyWarehouses= this.destinyWarehouses.concat(r['value']);
            }
            if(!destiny){
                this.originWarehouses=[{id:0, name:''} as Warehouse];
                this.originWarehouses= this.originWarehouses.concat(r['value']);
            }
           
        });
    }

    async getProductInventory(productId:number,warehouseId:number){
        const filter = [{
            property: 'ProductId',
            value: productId.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: 'WarehouseId',
            value: warehouseId.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter
    ];
        this.inventoryService.getAllFiltered(filter).subscribe(r=>{
            
                this.originInventory= r['value'][0]?r['value'][0]:{id:0,currentUnitEquivalence:0};
                if(this.originInventory.id>0){
                    const {unitId} = this.itemForm.getRawValue();
                    if(unitId)
                    this.originInventory.currentUnitEquivalence=this.productService.ConvertFromProductPrincipalUnit(this.originInventory.quantity,unitId,this.productUnits)
                    else
                    this.originInventory.currentUnitEquivalence=0;
                }
               
            
           
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
        this.originBranchOffices=[{id:0, name:''} as BranchOffice];
        this,this.destinyBranchOffices=[{id:0, name:''} as BranchOffice];
        this.originBranchOffices= this.originBranchOffices.concat(r);
        this.destinyBranchOffices = this.destinyBranchOffices.concat(r);
    });
}



  
    onChanges(): void {
        this.itemForm.get('originBranchOfficeId').valueChanges.subscribe(val => {
         if(val && val>0){
            this.itemForm.patchValue({originId:null});
            this.getWarehouses(val);
         }
        });
        this.itemForm.get('destinyBranchOfficeId').valueChanges.subscribe(val => {
            if(val && val>0){
               this.itemForm.patchValue({destinyId:null});
               this.getWarehouses(val,true);
            }
           });

           this.itemForm.get('originId').valueChanges.subscribe(val => {
            if(val && val>0){
                const {destinyId} = this.itemForm.getRawValue() as any;
                if(destinyId && parseInt(destinyId)==parseInt(val))
               this.itemForm.patchValue({destinyId:null});
               else
               {
                const {productId} = this.itemForm.getRawValue() as any;
                if(productId)
                this.getProductInventory(productId,val);
               }
            }
            else
                this.itemForm.patchValue({unitId:null})
                });
           this.itemForm.get('destinyId').valueChanges.subscribe(val => {
               const {originId} = this.itemForm.getRawValue() as any;
            if(val && val>0 ){
                if((originId && parseInt(originId)==parseInt(val))){
               this.itemForm.patchValue({destinyId:null});
                }
                

            }
           });

           this.itemForm.get('unitId').valueChanges.subscribe(val => {
            const {originId,productId} = this.itemForm.getRawValue() as any;
         if(val && val>0 ){
            this.getProductInventory(productId,originId);
             }
             else
             this.originInventory.currentUnitEquivalence=0;
        });
         
        this.itemForm.get('productId').valueChanges.subscribe(val => {
            if(val && val>0){
                const product= this.products.find(x=>x.id==val);
                this.GetProductUnits(val);
                this.itemForm.patchValue({unitId:null});
               if(this.itemForm.getRawValue().originId) {
                    const {productId} = this.itemForm.getRawValue() as any;
                    if(productId)
                    this.getProductInventory(val,this.itemForm.getRawValue().originId);
                   }
            }
            else
            this.itemForm.patchValue({unitId:null});
        });
      
      }

      verifyQuantities():boolean{
          const {quantity} = this.itemForm.getRawValue();
          const result= quantity && quantity>0 && this.originInventory.currentUnitEquivalence>0 && quantity<=this.originInventory.currentUnitEquivalence ;
          if(!result)
          this.itemForm.patchValue({quantity:0});
          return result;
      }
    
    get form() { return this.itemForm.controls; }

    save(){
        if (!this.entries || this.entries.length==0 )
            return;
        const form = this.itemForm.getRawValue() as any;
           const ToSave ={
               reference:form.reference,
               details:form.details,
               entries:this.entries
           }
          
            const subscription =this.warehouseTransferService.post(ToSave,"","AddEntries");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/warehousetransfer');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/warehousetransfer');
    }

    addEntry(){
       let entry = this.itemForm.getRawValue() as any;
        if(this.itemForm.invalid)
        return;
      entry.product= this.products.find(x=>x.id==entry.productId);
      entry.originBranchOfficeId=parseInt(entry.originBranchOfficeId.toString());
      entry.destinyBranchOfficeId=parseInt(entry.destinyBranchOfficeId.toString());
      entry.originId=parseInt(entry.originId.toString());
      entry.destinyId=parseInt(entry.destinyId.toString());
      entry.productId=parseInt(entry.productId.toString());
      entry.unitId=parseInt(entry.unitId.toString());
      entry.unit=this.productUnits.find(x=>x.unitId==entry.unitId).unit;
      entry.origin= this.originWarehouses.find(x=>x.id==entry.originId);
      entry.destiny= this.destinyWarehouses.find(x=>x.id==entry.destinyId);
        let index = this.entries.findIndex(x=>x.productId==entry.productId && x.oringinId==entry.oringinId && x.destinyId ==entry.destinyId);
        
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
}