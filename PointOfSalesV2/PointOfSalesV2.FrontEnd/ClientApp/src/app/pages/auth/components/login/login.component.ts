import { NbLoginComponent, NbAuthService } from '@nebular/auth';
import { Component, ChangeDetectorRef } from '@angular/core';
import { BaseService } from '../../../../@core/services/baseService';
import { AuthModel } from '../../../../@core/data/authModel';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { endpointUrl, endpointControllers } from '../../../../@core/common/constants';
import { LanguageService } from './../../../../@core/services/translateService';



const defaultAuthOptions: any = {
    strategies: [],
    forms: {
        login: {
            redirectDelay: 500, // delay before redirect after a successful login, while success message is shown to the user
            strategy: 'email',  // provider id key. If you have multiple strategies, or what to use your own
            rememberMe: true,   // whether to show or not the `rememberMe` checkbox
            showMessages: {     // show/not show success/error messages
                success: true,
                error: true,
            },
            socialLinks: null, // social links at the bottom of a page
        },
        register: {
            redirectDelay: 500,
            strategy: 'email',
            showMessages: {
                success: true,
                error: true,
            },
            terms: true,
            socialLinks: null,
        },
        requestPassword: {
            redirectDelay: 500,
            strategy: 'email',
            showMessages: {
                success: true,
                error: true,
            },
            socialLinks: null,
        },
        resetPassword: {
            redirectDelay: 500,
            strategy: 'email',
            showMessages: {
                success: true,
                error: true,
            },
            socialLinks: null,
        },
        logout: {
            redirectDelay: 500,
            strategy: 'email',
        },
        validation: {
            password: {
                required: true,
                minLength: 4,
                maxLength: 50,
            },
            email: {
                required: true,
            },
            fullName: {
                required: false,
                minLength: 4,
                maxLength: 50,
            },
        },
    },
};


@Component({
    selector: "app-login-page",
    templateUrl: "../../../../../../node_modules/@nebular/auth/components/login/login.component.html"
})
export class LoginComponent extends NbLoginComponent {
    baseService: BaseService<AuthModel, number>;

    constructor(baseService: NbAuthService,
        changeDet: ChangeDetectorRef,
        router: Router,
        private lang: LanguageService,
        httpClient: HttpClient
    ) {
        super(baseService, defaultAuthOptions, changeDet, router);
        this.baseService = new BaseService(httpClient, `${endpointUrl}${endpointControllers.login}`);
    }




    login() {
        let toPost = new AuthModel();
        toPost.email = this.user.email;
        toPost.password = this.user.password;
        const postResult = this.baseService.post(toPost);

        postResult.subscribe(r => {
            if (r['status'] && r['status'] > 0) {
                localStorage.removeItem('currentUser');
                localStorage.setItem('currentUser', JSON.stringify(r));
                this.lang.setLanguageInHeaders(r['languageId']);
                this.lang.setCurrentLanguage(r['languageId'],false);
               
            }

            else
                alert(r['message']);

        }, error => {
            alert(error['message']);

        })
    }
}