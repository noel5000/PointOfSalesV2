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
    selector: "tax-report",
    templateUrl: "./taxesReportIndex.component.html",
    styleUrls: ["../taxesReportStyles.component.scss"]
})
export class TaxReportIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.onChanges();
    }
    modalRef:NgbModalRef=null;
  service: BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}InvoiceTax`);
    result:any[]=[];


    constructor(
        route: Router,
        private formBuilder: FormBuilder,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService,
    ) {
        super(route, langService, AppSections.TaxesReport,modalService);
        this.itemForm = this.formBuilder.group({
       startDate:[''],
       endDate:['']
        });
    }

 
onChanges(){
    
    this.itemForm.get('startDate').valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('endDate').valueChanges.subscribe(val => {
        this.getData();
    });
}
    getData() {
        const filter = this.itemForm.getRawValue();
        this.service.getGenericByUrlParameters(['GetTaxesReport',filter.startDate? filter.startDate.toString():'0',filter.endDate?filter.endDate.toString():'0',]).subscribe(r => {
            this.result=r['data'];
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }


  


    
    getDataToExport() {
        const filter = this.itemForm.getRawValue();
        this.service.exportToExcel(filter,`GetTaxesReportExcel/${filter.startDate? filter.startDate.toString():'0'}/${filter.endDate?filter.endDate.toString():'0'}`).subscribe(r => {

          this.service.downLoadFile(r,"application/ms-excel",`${this.lang.getValueByKey('taxesReport_menu')}`);
          
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