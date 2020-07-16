

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { UnitService } from '../../../@core/services/UnitService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Unit } from '../../../@core/data/unitModel';


declare const $: any;
@Component({
    selector: "unit-form",
    templateUrl: "./unitForm.component.html",
    styleUrls: ["../unitStyles.component.scss"]
})
export class UnitFormComponent extends BaseComponent implements OnInit {
    itemForm: FormGroup;
    item: Unit;
    id:number=0;
    _route:ActivatedRoute;

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: UnitService,
        private modals:NgbModal,
        private modalService:ModalService
        ){
           
            super(route, langService, AppSections.Units);
            this._route=router;
            this.section=AppSections.Units;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(50)]],
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
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name
            });

        }
    })
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as Unit;
      
           if(!this.item)
           this.item = new Unit();

        this.item = this.updateModel<Unit>(formValue,this.item);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl('pages/unit');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
    this.router.navigateByUrl('pages/unit');
    }
}