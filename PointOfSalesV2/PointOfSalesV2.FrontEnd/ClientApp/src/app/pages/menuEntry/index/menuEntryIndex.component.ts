import { Component, OnInit, ViewChild } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';
import { Item } from '../../../@core/data/itemModel';
import { MatMenuTrigger } from '@angular/material';


declare const $: any;
@Component({
    selector: "menu-entry-list",
    templateUrl: "./menuEntryIndex.component.html",
    styleUrls: ["../menuEntryStyles.component.scss"]
})
export class MenuEntryIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getData();
    }
    @ViewChild(MatMenuTrigger,{static:false})
    contextMenu: MatMenuTrigger;
    contextMenuPosition = { x: '0px', y: '0px' };
    modalRef:NgbModalRef=null;
    MenuEntries:any[]=[
        {
            weekNumber:0,
            days:[
            {
                dayOfWeek:1,
                menuDetails:[]
            },
            {
                dayOfWeek:2,
                menuDetails:[]
            },
            {
                dayOfWeek:3,
                menuDetails:[]
            },
            {
                dayOfWeek:4,
                menuDetails:[]
            },
            {
                dayOfWeek:5,
                menuDetails:[]
            },
        ]
    },
    {
        weekNumber:1,
        days:[
        {
            dayOfWeek:1,
            menuDetails:[]
        },
        {
            dayOfWeek:2,
            menuDetails:[]
        },
        {
            dayOfWeek:3,
            menuDetails:[]
        },
        {
            dayOfWeek:4,
            menuDetails:[]
        },
        {
            dayOfWeek:5,
            menuDetails:[]
        },
    ]
},
{
    weekNumber:2,
    days:[
    {
        dayOfWeek:1,
        menuDetails:[]
    },
    {
        dayOfWeek:2,
        menuDetails:[]
    },
    {
        dayOfWeek:3,
        menuDetails:[]
    },
    {
        dayOfWeek:4,
        menuDetails:[]
    },
    {
        dayOfWeek:5,
        menuDetails:[]
    },
]
},
{
    weekNumber:3,
    days:[
    {
        dayOfWeek:1,
        menuDetails:[]
    },
    {
        dayOfWeek:2,
        menuDetails:[]
    },
    {
        dayOfWeek:3,
        menuDetails:[]
    },
    {
        dayOfWeek:4,
        menuDetails:[]
    },
    {
        dayOfWeek:5,
        menuDetails:[]
    },
]
},
{
    weekNumber:4,
    days:[
    {
        dayOfWeek:1,
        menuDetails:[]
    },
    {
        dayOfWeek:2,
        menuDetails:[]
    },
    {
        dayOfWeek:3,
        menuDetails:[]
    },
    {
        dayOfWeek:4,
        menuDetails:[]
    },
    {
        dayOfWeek:5,
        menuDetails:[]
    },
]
},
    ];
    monthRef:Item={id:0,name:'month'}
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Menu`);

    constructor(
        route: Router,
        private  http: HttpClient,
        langService: LanguageService,
        private modals:NgbModal,
        private modalService:ModalService
    ) {
        super(route, langService, AppSections.Menu);
        let scope = this;
       

    }
    setItem(name:string,id:number){
        let dayWithChildren=false;
        const idsArr=`${name}_${id}`.split('_');
        const isDay = idsArr.length>2;
        if(isDay)
        {
            const selectectWeek= this.MenuEntries.find(x=>x.weekNumber==idsArr[1]);
            if(selectectWeek)
            {
                 dayWithChildren = selectectWeek.days.find(d=>d.dayOfWeek==idsArr[2]).menuDetails.length>0;
            }
        }

        return {id:id, name:`${name}_${id}`, hasChildren:dayWithChildren} as Item;
    }

    onContextMenu(event: MouseEvent, itemid: string) {
        const itemValues= itemid.split(',');
        const item = this.setItem(itemValues[1],parseInt(itemValues[0]));
        event.preventDefault();
        this.contextMenuPosition.x = event.clientX + 'px';
        this.contextMenuPosition.y = event.clientY + 'px';
        this.contextMenu.menuData = { 'item': item };
        this.contextMenu.menu.focusFirstItem('mouse');
        this.contextMenu.openMenu();
      }
    
      addButtonAction(item: Item) {
       const ids = this.getDayAndWeekFromItem(item);
       this.router.navigateByUrl(`pages/menuentry/add/${ids[0]}/${ids[1]}`);

      }
      deleteButtonAction(item: Item) {
          const ids = this.getDayAndWeekFromItem(item);
          this.onDeleteConfirm(ids);
      }
     
    getDayAndWeekFromItem(item:Item):number[]{
        if(item.name.indexOf('day')>=0){
            const arr= item.name.split('_');
            return [parseInt(arr[1]),parseInt(arr[2])];
        }
        else if(item.name.indexOf('week')>=0){
            return [item.id,-1];
        }
        else
        return [-1,-2];
    }

    getData() {
        this.service.getByUrlParameters(["GetMenus"]).subscribe(r => {

          this.MenuEntries.forEach(e=>{
              e.days.forEach(d=>{
                  d.menuDetails=[];
              });
              const entryDays= r.data.find(x=>x.weekNumber==e.weekNumber);
              if(entryDays){
                  e.days.forEach(d=>{
                      const dayDetails= entryDays.days.find(x=>x.dayOfWeek==d.dayOfWeek);
                      if(dayDetails)
                      d.menuDetails=dayDetails.menuDetails;
                  })
              }
          })
          
        },
            error => {
               
                
                this.modalService.showError(`${this.lang.getValueByKey('error_msg')}: ${error.message}`);
            }
        )
    }


 


    source:any={};
    onDeleteConfirm(ids:number[]): void {
 var result =       this.modalService.confirmationModal({
            titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
            bodyText:this.lang.getValueByKey('areYouSure_lbl'),
            cancelButtonText:this.lang.getValueByKey('cancel_btn'),
            okText:this.lang.getValueByKey('ok_btn'),
        });
  result.subscribe(r=>{
      if(r)
      this.delete(ids);
  })
   
    }

    delete(ids:number[]) {
        this.service.deleteGeneric(ids.join('/'),"","DeleteMenu").subscribe(r => {
            if (r.status >= 0) {
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'))
                this.getData();
            }
            else
             this.modalService.showError(r.message);
        },
            error => {
                this.modalService.showError();
            })
    }
}