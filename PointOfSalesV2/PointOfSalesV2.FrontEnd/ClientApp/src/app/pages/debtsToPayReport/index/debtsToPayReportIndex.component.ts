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
import { SupplierService } from '../../../@core/services/supplierService';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { Supplier } from '../../../@core/data/Supplier';


declare const $: any;
@Component({
    selector: "debts-pay-report",
    templateUrl: "./debtsToPayReportIndex.component.html",
    styleUrls: ["../debtsToPayReportStyles.component.scss"]
})
export class DebtsToPayReportIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getBranchOffices();
        this.getSuppliers();
        this.getCurrencies();
        this.onChanges();
        this.getData();
    }
    modalRef:NgbModalRef=null;
  service: BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}Expense`);
    expenses:any[]=[];
    branchOffices:BranchOffice[]=[];
    suppliers:Supplier[]=[];
    currencies:Currency[]=[];


    constructor(
        route: Router,
        private formBuilder: FormBuilder,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService,
        private suppliersService:SupplierService,
        private currenciesService:CurrencyService,
        private branchOfficeService: BranchOfficeService
    ) {
        super(route, langService, AppSections.DebstToPay,modalService);
        this.itemForm = this.formBuilder.group({
       branchOfficeId:[0],
       supplierId:[0],
       currencyId:[0],
       startDate:[''],
       endDate:['']
        });
    }

 
onChanges(){
    this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
            this.getData();
    });
    this.itemForm.get('supplierId').valueChanges.subscribe(val => {
        this.getData();    
    });
    this.itemForm.get('currencyId').valueChanges.subscribe(val => {
        this.getData();    
    });
    this.itemForm.get('startDate').valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('endDate').valueChanges.subscribe(val => {
        this.getData();
    });
}
    getData() {
        const filter = this.itemForm.getRawValue();
        this.service.post({
            currencyId:filter.currencyId,
            branchOfficeId:filter.branchOfficeId,
            supplierId:filter.supplierId,
            startDate:filter.startDate?filter.startDate:null,
            endDate:filter.endDate?filter.endDate:null,
        },null,'GetOwedExpenses').subscribe(r => {
            this.expenses=r['data'];
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }

    getSuppliers(){
        this.suppliersService.getAll().subscribe(r=>{
            this.suppliers=[{id:0,name:this.lang.getValueByKey('all_lbl')} as Supplier];
            this.suppliers=this.suppliers.concat(r);
        })
    }

    getCurrencies(){
        this.currenciesService.getAll().subscribe(r=>{
            this.currencies=[{id:0,name:this.lang.getValueByKey('all_lbl')} as Currency];
            this.currencies=this.currencies.concat(r);
        })
    }

  

    getBranchOffices(){
        this.branchOfficeService.getAll().subscribe(r=>{
            this.branchOffices=[{id:0,name:this.lang.getValueByKey('all_lbl')} as BranchOffice];
            this.branchOffices=this.branchOffices.concat(r);
        })
    }

    
    getDataToExport() {
        const filter = this.itemForm.getRawValue();
        this.service.exportToExcel(filter,`GetOwedExpensesReport/${filter.branchOfficeId}/${filter.supplierId}/${filter.currencyId}/${filter.startDate? filter.startDate.toString():'0'}/${filter.endDate?filter.endDate.toString():'0'}`).subscribe(r => {

          this.service.downLoadFile(r,"application/ms-excel",`${this.lang.getValueByKey('debtsToPay_menu')}`);
          
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