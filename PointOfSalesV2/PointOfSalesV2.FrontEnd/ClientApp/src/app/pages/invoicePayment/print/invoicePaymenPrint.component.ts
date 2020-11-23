

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
    selector: "invoice-payment-print",
    templateUrl: "./invoicePaymentPrint.component.html",
    styleUrls: ["../invoicePaymentStyles.component.scss"]
})
export class InvoicePaymentPrintComponent extends BaseComponent implements OnInit {
   
    item: any={customer:{},currency:{},invoiceNumber:'',sequence:''};
  
    showColumns:any={};
    sequence:string='';
    paidInvoices:any[]=[];
    _route:ActivatedRoute;
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}CustomerPayment`);


    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
       modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.CustomerPayments,modalService);
            this._route=router;
            this.sequence= this._route.snapshot.paramMap.get('sequence');
            this.getCurrent();
 
            

    }
    ngOnInit(): void {
   
        this.verifyUser();
       
    }


 

    getCurrent(){
        this.service.getByUrlParameters(['GetForPrint',this.sequence])
        .subscribe(r=>{
            
            if(r.status>=0){
              
               this.item=r.data[0];
               this.paidInvoices=this.item.paidInvoices;
            }
            else
            this.modalService.showError(r.message);
        })
    }

   
}