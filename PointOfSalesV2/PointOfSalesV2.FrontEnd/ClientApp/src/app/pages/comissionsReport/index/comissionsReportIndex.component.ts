import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Product } from '../../../@core/data/product';
import { ProductService } from '../../../@core/services/ProductService';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { Warehouse } from '../../../@core/data/Warehouse';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customer } from '../../../@core/data/customer';
import { CustomerService } from '../../../@core/services/CustomerService';
import { Currency } from '../../../@core/data/currencyModel';
import { Seller } from '../../../@core/data/seller';
import { SellerService } from '../../../@core/services/SellerService';
import { CurrencyService } from '../../../@core/services/CurrencyService';


declare const $: any;
@Component({
    selector: "comission-report",
    templateUrl: "./comissionsReportIndex.component.html",
    styleUrls: ["../comissionsReportStyles.component.scss"]
})
export class ComissionsReportIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.onChanges();
        this.getCurrencies();
        this.getCustomers();
        this.getSellers();
    }
    modalRef:NgbModalRef=null;
  service: BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}Seller`);
    result:any[]=[];
    currencies:Currency[]=[];
    customers:Customer[]=[];
    sellers:Seller[]=[];
    reportTypes:any[]=[
        {id:0, name:this.lang.getValueByKey('salesComission_lbl')},
        {id:1, name:this.lang.getValueByKey('paymentsComission_lbl')}
    ];


    constructor(
        route: Router,
        private formBuilder: FormBuilder,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService,
        private sellerService:SellerService,
        private currencyService:CurrencyService,
        private customerService:CustomerService
    ) {
        super(route, langService, AppSections.TaxesReport,modalService);
        this.itemForm = this.formBuilder.group({
       startDate:[''],
       endDate:[''],
       customerId:[null],
       sellerId:[null],
       currencyId:[null],
       reportType:[0]
        });
    }

 
onChanges(){
    
    this.itemForm.get('startDate').valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('sellerId').valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('customerId').valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('currencyId').valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('reportType').valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('endDate').valueChanges.subscribe(val => {
        this.getData();
    });
}
async  getData() {
        const filter = this.itemForm.getRawValue();
        this.service.post(filter,"","GetComissionsReport").subscribe(r => {
            this.result=r['data'];
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }

    async   getSellers() {
       
        this.sellerService.getAll().subscribe(r => {
            this.sellers=r;
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }

    async getCurrencies() {
       
        this.currencyService.getAll().subscribe(r => {
            this.currencies=r;
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }

   async getCustomers() {
       
        this.customerService.getAll().subscribe(r => {
            this.customers=r;
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }


  


    
 async   getDataToExport() {
        const filter = this.itemForm.getRawValue();
        this.service.exportToExcel(filter,`ExportComissionsReport`).subscribe(r => {

          this.service.downLoadFile(r,"application/ms-excel",`${this.lang.getValueByKey('commissions_menu')}`);
          
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }



 print(){
    window.print();
}

exportToCSV(){
   this.getDataToExport(); 
}

}