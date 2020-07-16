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
        this.toastr.success(!message?this.lang.getValueByKey('success_msg'):this.lang.getValueByKey(message), this.lang.getValueByKey('success_msg'));
      }

      showError(message:string='') {
        this.toastr.error(!message?this.lang.getValueByKey('error_msg'):this.lang.getValueByKey(message), this.lang.getValueByKey('error_msg'));
      }
}