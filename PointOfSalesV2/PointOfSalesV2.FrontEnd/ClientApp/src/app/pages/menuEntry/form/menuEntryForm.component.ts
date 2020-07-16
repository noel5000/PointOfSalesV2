

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
import { Item } from '../../../@core/data/itemModel';


declare const $: any;
@Component({
    selector: "menu-entry-form",
    templateUrl: "./menuEntryForm.component.html",
    styleUrls: ["../menuEntryStyles.component.scss"]
})
export class MenuEntryFormComponent extends BaseComponent implements OnInit {
    itemForm: FormGroup;
    item: any;
    id:number=0;
    _route:ActivatedRoute;
    products:Product[]=[];//
    productUnits:any[]=[];//
    entries:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);
    currentProductCost:any={cost:0};
    menuEntryService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Menu`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productCostService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductCost`);
    oldProductCost:number=0;
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
        private productService:ProductService,
        private modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.Menu);
            this._route=router;
            const weekNumber= parseInt( this._route.snapshot.paramMap.get('id'))>=0?parseInt( this._route.snapshot.paramMap.get('id')):null;
            const dayOfWeek =parseInt( this._route.snapshot.paramMap.get('id1'))>0?parseInt( this._route.snapshot.paramMap.get('id1')):null;
            if((weekNumber || weekNumber>=0) && dayOfWeek){
                this.getCurrentMenu(weekNumber,dayOfWeek);
            }
        this.itemForm = this.formBuilder.group({
id: [0],
weekNumber:[weekNumber,[ Validators.required,Validators.min(0), Validators.max(4)]],
dayOfWeek:[dayOfWeek,[ Validators.required,Validators.min(1), Validators.max(5)]],
productId:[null,[ Validators.required,Validators.min(1)]],
unitId:this.defaultUnitValidator,
currencyCode:[''],
quantity:[0,[ Validators.required,Validators.min(0.0001)]],
productCost:[0],
beforeTaxesAmount:[0],
noTaxes:[false],
taxAmount:[0],
totalAmount:[0],
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
            this.productUnits=[{id:0, unitId:0,unit:{id:0, name:''}}];
            this.productUnits=this.productUnits.concat( r['value']);
        });
    }

    async GetProductCost(productId:number){
        const currentProduct = this.products.find(x=>x.id==productId);
        this.currentProductCost.cost=currentProduct.cost;
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
               if( product.isService){
                this.itemForm.removeControl('unitId');
                this.itemForm.addControl('unitId', new FormControl(null))
               }
               else{
                this.itemForm.removeControl('unitId');
                this.itemForm.addControl('unitId',this.defaultUnitValidator)   
                this.GetProductUnits(val);
            }
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
        const form = this.itemForm.getRawValue() as any;
           const ToSave ={
               weekNumber:form.weekNumber,
               dayOfWeek:form.dayOfWeek,
               menuDetails:this.entries
           }
          
            const subscription =this.menuEntryService.post(ToSave,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl('pages/menuentry');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
    this.router.navigateByUrl('pages/menuentry');
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
    getCurrentMenu(weekNumber:number,dayOfWeek:number){
        this.menuEntryService.getByUrlParameters(["GetMenu",weekNumber.toString(),dayOfWeek.toString()])
        .subscribe(r=>{
            this.entries=r.data[0] && r.data[0].days?r.data[0].days[0].menuDetails:[];
        })
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