import { Component, OnDestroy, OnInit } from '@angular/core';
import { NbMediaBreakpointsService, NbMenuService, NbSidebarService, NbThemeService } from '@nebular/theme';

import { User, UserData } from '../../../@core/data/users';
import { map, takeUntil, filter } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { LanguageService } from '../../../@core/services/translateService';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointControllers, endpointUrl } from '../../../@core/common/constants';
import { AuthModel } from '../../../@core/data/authModel';

@Component({
  selector: 'ngx-header',
  styleUrls: ['./header.component.scss'],
  templateUrl: './header.component.html',
})
export class HeaderComponent implements OnInit, OnDestroy {
  languages: any[] = [];
  currentLanguage: string = 'EN';
  languageService: BaseService<any, string>;
  private destroy$: Subject<void> = new Subject<void>();
  userPictureOnly: boolean = false;
  user: any;

  changeLanguage(languageCode: string) {

    //this.currentLanguage = languageCode;
    let currentUser = JSON.parse(localStorage.getItem('currentUser')) as AuthModel;
    if (currentUser && new Date(currentUser.expiration) > new Date()) {
      this.lang.setLanguageInHeaders(this.currentLanguage);
      this.lang.setCurrentLanguage(this.currentLanguage, true);
      // window.location.reload();
    }
  }

  themes = [
    {
      value: 'default',
      name: 'Light',
    },
    {
      value: 'dark',
      name: 'Dark',
    },
    {
      value: 'cosmic',
      name: 'Cosmic',
    },
    {
      value: 'corporate',
      name: 'Corporate',
    },
  ];

  currentTheme = '';

  userMenu = [
    {
      title: this.lang.getValueByKey('profile_btn'),
      target: 'profileBtn'
    },
    {
      title: this.lang.getValueByKey('logOut_btn'),
      target: 'logoutBtn'
    }];

  constructor(private sidebarService: NbSidebarService,
    private menuService: NbMenuService,
    private themeService: NbThemeService,
    private userService: UserData,
    private route: Router,
    http: HttpClient,
    private lang: LanguageService,
    private breakpointService: NbMediaBreakpointsService) {
    this.languageService = new BaseService(http, `${endpointUrl}${endpointControllers.languages}`);


    this.languageService.get().subscribe(r => {
      if (r.status >= 0) {
        this.languages = r.data;
        const currentUser = JSON.parse(localStorage.getItem('currentUser')) as AuthModel;
        if (!currentUser || !(new Date(currentUser.expiration) > new Date())) {
          localStorage.removeItem('currentUser');
          this.route.navigateByUrl('auth/login');
        }
        this.currentLanguage = this.languages.find(x => x.code == currentUser.user.languageCode).code;

      }

    });
  }

  ngOnInit() {
    this.currentTheme = this.themeService.currentTheme;
    const data =JSON.parse(localStorage.getItem('currentUser'))as AuthModel;
    if(!data){
      localStorage.removeItem('currentUser');
          this.route.navigateByUrl('auth/login');
    }

  this.user = data?data.user:new User();
    const { xl } = this.breakpointService.getBreakpointsMap();
    this.themeService.onMediaQueryChange()
      .pipe(
        map(([, currentBreakpoint]) => currentBreakpoint.width < xl),
        takeUntil(this.destroy$),
      )
      .subscribe((isLessThanXl: boolean) => this.userPictureOnly = isLessThanXl);

    this.themeService.onThemeChange()
      .pipe(
        map(({ name }) => name),
        takeUntil(this.destroy$),
      )
      .subscribe(themeName => this.currentTheme = themeName);

    this.menuService.onItemClick()
      .pipe(
        filter(({ tag }) => tag === 'users-menu'),
        map(({ item: { title, target } }) => target),
      )
      .subscribe(target => {
        switch (target) {

          case 'logoutBtn':
            this.logout();
            break;
          default:
            alert(`${target} was clicked!!!!!!!`);
            break;
        }

      });
  }

  ngOnDestroy() {
    this.destroy$.next();
    this.destroy$.complete();
  }

  logout() {
    var auth = JSON.parse(localStorage.getItem(`currentUser`)) as AuthModel;
    if(auth){
      localStorage.setItem(`language-${auth.languageId}`, null);
    }
    localStorage.removeItem('currentUser');
    this.lang.setLanguageInHeaders('ES');
    this.lang.setCurrentLanguage('ES');
    this.route.navigateByUrl('auth/login');
  }

  changeTheme(themeName: string) {
    this.themeService.changeTheme(themeName);
  }

  toggleSidebar(): boolean {
    this.sidebarService.toggle(true, 'menu-sidebar');

    return false;
  }

  navigateHome() {
    this.menuService.navigateHome();
    return false;
  }
}
