import { Component } from '@angular/core';
import { BaseComponent } from './../../@core/common/baseComponent';
import { AppSections } from '../../@core/common/enums';
import { LanguageService } from './../../@core/services/translateService';
import { Router } from '@angular/router';
import { BranchOfficeService } from './../../@core/services/branchOfficeService';
import { LocalDataSource } from 'ng2-smart-table';

import { SmartTableData } from './../../@core/data/smart-table';
import { BranchOffice } from './../../@core/data/branchOffice';

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
        this.source.setPaging(this.pageNumber, this.pageSize, true);
        this.source.setPage(this.pageNumber, true);
        this.getData();
    }

    getData() {
        this.service.getPaged(this.pageNumber, this.pageSize).subscribe(r => {
            if (r.status >= 0) {

                this.source = new LocalDataSource(r.data);
                this.maxCount = r.totalItemCount;

            }
            else
                alert(r.message)
        },
            error => {
                alert(`${this.lang.getValueByKey('error_msg')}: ${error.message}`);
            }
        )
    }

    getPagedData(e) {
        this.pageNumber = e;
        this.getData();
    }
    pageNumber: number = 1;
    pageSize: number = 10;
    maxCount: number = 0;
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
                title: this.lang.getValueByKey('id_label'),
                type: 'number',
                compareFunction: function (e) {
                    alert('sort funct');
                }
            }
            ,
            name: {
                title: this.lang.getValueByKey('name_lable'),
                type: 'text',
                compareFunction: function (e) {
                    alert(`sorting function: ${JSON.stringify(e)}`)
                },
                filterFunction: function (e, e1, e2) {
                    alert(`filtering function: ${JSON.stringify(e)},${JSON.stringify(e1)},${JSON.stringify(e2)}`)
                },

            }
        },
        pager: {
            display: true,
            perPage: 10,


        },
        actions: {
            columnTitle: this.lang.getValueByKey('actions_label')
        }
    };


    addNew(e: any) {
        this.router.navigateByUrl(`pages/branchoffice/add`);
    }
    edit(e) {
        this.router.navigateByUrl(`pages/branchoffice/edit/${e.data.id}`);
    }
    source: LocalDataSource = new LocalDataSource();
    onDeleteConfirm(event): void {
        if (window.confirm(this.lang.getValueByKey('deleteConfirm_msg'))) {
            this.delete(event.data.id);

        }
    }

    delete(id: number) {
        this.service.delete(id).subscribe(r => {
            if (r.status >= 0) {
                alert(this.lang.getValueByKey('success_msg'))
                this.getData();
            }
            else
                alert(r.message);
        },
            error => {
                alert(this.lang.getValueByKey('error_msg'));
            })
    }
}