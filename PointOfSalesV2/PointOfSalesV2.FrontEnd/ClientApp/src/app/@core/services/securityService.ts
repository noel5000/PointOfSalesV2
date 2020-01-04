import { Injectable } from '@angular/core';
import { AppSections, Operations } from '../common/enums';
import { AuthModel } from '../data/authModel';


@Injectable({
    providedIn: "root"
})
export class SecurityService {

    auth: AuthModel;
    constructor() {
        this.auth = JSON.parse(localStorage.getItem('currentUser'));
    }
    isUserValidInMenu(section: AppSections): boolean {
        let result = false;
        if (this.auth && new Date(this.auth.expiration) > new Date()) {
            if (this.auth.user.permissions.length == 0)
                return true;
            if (this.auth.user.permissions.filter(x => x.sectionId == section && (x.operationId == Operations.READ || x.operationId == Operations.ALL)).length > 0)
                return true;
        }
        return result;
    }

    validateMenuChildren(sections: AppSections[]): boolean {
        let result = false;
        if (this.auth && new Date(this.auth.expiration) > new Date()) {
            if (this.auth.user.permissions.length == 0)
                return true;
            sections.forEach(s => {
                if (this.auth.user.permissions.filter(x => x.sectionId == s && (x.operationId == Operations.READ || x.operationId == Operations.ALL)).length > 0)
                    return true;
            })
        }
        return result;
    }

}