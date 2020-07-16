import { Component, Input } from '@angular/core';
import { LanguageService } from '../../../@core/services/translateService';

@Component({
  selector: 'ngx-alert',
  templateUrl: 'alert.component.html',
})
export class AlertComponent {

    constructor(private lang:LanguageService){

    }
   @Input() title:string;
   @Input() message:string;
}