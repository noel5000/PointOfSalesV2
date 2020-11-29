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


declare const $: any;
@Component({
    selector: "accounst-receivable-report",
    templateUrl: "./accountsReceivableIndex.component.html",
    styleUrls: ["../accountsReceivableStyles.component.scss"]
})
export class AccountsReceivableIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getBranchOffices();
        this.getCustomers();
        this.onChanges();
        this.getData();
    }
    modalRef:NgbModalRef=null;
  service: BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}Invoice`);
    invoices:any[]=[];
    branchOffices:BranchOffice[]=[];
    customers:Customer[]=[];


    constructor(
        route: Router,
        private formBuilder: FormBuilder,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService,
        private customersService:CustomerService,
        private branchOfficeService: BranchOfficeService
    ) {
        super(route, langService, AppSections.AccountsReceivable,modalService);
        this.itemForm = this.formBuilder.group({
       branchOfficeId:[0],
       customerId:[0],
       startDate:[''],
       endDate:['']
        });
    }
 
 
onChanges(){
    this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
            this.getData();
    });
    this.itemForm.get('customerId').valueChanges.subscribe(val => {
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
        this.service.getGenericByUrlParameters(['GetAccountReceivables',filter.branchOfficeId.toString(),filter.customerId.toString(),"0",
        filter.startDate? filter.startDate.toString():'0',filter.endDate?filter.endDate.toString():'0',]).subscribe(r => {
            this.invoices=r['data'];
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }

    getCustomers(){
        this.customersService.getAll().subscribe(r=>{
            this.customers=[{id:0,name:this.lang.getValueByKey('all_lbl')} as Customer];
            this.customers=this.customers.concat(r);
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
        this.service.exportToExcel(filter,`ExportAccountReceivables/${filter.branchOfficeId}/${filter.customerId}/0/${filter.startDate? filter.startDate.toString():'0'}/${filter.endDate?filter.endDate.toString():'0'}`).subscribe(r => {

          this.service.downLoadFile(r,"application/ms-excel",`${this.lang.getValueByKey('accountsReceivable_menu')}`);
          
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