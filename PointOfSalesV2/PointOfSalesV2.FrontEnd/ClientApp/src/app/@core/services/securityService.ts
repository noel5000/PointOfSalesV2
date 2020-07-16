import { Injectable } from '@angular/core';
import { AppSections, Operations } from '../common/enums';
import { AuthModel } from '../data/authModel';


@Injectable({
    providedIn: "root"
})
export class SecurityService {

   
    constructor() {
        
    }
    isUserValidInMenu(section: AppSections): boolean {
        let result = false;
        const auth = JSON.parse(localStorage.getItem('currentUser'));
        if (auth && new Date(auth.expiration) > new Date()) {
            if (auth.user.permissions.length == 0)
                return true;
            if (auth.user.permissions.filter(x => x.sectionId == section && (x.operationId == Operations.READ || x.operationId == Operations.ALL)).length > 0)
                return true;
        }
        return result;
    }

    validateMenuChildren(sections: AppSections[]): boolean {
        let result = false;
        const auth = JSON.parse(localStorage.getItem('currentUser'));
        if (auth && new Date(auth.expiration) > new Date()) {
            if (auth.user.permissions.length == 0)
                return true;
            sections.forEach(s => {
                if (auth.user.permissions.filter(x => x.sectionId == s && (x.operationId == Operations.READ || x.operationId == Operations.ALL)).length > 0)
                    result= true;
            })
        }
        return result;
    }

}