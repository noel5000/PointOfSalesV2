import { Component } from '@angular/core';

import { MENU_ITEMS } from './pages-menu';
import { NbMenuItem } from '@nebular/theme';
import { LanguageService } from './../@core/services/translateService';

@Component({
  selector: 'ngx-pages',
  styleUrls: ['pages.component.scss'],
  template: `
    <ngx-one-column-layout>
      <nb-menu [items]="menu"></nb-menu>
      <router-outlet></router-outlet>
    </ngx-one-column-layout>
  `,
})
export class PagesComponent {
  constructor(private lang: LanguageService) { }

  menu: NbMenuItem[] = [
    {
      title: this.lang.getValueByKey('dashboard_menu'),
      icon: 'home-outline',
      link: '/pages/dashboard',
      home: true,
      hidden: false
    },
    {
      title: this.lang.getValueByKey('features_menu'),
      group: true,
      hidden: false
    },
    {
      title: this.lang.getValueByKey('auth_menu'),
      icon: 'lock-outline',
      hidden: false,
      children: [
        {
          title: this.lang.getValueByKey('login__menu'),
          link: '/auth/login',
          hidden: false
        },
        {
          title: this.lang.getValueByKey('register_menu'),
          link: '/auth/register',
          hidden: false
        },
        {
          title: this.lang.getValueByKey('requestPass_menu'),
          link: '/auth/request-password',
          hidden: false
        },
        {
          title: this.lang.getValueByKey('resetPass_menu'),
          link: '/auth/reset-password',
          hidden: false
        },
      ],
    },
  ];
}
