

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
    selector: "invoice-print",
    templateUrl: "./invoicePrint.component.html",
    styleUrls: ["../invoiceStyles.component.scss"]
})
export class InvoicePrintComponent extends BaseComponent implements OnInit {
   
    item: any={invoiceLeads:[],customer:{},currency:{},invoiceNumber:''};
  
    showColumns:any={};
    Id:number=0;
    sequence:string='';
    _route:ActivatedRoute;
    invoicesService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Invoice`);
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
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.Invoices,modalService);
            this._route=router;
            this.Id=parseInt( this._route.snapshot.paramMap.get('id'))>0?parseInt( this._route.snapshot.paramMap.get('id')):0;
            this.getCurrent();
 
            

    }
    ngOnInit(): void {
   
        this.verifyUser();
       
    }


 

    getCurrent(){
        this.invoicesService.getByUrlParameters(['GetForPrint',this.Id.toString()])
        .subscribe(r=>{
            
            if(r.status>=0){
              
               this.item=r.data[0];
            }
            else
            this.modalService.showError(r.message);
        })
    }

   
}