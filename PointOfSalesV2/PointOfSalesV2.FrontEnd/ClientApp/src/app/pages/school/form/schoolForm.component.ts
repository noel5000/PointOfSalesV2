

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { SchoolService } from '../../../@core/services/SchoolService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter, ODataComparers } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { School, SchoolContact } from '../../../@core/data/school';
import { ZoneService } from '../../../@core/services/zoneService';
import { Zone } from '../../../@core/data/zoneModel';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { Customer } from '../../../@core/data/customer';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { Warehouse } from '../../../@core/data/Warehouse';
import { CustomerService } from '../../../@core/services/CustomerService';
import { WarehouseService } from '../../../@core/services/WarehouseService';


declare const $: any;
@Component({
    selector: "school-form",
    templateUrl: "./schoolForm.component.html",
    styleUrls: ["../schoolStyles.component.scss"]
})
export class SchoolFormComponent extends BaseComponent implements OnInit {
    itemForm: FormGroup;
    item: School;
    contacts:SchoolContact[]=[];
    id:number=0;
    branchOffices:BranchOffice[]=[];
    customers:Customer[]=[];
    warehouses:Warehouse[]=[];
    _route:ActivatedRoute;
    contactInfoRequired:boolean=false;
    zones:Zone[]=[];
    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private zoneService:ZoneService,
        private branchOfficeService:BranchOfficeService,
        private customerService:CustomerService,
        private warehouseService:WarehouseService,
        private service: SchoolService,
        private modals:NgbModal,
        private modalService:ModalService
        ){
           
            super(route, langService, AppSections.School);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            phoneNumber: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            address: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(200)]],
            code: [''],
            customerId: [null,[ Validators.required,Validators.min(1)]],
            currencyId:[0],
            zoneId: [null],
            branchOfficeId: [null],
            assignedWarehouseId: [null],
            leadDueDays: [0],
            contactName: [''],
            contactPhoneNumber: [''],
            position:[''],
            id: [0]
        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        this.id=urlId;
        this.getItem(urlId);
     }
        this.verifyUser();
        this.getZones();
        this.getBranchOffices();
        this.getCustomers();
        this.onChanges();
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.contacts=this.item.contacts?this.item.contacts:[];
            this.itemForm.patchValue({
                name: this.item.name,
                phoneNumber: this.item.phoneNumber,
                address:this.item.address,
                code: this.item.code,
                customerId:this.item.customerId,
                currencyId:this.item.currencyId,
                zoneId: this.item.zoneId,
                branchOfficeId: this.item.branchOfficeId,
                assignedWarehouseId: this.item.assignedWarehouseId,
                leadDueDays: this.item.leadDueDays,
                contactName: [''],
                contactPhoneNumber: [''],
                position:[''],
                id: this.item.id
            });
            if(this.item.branchOfficeId)
            this.getWarehouses(this.item.branchOfficeId);
        }
    })
    }

    async getZones(){
        this.zoneService.getAll().subscribe(r=>{this.zones=r})
    }

    async getBranchOffices(){
        this.branchOfficeService.getAll().subscribe(r=>{
            this.branchOffices=r;
            if(this.branchOffices.length==1)
            this.itemForm.patchValue({branchOfficeId:this.branchOffices[0].id});
        })
    }

    async getCustomers(){
        this.customerService.getAll().subscribe(r=>{
            this.customers=r;
            if(this.customers.length==1)
            this.itemForm.patchValue({customerId:this.customers[0].id});
        
        })
    }

    async getWarehouses(id:number){
        const filter = [{
            property: 'BranchOfficeId',
            value: id.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: 'Code',
            value: 'DEF',
            type: ObjectTypes.String,
            isTranslated:false,
            comparer: ODataComparers.NotEqual
        } as QueryFilter
    ]
        this.warehouseService.getAllFiltered(filter).subscribe(r=>{
            this.warehouses=[{id:0,name:''} as Warehouse];
            this.warehouses=this.warehouses.concat( r['value']);
        });
    }
    
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as School;
      
           if(!this.item)
           this.item = new School();
           this.item=  this.updateModel<School>(formValue,this.item);
           this.item.customerId=parseInt(this.item.customerId.toString());
           this.item.zoneId=this.item.zoneId?parseInt(this.item.zoneId.toString()):null;
           this.item.branchOfficeId=this.item.branchOfficeId?parseInt(this.item.branchOfficeId.toString()):null;
           this.item.assignedWarehouseId=this.item.assignedWarehouseId?parseInt(this.item.assignedWarehouseId.toString()):null;
           this.item.contacts=this.contacts;
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl('pages/school');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    onChanges(): void {
        this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
        if(val)
        this.getWarehouses(val);
        });
     
           
      }

    cancel(){
    this.router.navigateByUrl('pages/school');
    }

    addContact(){
        const {contactName,contactPhoneNumber,position} = this.itemForm.getRawValue();
        if(contactName && contactPhoneNumber && position){
            this.contactInfoRequired=false;
            const index =this.contacts.findIndex(x=>x.name.toLowerCase()==contactName.toLowerCase());
            if(index<0){
                this.contacts.push({name:contactName,phoneNumber:contactPhoneNumber, position} as SchoolContact);
            }
            else{
                this.contacts.splice(index,1);
                this.contacts.push({name:contactName,phoneNumber:contactPhoneNumber, position} as SchoolContact);
            }
            this.itemForm.patchValue({contactName:'',contactPhoneNumber:'',position:''});
        }
        else
        this.contactInfoRequired=true;
    }
    deleteContact(index:number){
        this.contacts.splice(index,1);
    }
}