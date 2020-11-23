

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ZoneService } from '../../../@core/services/zoneService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Zone } from '../../../@core/data/zoneModel';
import { ThrowStmt } from '@angular/compiler';


declare const $: any;
@Component({
    selector: "zone-form",
    templateUrl: "./zoneForm.component.html",
    styleUrls: ["../zoneStyles.component.scss"]
})
export class ZoneFormComponent extends BaseComponent implements OnInit {

    _route:ActivatedRoute;
    tempSector:string='';
    sectors:string[]=[];

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: ZoneService,
        private modals:NgbModal,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.Zones,modalService);
            this._route=router;
            this.dataToBackup="sectors,tempSectors";
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(100)]],
            id: [0],
            sector:['']
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

        this.verifyUser();
    }

    addSector(){
        const toAdd= this.itemForm.value.sector;
        if(toAdd){
            const index = this.sectors.findIndex(x=>x.toLowerCase()==toAdd.toLowerCase());
            if(index>=0){
                this.sectors.splice(index,1);
                this.sectors.push(toAdd)
            }
            else{
                this.sectors.push(toAdd);
                this.itemForm.patchValue({sector:''});
            }
            
        }
    }

    deleteSector(sector:string){
        const index = this.sectors.findIndex(x=>x.toLowerCase()==sector.toLowerCase());
        if(index>=0){
            this.sectors.splice(index,1);
        }
       
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name
            });
            this.sectors=this.item.details?JSON.parse(this.item.details):[];
        }
        this.validateFormData();
    })
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as Zone;
      
           if(!this.item)
           this.item = new Zone();
           this.item = this.updateModel<Zone>(formValue,this.item);
           this.item.details= JSON.stringify(this.sectors);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/zone');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/zone');
    }
}