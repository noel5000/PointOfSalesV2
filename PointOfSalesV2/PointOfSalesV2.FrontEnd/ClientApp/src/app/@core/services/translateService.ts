import { Injectable } from '@angular/core';
import { BaseService } from './baseService';
import { HttpClient } from '@angular/common/http';
import { TranslateService } from '@ngx-translate/core';
import { endpointUrl, endpointControllers } from './../common/constants';
import { map } from 'rxjs/operators';




@Injectable({
    providedIn: "root"
})
export class LanguageService extends BaseService<any, string> {
    constructor(public http: HttpClient, private translate: TranslateService) {
        super(http, `${endpointUrl}${endpointControllers.languages}`);
        this.setCurrentLanguage();


    }

    setCurrentLanguage() {
        const auth = JSON.parse(localStorage.getItem("currentUser"));

        if (auth) {
            this.translate.setDefaultLang(auth.user.languageCode);
            this.translate.use(auth.user.languageCode);
        } else {
            this.translate.setDefaultLang("EN");
            this.translate.use("EN");
        }
    }



    ///Language




    getValueByKeyAndLanguage(key: string, language: string) {
        this.setCurrentLanguage();
        return this.translate.translations[language][key];
    }

    getValueByKey(key: string) {
        this.setCurrentLanguage();
        return this.translate.translations[this.translate.currentLang][key] || key;
    }




    reloadLang() {
        this.setCurrentLanguage();
        return this.translate.reloadLang(this.translate.currentLang);
    }

    generateJson() {
        return this.http.get(`${endpointUrl}${endpointControllers.languages}/GenerateJsonFile`);
    }


}