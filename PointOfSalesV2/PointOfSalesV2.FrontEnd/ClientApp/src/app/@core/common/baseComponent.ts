import { AppSections, Operations } from './enums';
import { Router } from '@angular/router';
import { AuthModel } from '../data/authModel';
import { LanguageService } from './../services/translateService';
import { OnInit } from '@angular/core';

export class BaseComponent  {
   
    constructor(route: Router, langService: LanguageService, section:AppSections) {
       
        this.lang = langService;
        this.router = route;
        this.section=section;

    }

    verifyUser(){
        this.authModel = JSON.parse(localStorage.getItem('currentUser'));
        if (this.authModel && new Date(this.authModel.expiration) > new Date()) {
            this.getUserAuthorizations();
        }
        else
            this.returnToLogin();

    }

    updateModel<T>(model:any,toUpdate:T):T{
        for(var prop in model){
            toUpdate[prop]=model[prop];
        }

        return toUpdate;
    }
    section: AppSections = null;
    authModel: AuthModel = null;
    permits: any = {};

    router: Router;
    lang: LanguageService;
    getUserAuthorizations() {
        const sectionOperations = this.authModel.user.permissions.filter(x => x.sectionId === this.section);
        this.permits.read = sectionOperations.findIndex(x => x.operationId === Operations.READ ||
            x.operationId === Operations.READALL || x.operationId === Operations.READPAGED) >= 0;
        this.permits.add = sectionOperations.findIndex(x => x.operationId === Operations.ADD) >= 0;
        this.permits.update = sectionOperations.findIndex(x => x.operationId === Operations.UPDATE) >= 0;
        this.permits.delete = sectionOperations.findIndex(x => x.operationId === Operations.DELETE) >= 0;
        this.permits.readPaged = sectionOperations.findIndex(x => x.operationId === Operations.READPAGED
            || x.operationId === Operations.READALL) >= 0;

        if (sectionOperations.findIndex(x => x.operationId === Operations.ALL) >= 0 || sectionOperations.length == 0) {
            this.permits = { read: true, update: true, delete: true, add: true, readPaged: true };
        }
        if (!this.permits.read || (!this.permits.add && !this.permits.update && !this.permits.delete)) {
            this.returnToLogin();
        }
        const currentUrl = this.router.url.split('/');
        if ((currentUrl.indexOf('add') >= 0 && !this.permits.add) || (currentUrl.indexOf('edit') >= 0 && !this.permits.update))
            this.returnToLogin();


    }

    returnToLogin() {
        var auth = JSON.parse(localStorage.getItem(`currentUser`)) as AuthModel;
        if(!auth)
        {
            auth=new AuthModel();
            auth.languageId='EN';
        }
        localStorage.setItem(`language-${auth.languageId}`, null);
        localStorage.setItem('currentUser', null);
        this.lang.setLanguageInHeaders('EN');
        this.lang.setCurrentLanguage('EN');
        this.authModel = null;
        this.router.navigateByUrl('auth/login');
    }
}
