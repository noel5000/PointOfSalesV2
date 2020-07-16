import { 
    Component, 
    OnInit, 
    ChangeDetectionStrategy,
    ViewChild,
    TemplateRef, } from '@angular/core';
    import {
        startOfDay,
        endOfDay,
        subDays,
        addDays,
        endOfMonth,
        isSameDay,
        isSameMonth,
        addHours,
      } from 'date-fns';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter, BillingStatesColors, BillingStates, ODataComparers } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';

import { Subject } from 'rxjs';
import {
  CalendarEvent,
  CalendarEventAction,
  CalendarEventTimesChangedEvent,
  CalendarView,
  CalendarMonthViewBeforeRenderEvent,
  CalendarWeekViewBeforeRenderEvent,
  CalendarDayViewBeforeRenderEvent,
} from 'angular-calendar';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl, endpointViewsUrl } from '../../../@core/common/constants';
import { Warehouse } from '../../../@core/data/Warehouse';
import { WarehouseService } from '../../../@core/services/WarehouseService';


declare const $: any;



@Component({
    selector: "invoice-lead-list",
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: "./invoiceLeadsIndex.component.html",
    styleUrls: ["../invoiceLeadsStyles.component.scss"],
   
})
export class InvoiceLeadsIndexComponent extends BaseComponent implements OnInit {
    
    @ViewChild('modalContent', { static: true }) modalContent: TemplateRef<any>;
    service: BaseService<any,number> = new BaseService<any,number>(this.http,`${endpointUrl}Menu`);
    leadService: BaseService<any,number> = new BaseService<any,number>(this.http,`${endpointUrl}InvoiceLead`);
    projectedLeads:any[]=[];
    branchOffices:BranchOffice[]=[];
    warehouses:Warehouse[]=[];
    view: CalendarView = CalendarView.Month;
    menuDetails:any[]=[];
    branchOfficeId:number=0;
    warehouseId:number=0;
    CalendarView = CalendarView;
    selectedLeads:any[]=[];
  
    viewDate: Date = new Date();
  
    modalData: {
      action: string;
      event: CalendarEvent;
    };

    actions: CalendarEventAction[] = [
        {
          label: '<i class="fa fa-fw fa-pencil"></i>',
          a11yLabel: 'Edit',
          onClick: ({ event }: { event: CalendarEvent }): void => {
            this.handleEvent('Edited', event);
          },
        },
        {
          label: '<i class="fa fa-fw fa-times"></i>',
          a11yLabel: 'Delete',
          onClick: ({ event }: { event: CalendarEvent }): void => {
            this.events = this.events.filter((iEvent) => iEvent !== event);
            this.handleEvent('Deleted', event);
          },
        },
      ];

      refresh: Subject<any> = new Subject();

      events: CalendarEvent[] = [];
    
      activeDayIsOpen: boolean = false;
    constructor(
        route: Router,
        langService: LanguageService,
        private http:HttpClient,
        private warehouseService:WarehouseService,
        private branchOfficeService:BranchOfficeService,
        private modals:NgbModal,
        private modalService:ModalService
    ) {
        super(route, langService, AppSections.InvoiceLeads);       
    }

    ngOnInit(): void {
        this.verifyUser();
        this.getProjectedLeads();
        this.getBranchOffices();
    }
  async  getBranchOffices(){
      this.branchOfficeService.getAll().subscribe(r=>{
       this.branchOffices= r;
       
      if(this.branchOffices.length==1){

        this.branchOfficeId=this.branchOffices[0].id;
        this.getWarehouses(this.branchOfficeId);
      }
      });
    }
    
  async  getWarehouses(branchOfficeId:number){
    this.branchOfficeId=branchOfficeId;
    const filter = [{
      property: 'BranchOfficeId',
      value: branchOfficeId.toString(),
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
    
      this.warehouses= (r['value']);
      if(this.warehouses.length==1){
        this.warehouseId=this.warehouses[0].id;
      
      }
  });
  
  this.getProjectedLeads();
    }

warehouseChange(id:number){
  this.warehouseId=id;
  this.getProjectedLeads();
}

getStatusDescription(state:string):string{
  return this.lang.getValueByKey(`billingState${state}_lbl`);
}

generateLead(lead:any){
this.leadService.post(lead,null,'GenerateLeadFromMenu').subscribe(r=>{
  if(r.status>=0)
    this.modalService.showSuccess(this.lang.getValueByKey(r.message));
  else
  this.modalService.showError(this.lang.getValueByKey(r.message));

  this.refresh.next()
});
}

removeLead(lead:any){
  var result =       this.modalService.confirmationModal({
    titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
    bodyText:this.lang.getValueByKey('areYouSure_lbl'),
    cancelButtonText:this.lang.getValueByKey('cancel_btn'),
    okText:this.lang.getValueByKey('ok_btn'),
});
result.subscribe(r=>{
if(r)
this.leadService.delete(lead.id).subscribe(r=>{
  if(r.status>=0)
    this.modalService.showSuccess(this.lang.getValueByKey(r.message));
  else
  this.modalService.showError(this.lang.getValueByKey(r.message));
  
  this.getProjectedLeads();
});
});
 
}
printLead(lead:any){
  const user = JSON.parse(localStorage.getItem("currentUser"));
  this.router.navigate(['/externalRedirect', { externalUrl: `${endpointViewsUrl}views/InvoiceLeadPrint?id=${lead.id}&menuId=${lead.menuId}&schoolId=${lead.schoolId}&sequence=${lead.leadSequence}&language=${user.languageId}` }], {
    skipLocationChange: true,
});
}

print(e: any) {
  const user = JSON.parse(localStorage.getItem("currentUser"));
  this.router.navigate(['/externalRedirect', { externalUrl: `${endpointViewsUrl}views/InvoiceLeadPrint?id=${e.id}&menuId=${e.menuId}&schoolId=${e.schoolId}&sequence=${e.leadSequence}&language=${user.languageId}` }], {
    skipLocationChange: true,
});
  }

deliverLead(lead:any){
  var result =       this.modalService.confirmationModal({
    titleText:this.lang.getValueByKey('markAsDeliveredConfirm_lbl'),
    bodyText:this.lang.getValueByKey('areYouSure_lbl'),
    cancelButtonText:this.lang.getValueByKey('cancel_btn'),
    okText:this.lang.getValueByKey('ok_btn'),
});
result.subscribe(r=>{
if(r)
this.leadService.getByUrlParameters(["deliverLead",lead.id.toString()]).subscribe(r=>{
  if(r.status>=0)
    this.modalService.showSuccess(this.lang.getValueByKey(r.message));
  else
  this.modalService.showError(this.lang.getValueByKey(r.message));
  
  this.getProjectedLeads();
});
});
}

   async getProjectedLeads(){

     this.service.getByUrlParameters(['GetProjectedLeads',this.branchOfficeId.toString(),
     this.warehouseId.toString(),this.viewDate.toUTCString()]).subscribe(r=>{
      this.projectedLeads=r.data;
      this.events=[];
      this.projectedLeads.forEach(d=>{
        this.events.push({
          start:new Date(d.date),
          end: new Date(d.date),
          title: `${d.leadSequence} ${d.schoolName}`,
          color:BillingStatesColors[d.state],
          actions: this.actions,
          allDay: true,
        } as CalendarEvent)
      });
      this.refresh.next();
     });
   }
    beforeMonthViewRender(renderEvent: CalendarMonthViewBeforeRenderEvent): void {
        renderEvent.body.forEach((day) => {
          const dayOfMonth = day.date.getDate();
          // if (dayOfMonth > 5 && dayOfMonth < 10 && day.inMonth) {
          //   day.cssClass = 'bg-pink';
          // }
        });
      }
    
  dayClicked({ date, events }: { date: Date; events: CalendarEvent[] }): void {
   this.selectedLeads=this.projectedLeads.filter(x=>new Date(x.date).toUTCString()==date.toUTCString());
  }

  eventTimesChanged({
    event,
    newStart,
    newEnd,
  }: CalendarEventTimesChangedEvent): void {
    this.events = this.events.map((iEvent) => {
      if (iEvent === event) {
        return {
          ...event,
          start: newStart,
          end: newEnd,
        };
      }
      return iEvent;
    });
    this.handleEvent('Dropped or resized', event);
  }

  handleEvent(action: string, event: CalendarEvent): void {
    this.modalData = { event, action };
    this.modals.open(this.modalContent, { size: 'lg' });
  }

  addEvent(): void {
    this.events = [
      ...this.events,
      {
        title: 'New event',
        start: startOfDay(new Date()),
        end: endOfDay(new Date()),
        draggable: true,
        resizable: {
          beforeStart: true,
          afterEnd: true,
        },
      },
    ];
  }

  deleteEvent(eventToDelete: CalendarEvent) {
    this.events = this.events.filter((event) => event !== eventToDelete);
  }

  setView(view: CalendarView) {
    this.view = view;
  }

  closeOpenMonthViewDay() {
    this.activeDayIsOpen = false;
    this.getProjectedLeads();
  }

  addNew(lead:any) {
    this.router.navigateByUrl(`pages/invoiceleads/add/${lead.menuId}/${lead.id}/${lead.schoolId}/${this.branchOfficeId}/${this.warehouseId}/${lead.date}`);
}

editLead(lead:any) {
  this.router.navigateByUrl(`pages/invoiceleads/edit/${lead.menuId}/${lead.id}/${lead.schoolId}/${this.branchOfficeId}/${this.warehouseId}/${lead.date}`);
}

}