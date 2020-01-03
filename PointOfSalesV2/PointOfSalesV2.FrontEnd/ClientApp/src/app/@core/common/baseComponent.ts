import { AppSections, Operations } from './enums';
import { Router } from '@angular/router';
import { AuthModel } from '../data/authModel';

export class BaseComponent {
    constructor(route: Router, baseSection: AppSections) {
        this.section = baseSection;
        this.router = route;
        this.authModel = JSON.parse(localStorage.getItem('currentUser'));
        if (this.authModel && this.authModel.expiration < new Date()) {
            this.getUserAuthorizations();
        }
        else
            this.returnToLogin();


    }
    section: AppSections = null;
    authModel: AuthModel = null;
    permits: any = {};
    router: Router;

    getUserAuthorizations() {
        const sectionOperations = this.authModel.user.permissions.filter(x => x.sectionId === this.section);
        this.permits.read = sectionOperations.findIndex(x => x.operationId === Operations.READ ||
            x.operationId === Operations.READALL || x.operationId === Operations.READPAGED) >= 0;
        this.permits.add = sectionOperations.findIndex(x => x.operationId === Operations.ADD) >= 0;
        this.permits.update = sectionOperations.findIndex(x => x.operationId === Operations.UPDATE) >= 0;
        this.permits.delete = sectionOperations.findIndex(x => x.operationId === Operations.DELETE) >= 0;
        this.permits.readPaged = sectionOperations.findIndex(x => x.operationId === Operations.READPAGED
            || x.operationId === Operations.READALL) >= 0;

        if (sectionOperations.findIndex(x => x.operationId === Operations.ALL) >= 0) {
            this.permits = { read: true, update: true, delete: true, add: true, readPaged: true };
        }
        if (!this.permits.read || (!this.permits.add && !this.permits.update && !this.permits.delete)) {
            this.returnToLogin();
        }


    }

    returnToLogin() {
        localStorage.setItem('currentUser', null);
        this.authModel = null;
        this.router.navigateByUrl('auth/login');
    }
}
