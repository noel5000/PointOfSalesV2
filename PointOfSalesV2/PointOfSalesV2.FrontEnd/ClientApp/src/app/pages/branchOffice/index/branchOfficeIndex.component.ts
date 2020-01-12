import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { basename } from 'path';

declare const $: any;
@Component({
    selector: "branch-Office-list",
    templateUrl: "./branchOfficeIndex.component.html",
    styleUrls: ["../branchOfficeStyles.component.scss"]
})
export class BranchOfficeIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.source.setPaging(this.pageNumber, this.pageSize, true);
        this.source.setPage(this.pageNumber, true);
        this.getData();
    }

    filters: QueryFilter[] = [];
    orderBy: string = 'Id';
    orderDirection: string = 'desc'
    constructor(
        route: Router,
        langService: LanguageService,
        private service: BranchOfficeService
    ) {
        super(route, langService);
        this.section=AppSections.BranchOffices;
        let scope = this;
        this.settings = {
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
                        alert(`sorting function: ${JSON.stringify(e)}`)
                    },
                    filterFunction: function (oldValue, currentValue) {
                   
                            scope.filterData(currentValue, 'Id', ObjectTypes.Number);
                      
                        
                    },
                }
                ,
                name: {
                    title: this.lang.getValueByKey('name_lable'),
                    type: 'text',
                    compareFunction: function (e) {
                        alert(`sorting function: ${JSON.stringify(e)}`)
                    },
                    filterFunction: function (oldValue, currentValue) {
                      
                            scope.filterData(currentValue, 'Name', ObjectTypes.String);
                   
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

       
    }

    getData() {
        this.service.getFiltered(this.pageNumber, this.pageSize, this.filters, this.orderBy, this.orderDirection).subscribe(r => {
          
        
            
            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            //   this.source.load((r['value'] && r['value'].length>0)?r['value']:[{id:0}]);
            //   this.source.refresh();
           
            //  this.pageNumber=r['value'] && r['value'].length>0?this.pageNumber:1;
          
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
    settings: any = null;

    filterData(currentValue: string, propertyName: string, propertyType: ObjectTypes) {
        const scope = this;
        let currentFilter = {
            property: propertyName,
            value: currentValue,
            type: propertyType
        } as QueryFilter;
        const index = this.filters.findIndex(x => x.property == currentFilter.property);
        if (index >= 0) {
            this.filters.splice(index, 1);
            this.filters.push(currentFilter);
        }
        else {
            this.filters.push(currentFilter);
        }
                scope.getData();  
       
      
           
      
        


    }

    addNew(e: any) {
        this.router.navigateByUrl(`pages/branchoffice/add`);
    }
    edit(e) {
        this.router.navigateByUrl(`pages/branchoffice/edit/${e.data.id}`);
    }
    source:any={};
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