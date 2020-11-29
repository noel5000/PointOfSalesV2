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


declare const $: any;
@Component({
    selector: "warehouse-movement-report",
    templateUrl: "./warehouseMovementReportIndex.component.html",
    styleUrls: ["../warehouseMovementReportStyles.component.scss"]
})
export class WarehouseMovementReportIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getBranchOffices();
        this.getProducts();
        this.onChanges();
        this.getData();
    }
    modalRef:NgbModalRef=null;
  service: BaseService<any,number>= new BaseService<any,number>(this.http,`${endpointUrl}WarehouseMovement`);
    movements:any[]=[];
    branchOffices:BranchOffice[]=[];
    warehouses:Warehouse[]=[];
    products:Product[]=[];


    constructor(
        route: Router,
        private formBuilder: FormBuilder,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService,
        private productsService:ProductService,
        private warehouseServie:WarehouseService,
        private branchOfficeService: BranchOfficeService
    ) {
        super(route, langService, AppSections.Inventories,modalService);
        this.itemForm = this.formBuilder.group({
       branchOfficeId:[0],
       warehouseId:[0],
       productId:[0]
        });
    }

 
onChanges(){
    this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
                   
        if(val && val>0){
            
            this.getWarehouses(val);this.getData();
            this.getData();
        }
            else
            {
                this.itemForm.patchValue({warehouseId:0});
                 this.warehouses=[{id:0, name:this.lang.getValueByKey('all_lbl')} as Warehouse]
            }
    
    });
    this.itemForm.get('warehouseId').valueChanges.subscribe(val => {
                   
        this.getData();
    
    });
    this.itemForm.get('productId').valueChanges.subscribe(val => {
                   
        this.getData();
    
    });
}
    getData() {
        const filter = this.itemForm.getRawValue();
        this.service.getGenericByUrlParameters(['GetProductMovements',filter.branchOfficeId.toString(),filter.warehouseId.toString(),filter.productId.toString(),'*']).subscribe(r => {

           
            this.movements=r['data'];
          
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }

    getProducts(){
        this.productsService.getAll().subscribe(r=>{
            this.products=[{id:0,name:this.lang.getValueByKey('all_lbl')} as Product];
            this.products=this.products.concat(r);
        })
    }

    getWarehouses(branchOfficeId:number)
    {
        const filter={
            property: 'BranchOfficeId',
            value: branchOfficeId.toString(),
            type: ObjectTypes.Number
        } as QueryFilter
        this.warehouseServie.getAllFiltered([filter]).subscribe(r=>{
            this.warehouses=[{id:0,name:this.lang.getValueByKey('all_lbl')} as Warehouse];
            this.warehouses=this.warehouses.concat(r['value']);
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
        this.service.exportToExcel(filter,`ExportToExcel/${filter.branchOfficeId}/${filter.branchOfficeId}/${filter.productId}/*`).subscribe(r => {

          this.service.downLoadFile(r,"application/ms-excel",`${this.lang.getValueByKey('productsMovements_menu')}`);
          
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