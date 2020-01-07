import { Component } from '@angular/core';
import { BaseComponent } from './../../@core/common/baseComponent';
import { AppSections } from '../../@core/common/enums';
import { LanguageService } from './../../@core/services/translateService';
import { Router } from '@angular/router';
import { BranchOfficeService } from './../../@core/services/branchOfficeService';
import { LocalDataSource } from 'ng2-smart-table';

import { SmartTableData } from './../../@core/data/smart-table';

declare const $: any;
@Component({
    selector: "branch-Office-list",
    templateUrl: "./branchOfficeIndex.component.html",
    styleUrls: ["./branchOfficeStyles.component.scss"]
})
export class BranchOfficeIndexComponent extends BaseComponent {

    constructor(
        route: Router,
        langService: LanguageService,
        private service: BranchOfficeService
    ) {
        super(route, langService, AppSections.BranchOffices);
        this.source.setPaging(1, 10, true);
        this.source.setPage(1, true);
    }

    settings = {
        mode: 'external',
        add: {

            addButtonContent: '<i class="nb-plus" ></i>',
            createButtonContent: '<i class="nb-checkmark"></i>',
            cancelButtonContent: '<i class="nb-close"></i>',
        },
        edit: {
            editButtonContent: '<i class="nb-edit"></i>',
            saveButtonContent: '<i class="nb-checkmark"></i>',
            cancelButtonContent: '<i class="nb-close"></i>',
        },
        delete: {
            deleteButtonContent: '<i class="nb-trash"></i>',
            confirmDelete: true,
        },
        columns: {
            id: {
                title: 'ID',
                type: 'number',
            },
            firstName: {
                title: 'First Name',
                type: 'string',
            },
            lastName: {
                title: 'Last Name',
                type: 'string',
            },
            username: {
                title: 'Username',
                type: 'string',
            },
            email: {
                title: 'E-mail',
                type: 'string',
            },
            age: {
                title: 'Age',
                type: 'number',
            },
        },
        pager: {
            display: true,
            perPage: 10,
            rowClassFunction: function (e: any) {

            }
        },
        filterFunction: function (e: any) {

        },
        compareFunction: function (e: any) {

        }
    };
    addNew(e: any) {
        alert('algo');
    }
    source: LocalDataSource = new LocalDataSource();
    onDeleteConfirm(event): void {
        if (window.confirm('Are you sure you want to delete?')) {
            event.confirm.resolve();
        } else {
            event.confirm.reject();
        }
    }
}