import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Expense } from '../data/expenseModel';
import { Observable } from 'rxjs';
import { BaseResultModel } from '../data/baseResultModel';
import { ExpensePayment } from '../data/expensePayment';

export interface ISupplierPayment{
    payment:any;
    expenses:any[];
}

@Injectable({
    providedIn: "root"
})
export class ExpensePaymentService extends BaseService<ExpensePayment, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.expensePayment}`);
    }

    PayExpenses(payment:ISupplierPayment,lang:string=''):Observable<any>{
        this.setHttpOptions();
        this.setLanguageInHeaders(lang);
        return this._httpClient.post<BaseResultModel<any>>(
            `${this.baseUrl}/AddPayments`,
            payment,
            !lang ? this.httpOptions : this.tempHttpOptions
        );
    }
}