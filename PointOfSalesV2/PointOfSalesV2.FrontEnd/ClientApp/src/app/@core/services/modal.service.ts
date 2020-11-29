import { IModalConfig } from '../data/interfaces/iModalConfig';
import { Injectable, EventEmitter } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus, NgbdModalAlertAutofocus } from '../../@theme/components/modal/modal.component';
import { LanguageService } from './translateService';
import { ToastrService } from 'ngx-toastr';


@Injectable( {providedIn:'root'})
export class ModalService{
modalRef:any;
    constructor(
        private modals:NgbModal,
        private lang:LanguageService,
        private toastr: ToastrService
        ){
            
        }
    confirmationModal(config:IModalConfig):EventEmitter<boolean>{
    
        this.modalRef=this.modals.open(NgbdModalConfirmAutofocus);
        this.modalRef.componentInstance.config=config;
      
     return this.modalRef.componentInstance.resultEvent ;
    

        
    }

    showSuccess(message:string='') {
      let result='';
      if(message && message.indexOf('|')>=0)
      message.split('|').forEach(m=>{
        result+=`${this.lang.getValueByKey(m.trim())} `;
      })      
        this.toastr.success(!message?this.lang.getValueByKey('success_msg'):result, this.lang.getValueByKey('success_msg'));
      }

      showError(message:string='') {
        let result='';
        if(message && message.indexOf('|')>=0)
        message.split('|').forEach(m=>{
          result+=`${this.lang.getValueByKey(m.trim())} `;
        })
        else
        result=this.lang.getValueByKey(message);
        
        this.toastr.error(!message?this.lang.getValueByKey('error_msg'):result, this.lang.getValueByKey('error_msg'));
      }
}