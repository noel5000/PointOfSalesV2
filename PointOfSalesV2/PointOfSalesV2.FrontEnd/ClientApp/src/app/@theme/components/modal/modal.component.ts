import {
  Component,
 OnDestroy,
 OnInit,
 Input,
 Output,
 EventEmitter,
 Directive,
 QueryList, 
 ViewChildren 
} from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IModalConfig, IAlertConfig } from '../../../@core/data/interfaces/iModalConfig';




@Component({
  selector: 'modal-confirm-autofocus',
  template: `

  <div class="modal-header">
    <h4 class="modal-title" id="modal-title">{{config.titleText}}</h4>
    <button type="button" class="close" aria-label="Close button" aria-describedby="modal-title" (click)="modal.dismiss('Cross click')">
      <span aria-hidden="true">&times;</span>
    </button>
  </div>
  <div class="modal-body">
    <p><strong>{{config.bodyText}}</strong></p>
   
  </div>
  <div class="modal-footer">
    <button type="button" class="btn btn-outline-secondary" (click)="result(false)">{{config.cancelButtonText}}</button>
    <button type="button" ngbAutofocus class="btn btn-danger" (click)="result(true) ">{{config.okText}}</button>
  </div>

  `
})
export class NgbdModalConfirmAutofocus {
  constructor(public modal: NgbActiveModal) {}
  @Input() config:IModalConfig;
  @Output() resultEvent:EventEmitter<boolean>= new EventEmitter<boolean>();

  result(val:boolean){
this.resultEvent.emit(val);
this.modal.close();
  }
}

@Component({
  selector: 'modal-alert-autofocus',
  template: `

  <div class="alert alert-primary" role="alert">
  {{config.bodyText}}
</div>
  `
})
export class NgbdModalAlertAutofocus {
  constructor(public modal: NgbActiveModal) {}
  @Input() config:IAlertConfig;

  result(val:boolean){
this.modal.close();
  }
}
