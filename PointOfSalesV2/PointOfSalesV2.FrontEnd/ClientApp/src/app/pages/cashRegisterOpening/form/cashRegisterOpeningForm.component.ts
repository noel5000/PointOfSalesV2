

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';
import { User } from '../../../@core/data/users';
import { CashRegister } from '../../../@core/data/cashRegister';
import { Currency } from '../../../@core/data/currencyModel';
import { CashRegisterService } from '../../../@core/services/CashRegisterService';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { CashRegisterOpening, OpeningType } from '../../../@core/data/cashRegisterOpening';
import { UserService } from '../../../@core/services/UserService';



declare const $: any;
@Component({
    selector: "cash-register-opening-form",
    templateUrl: "./cashRegisterOpeningForm.component.html",
    styleUrls: ["../cashRegisterOpeningStyles.component.scss"]
})
export class CashRegisterOpeningFormComponent extends BaseComponent implements OnInit {


    details:OpeningType[]=[];
    user:User;
    currentCurrency:Currency=null;
    isClosing:boolean =false;
    service:BaseService<CashRegisterOpening,number>=new BaseService<CashRegisterOpening,number>(this.http, `${endpointUrl}CashRegisterOpening`);
    closureService:BaseService<CashRegisterOpening,number>=new BaseService<CashRegisterOpening,number>(this.http, `${endpointUrl}CashRegisterOpening/CloseCashRegister`);
    detailsService:BaseService<any,number>=new BaseService<any,number>(this.http, `${endpointUrl}CashRegisterOpeningDetail`);
    _route:ActivatedRoute;
    branchOffices:BranchOffice[]=[];
    users:User[]=[];
    cashRegisters:CashRegister[]=[];
    typeId:string='';
    currencies:Currency[]=[];
    types:any[]=[
        {
            id:'cash',
            name:this.lang.getValueByKey('cash_lbl')
        },
        {
            id:'check',
            name:this.lang.getValueByKey('check_lbl')
        },
        {
            id:'creditCard',
            name:this.lang.getValueByKey('creditCard_lbl')
        }
    ];
    openingAmounts:any[]=[
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 1`:'',
            amount:1,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 5`:'',
            amount:5,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 10`:'',
            amount:10,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 20`:'',
            amount:20,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 50`:'',
            amount:50,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 100`:'',
            amount:100,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 200`:'',
            amount:200,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 500`:'',
            amount:500,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 1000`:'',
            amount:1000,
            quantity:0
        },
        {
            amountText:this.currentCurrency?`${this.currentCurrency.code}$ 2000`:'',
            amount:2000,
            quantity:0
        }
    ];

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        private  http: HttpClient,
        langService: LanguageService,
        private currencyService:CurrencyService,
        private cashRegisterService:CashRegisterService,
        private userService:UserService,
        private modals:NgbModal,
        private branchOfficeService: BranchOfficeService,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.CashRegisterOpenings,modalService);
            this._route=router;
            this.dataToBackup="details,cashRegisters,branchOffices,users";
        this.itemForm = this.formBuilder.group({
            branchOfficeId: [0,[Validators.required,Validators.min(1)]],
            userId: ['',[Validators.required]],
            type: [''],
            cashRegisterId: [0,[Validators.required,Validators.min(1)]],
            currencyId: [0,[Validators.required,Validators.min(1)]],
            amount: [0],
            id: [0],

        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        this.id=urlId;
       this.isClosing= window.location.href.indexOf('/close')>=0
        this.getItem(urlId);
     }
        this.verifyUser();
        this.getBranchOffices();
        this.getCurrencies();
        this.onChanges();
    }

    onChanges(): void {
        this.itemForm.valueChanges.subscribe(val => {
          this.typeId=val.type;
          if(!isNaN(val.branchOfficeId)){
            const id=parseInt(val.branchOfficeId);
            if(id>0 &&(!this.user || this.user.branchOfficeId!=id)){
                
      this.getCashRegisters(id);
      this.getUsers(id);
            }
        }
        if(val.userId){
            this.user= this.users.find(x=>x.userId==val.userId);
            if(this.user && this.user.cashRegister){
                this.itemForm.patchValue({cashRegisterId:this.user.cashRegisterId});
            }
        }
        if(!isNaN(val.currencyId) && parseInt(val.currencyId)>0){
            const id=parseInt(val.currencyId);
            const currency =(!this.currentCurrency || this.currentCurrency.id!=id) && this.currencies.length>0?
             this.currencies.find(x=>x.id==id):this.currentCurrency;
            this.currentCurrency=currency;
          
        }
        else
        this.currentCurrency=null;
        });
      }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.getCashRegisters(this.item.branchOfficeId);
            this.getUsers(this.item.branchOfficeId);
            this.itemForm.patchValue(this.item);
            this.getDetails(this.item.id);
            this.currentCurrency= this.currencies.length>0? this.currencies.find(x=>x.id==this.item.currencyId):this.currentCurrency;
        }
        
        this.validateFormData();
    })
    }

    async getDetails(id:number){
        this.detailsService.getAllFiltered([
            {
                property: "CashRegisterOpeningId",
                value: id.toString(),
                type: ObjectTypes.Number,
                isTranslated: false
            } as QueryFilter
        ]).subscribe(r=>{
          
                this.details=r['value'];
               
                const cashIndex = this.details.findIndex(x=>x.type=='cash' && x.isClosing==false);
                if(cashIndex>=0){
                    const savedOpenings=JSON.parse(this.details[cashIndex].details);
                    if(!this.isClosing)
                    savedOpenings.forEach(e=>{
                        let index = this.openingAmounts.findIndex(x=>x.amount==e.amount);
                        if(index>=0)
                        this.openingAmounts[index].quantity=e.quantity;
                    });
                }
            
        })
        }
    setBranchOffice(branchOffice: BranchOffice){
        this.itemForm.patchValue({branchOfficeId:branchOffice.id});
    }
    async getBranchOffices (){
        this.branchOfficeService.getAll().subscribe(r=>{
            this.branchOffices=r;
        })
    }
    async getCurrencies (){
        this,this.currencyService.getAll().subscribe(r=>{
            this.currencies=r;
            const currencyId = this.itemForm.value.currencyId;
            if(currencyId && !isNaN(currencyId)){
                this.currentCurrency=this.currencies.find(x=>x.id==currencyId);
            }
        })
    }

    async getCashRegisters (branchId:number){
        this,this.cashRegisterService.getAllFiltered(
            [
                {
                    property: "BranchOfficeId",
                    value: branchId.toString(),
                    type: ObjectTypes.Number,
                    isTranslated: false
                } as QueryFilter
            ]
        ).subscribe(r=>{
            this.cashRegisters=[{id:0, name:''} as CashRegister];
            this.cashRegisters=this.cashRegisters.concat( r['value']);
        })
    }
    async getUsers (branchId:number){
        this,this.userService.getAllFiltered(
            [
                {
                    property: "BranchOfficeId",
                    value: branchId.toString(),
                    type: ObjectTypes.Number,
                    isTranslated: false
                } as QueryFilter
            ]
        ).subscribe(r=>{
            this.users=r['value'];
        })
    }

    addOpening(){
        const formValue = this.itemForm.value;
        let toSave=null;
        if(formValue.type){
            switch(formValue.type){
            case 'check':
            case 'creditCard':
                toSave = {
                    isClosing:this.isClosing,
                    type:formValue.
                    type,
                    details:JSON.stringify({amount:formValue.amount}),
                    totalAmount:formValue.amount
                } as OpeningType;
             
            break;
            case 'cash':
                const cashEntries = this.openingAmounts.filter(x=>x.quantity>0);
                if(cashEntries.length>0){
                    let total=0;
                    cashEntries.forEach(e=>{
                        total+=(e.amount * e.quantity);
                    });
                    toSave = {
                        isClosing:this.isClosing,
                        type:formValue.type,
                        details:JSON.stringify(cashEntries),
                        totalAmount:total
                    } as OpeningType;
                }
                break;
            }
            if(toSave){
                if(toSave.totalAmount>0){
                    const index = this.details.findIndex(x=>x.type==toSave.type && x.isClosing==toSave.isClosing);
                    if(index>=0){
                        this.details.splice(index,1);
                        this.details.push(toSave)
                    }
                    else
                    this.details.push(toSave);
                }
            }
        }
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid || this.details.length==0) {
            return;
        }
       const formValue = this.itemForm.value as CashRegisterOpening;
      
           if(!this.item)
           this.item = new CashRegisterOpening();

           this.item = this.updateModel<CashRegisterOpening>(formValue,this.item);
           this.item.branchOfficeId= parseInt(this.item.branchOfficeId.toString());
           this.item.cashRegisterId= parseInt(this.item.cashRegisterId.toString());
           this.item.currencyId= parseInt(this.item.currencyId.toString());
           this.item.isClosing =this.isClosing;
          this.item.details=this.details;
            const subscription =this.isClosing?this.closureService.put(this.item): this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/cashregisteropening');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
    this.clearBackupData();
    this.router.navigateByUrl('pages/cashregisteropening');
    }
}