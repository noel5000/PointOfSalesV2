import { Injectable } from '@angular/core';
import { BaseService } from './baseService';
import { HttpClient } from '@angular/common/http';
import { TranslateService, TranslateLoader } from '@ngx-translate/core';
import { endpointUrl, endpointControllers } from './../common/constants';
import { map } from 'rxjs/operators';
import { AuthModel } from './../data/authModel';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';




@Injectable({
    providedIn: "root"
})
export class LanguageService extends BaseService<any, string> {
    constructor(public http: HttpClient, private translate: TranslateService, private route: Router) {
        super(http, `${endpointUrl}${endpointControllers.languages}`);



    }

    setCurrentLanguage(lang: string = '', reloadPage: boolean = false) {
        const auth = JSON.parse(localStorage.getItem("currentUser")) as AuthModel;

        if (auth) {
            const language = lang ? lang : auth.user.languageCode;
            auth.languageId = language;
            auth.user.languageCode = language;
            localStorage.setItem('currentUser', null);
            localStorage.setItem('currentUser', JSON.stringify(auth));
            const baseService = new BaseService<any, any>(this.http, `assets/i18n/${language}.json`);
            baseService.getGeneral().subscribe(r => {
                localStorage.setItem(`language-${language}`, JSON.stringify(r));
                this.translate.resetLang(language);
                this.translate.setTranslation(language, r,false);
                this.translate.setDefaultLang(language);
                this.translate.use(language);
                if (reloadPage)
                window.location.href='';
                else
                this.route.navigateByUrl('');
            })
        } else {
            this.route.navigateByUrl('auth/login');
        }
    }



    ///Language




    getValueByKeyAndLanguage(key: string, language: string) {

        return this.translate.translations[language][key];
    }

    getValueByKey(key: string) {
        var auth = JSON.parse(localStorage.getItem('currentUser')) as AuthModel;
        const currentLanguage = auth ? auth.languageId : 'EN';
        if (this.translate.translations[currentLanguage])
            return this.translate.translations[currentLanguage][key] || key;
        else {
            const currentDictionary = JSON.parse(localStorage.getItem(`language-${currentLanguage}`));
            return currentDictionary ? currentDictionary[key] : key;
        }
    }




    //   reloadLang(lang: string = '') {
    //     var auth = JSON.parse(localStorage.getItem('currentUser')) as AuthModel;
    //     const currentLanguage = lang ? lang: auth ? auth.user.languageCode : 'EN';
    //     this.setCurrentLanguage(currentLanguage);
    //     this.translate.resetLang(currentLanguage);
    //     this.translate.use(currentLanguage);

    //     const algo =this.translate.getTranslation(currentLanguage);
    //     return this.translate.reloadLang(currentLanguage);
    //     }

    generateJson() {
        return this.http.get(`${endpointUrl}${endpointControllers.languages}/GenerateJsonFile`);
    }


}


