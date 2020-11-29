

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ProductService } from '../../../@core/services/ProductService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes, ODataComparers } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Product } from '../../../@core/data/product';
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


declare const $: any;
@Component({
    selector: "product-form",
    templateUrl: "./productForm.component.html",
    styleUrls: ["../productStyles.component.scss"]
})
export class ProductFormComponent extends BaseComponent implements OnInit {

    isServiceFlag:boolean=false;
    isCompositeFlag:boolean=false;

    _route:ActivatedRoute;
    currencies:Currency[]=[];//
    units:Unit[]=[];//
    productUnits:any[]=[];//
    otherProducts:Product[]=[];
    suppliers:Supplier[]=[];//
    productSupplierCosts:any[]=[];//
    baseProducts:any[]=[];//
    baseProductUnits:any[]=[];//
    taxes:Tax[]=[];//
    productTaxes:any[]=[];//
    selectedBaseProduct:number=0;
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productSupCostService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}ProductCost`);
    baseProductsService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}CompositeProduct`);
    productTaxService:BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}ProductTax`);
    


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: ProductService,
        private modals:NgbModal,
        private currencyService:CurrencyService,
        private unitService:UnitService,
        private supplierService:SupplierService,
        private taxesService:TaxService,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.Products,modalService);
            this._route=router;
            this.dataToBackup="productUnits,productSupplierCosts,productTaxes,baseProducts,selectedBaseProduct";
        this.itemForm = this.formBuilder.group({
            id: [0],
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(100)]],
            description:[''],
code:[''],
currencyId:[0,[ Validators.required,Validators.min(1)]],
cost:[0],
price:[0,[ Validators.required,Validators.min(0.0001)]],
price2:[0],
price3:[0],
sellerRate:[0],
isService:[false],
isCompositeProduct:[false],
unitId:[0],
equivalence:[0],
isPrimary:[false],
supplierId:[0],
supplierCost:[0],
baseProductId:[0],
baseUnitId:[null],
quantity:[0],
taxId:0
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
        this.getUnits();
        this.getAllProducts();
       
    }

    async getProductBases(){
        const filter = [{
            property: 'ProductId',
            value: this.form.id.value.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "UnitProductEquivalence",
            value: "Id,ProductId,UnitId,CostPrice,SellingPrice,Equivalence",
            type: 4,
            isTranslated: false
        } as QueryFilter,
        {
            property: "BaseProduct",
            value: "Id,Name,Cost,Price,Price2,Price3",
            type: 4,
            isTranslated: false
        } as QueryFilter
    ]
        this.baseProductsService.getAllFiltered(filter).subscribe(r=>{
            this.baseProducts=r['value'];
            this.baseProducts.forEach(p=>{
                if(p['unitProductEquivalence'])
                p['unitProductEquivalence']['unit']=this.units.find(x=>x.id==p.unitProductEquivalence.unitId);
            })
        });
    }

    async getAllProducts(){
        
        this.service.getAll().subscribe(r=>{
            this.otherProducts=r;
            const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        const index = this.otherProducts.findIndex(x=>x.id==urlId);
        if(index>=0)
        this.otherProducts.splice(index,1);
     }
            
        });
    }

    async getProductSuppliersCosts(){
        const filter = [{
            property: 'ProductId',
            value: this.form.id.value.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "Supplier",
            value: "Name",
            type: 4,
            isTranslated: false
        } as QueryFilter
    ]
        this.productSupCostService.getAllFiltered(filter).subscribe(r=>{this.productSupplierCosts=r['value']});
    }

    async getProductTaxes(){
        const filter =[ {
            property: 'ProductId',
            value: this.form.id.value.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
    {
        property: "Tax",
        value: "Name",
        type: 4,
        isTranslated: false
    } as QueryFilter
    ]
        this.productTaxService.getAllFiltered(filter).subscribe(r=>{
            this.productTaxes=r['value'];
        
        });
    }

    async getProductUnits(){
        const filter =[ {
            property: 'ProductId',
            value: this.form.id.value.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "Unit",
            value: "Name,Id",
            type: 4,
            isTranslated: false
        } as QueryFilter
    ]
        this.productUnitService.getAllFiltered(filter).subscribe(r=>{
            this.productUnits=r['value'];
        });
    }

    async getBaseProductBases(productId:number){
        const filter = [{
            property: 'ProductId',
            value: productId.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "Unit",
            value: "Name,Id",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.productUnitService.getAllFiltered(filter).subscribe(r=>{
            this.baseProductUnits=[{id:null,unit:{name:''}}];
            this.baseProductUnits=this.baseProductUnits.concat(r['value']);
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

async getUnits(){
    this.unitService.getAll().subscribe(r=>{this.units=r});
}

async getSuppliers(){
    this.supplierService.getAll().subscribe(r=>{this.suppliers=r});
}
   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name,
                description:this.item.description,
                code:this.item.code,
                currencyId:this.item.currencyId,
                cost:this.item.cost,
                price:this.item.price,
                price2:this.item.price2,
                price3:this.item.price3,
                sellerRate:this.item.sellerRate,
                isService:this.item.isService,
                isCompositeProduct:this.item.isCompositeProduct,
                unitId:0,
                equivalence:0,
                isPrimary:false,
                supplierId:0,
                supplierCost:0,
                baseProductId:0,
                baseUnitId:0,
                quantity:0,
                taxId:0
            });
            this.getProductBases();
            this.getProductSuppliersCosts();
            this.getProductTaxes();
            this.getProductUnits();
           
           
        }
        
        this.validateFormData();
    })
    }
    onChanges(): void {
        this.itemForm.valueChanges.subscribe(val => {
          this.isServiceFlag=val.isService;
          this.isCompositeFlag=val.isCompositeProduct;
          if(this.selectedBaseProduct!=parseInt(val.baseProductId)){
              this.selectedBaseProduct=parseInt(val.baseProductId);
              if(this.selectedBaseProduct>0)
              this.getBaseProductBases(this.selectedBaseProduct);
          }
        });
      }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as Product;
      
           if(!this.item)
           this.item = new Product();
           this.item=  this.updateModel<Product>(formValue,this.item);
           this.item.currencyId=parseInt(this.item.currencyId.toString());
           this.setProductChildren();
          
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/product');
               }
               else
               this.modalService.showError(r.message);
           })
    }
setProductChildren(){
    this.item.taxes=(this.productTaxes);
    this.item.productUnits=(this.productUnits);
    this.item.suppliersCosts=(this.productSupplierCosts);
    this.item.baseCompositeProducts=(this.baseProducts);
  
}
    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/product');
    }

    saveUnit(){
        let currentUnit= {
            id:0,
            productId:parseInt(this.form.id.value.toString()),
            unitId:parseInt( this.form.unitId.value.toString()),
            unit:this.units.find(x=>x.id==this.form.unitId.value),
            equivalence:this.form.isPrimary.value?1:this.form.equivalence.value,
            isPrimary:this.form.isPrimary.value
        };
        if((currentUnit.equivalence<=0 && !currentUnit.isPrimary )|| currentUnit.unitId<=0)
        return;

        if(this.productUnits.length>0 && !this.productUnits.find(x=>x.isPrimary==true) && !currentUnit.isPrimary){
            this.modalService.showError('primaryUnitRequired_msg');
            return;
        }
        if(currentUnit.isPrimary && this.productUnits.findIndex(x=>x.isPrimary==true)>=0){
            const isPrimaryIndex=this.productUnits.findIndex(x=>x.isPrimary==true);
            this.productUnits[isPrimaryIndex].isPrimary=false;
        }   
        let index = this.productUnits.findIndex(x=>x.unitId==currentUnit.unitId);
        
        if(index<0)
        this.productUnits.push(currentUnit);
        else {
            currentUnit.id=this.productUnits[index].id;
            this.productUnits.splice(index,1);
            this.productUnits.push(currentUnit);
        }
    }
    deleteUnit(index:number){
        this.productUnits.splice(index,1);
    }

    saveSupplierCost(){
        let currentCost= {
            id:0,
            productId:parseInt(this.form.id.value.toString()),
            supplierId:parseInt(this.form.supplierId.value.toString()),
            supplier:this.suppliers.find(x=>x.id==this.form.supplierId.value),
            cost:this.form.supplierCost.value
        };
        if(currentCost.cost<=0|| currentCost.supplierId<=0)
        return;

      
        let index = this.productSupplierCosts.findIndex(x=>x.supplierId==currentCost.supplierId);
        
        if(index<0)
        this.productSupplierCosts.push(currentCost);
        else {
           currentCost.id=this.productSupplierCosts[index].id;
            this.productSupplierCosts.splice(index,1);
            this.productSupplierCosts.push(currentCost);
        }
    }
    deleteSupplierCost(index:number){
        this.productSupplierCosts.splice(index,1);
    }


    saveBaseProduct(){
        let currentBaseProduct= {
            id:0,
            productId:parseInt(this.form.id.value.toString()),
            baseProductId:parseInt(this.form.baseProductId.value.toString()),
            baseProduct:this.otherProducts.find(x=>x.id==this.form.baseProductId.value),
            quantity:this.form.quantity.value,
            unitProductEquivalence:this.baseProductUnits.find(x=>x.id==this.form.baseUnitId.value),
            baseProductUnitId:parseInt(this.form.baseUnitId.value)
        };
        
        if(currentBaseProduct.quantity<=0|| currentBaseProduct.baseProductId<=0 || (!currentBaseProduct.baseProduct.isService && currentBaseProduct.baseProductUnitId<=0))
        return;

      
        let index = this.baseProducts.findIndex(x=>x.baseProductId==currentBaseProduct.baseProductId);
        
        if(index<0)
        this.baseProducts.push(currentBaseProduct);
        else {
            currentBaseProduct.id=this.baseProducts[index].id;
            this.baseProducts.splice(index,1);
            this.baseProducts.push(currentBaseProduct);
        }
        this.itemForm.patchValue({
            baseProductId:0,
            baseUnitId:null,
            quantity:0,
            
        })
    }
    deleteBaseProduct(index:number){
        this.baseProducts.splice(index,1);
    }

    saveTax(){
        let currentTax= {
            id:0,
            productId:parseInt(this.form.id.value.toString()),
            taxId:parseInt(this.form.taxId.value.toString()),
            tax:this.taxes.find(x=>x.id==this.form.taxId.value)
        };
        if(currentTax.taxId<=0)
        return;

      
        let index = this.productTaxes.findIndex(x=>x.taxId==currentTax.taxId);
        
        if(index<0)
        this.productTaxes.push(currentTax);
        else {
            currentTax.id=this.productTaxes[index].id;
            this.productTaxes.splice(index,1);
            this.productTaxes.push(currentTax);
        }
    }
    deleteTax(index:number){
        this.productTaxes.splice(index,1);
    }
}