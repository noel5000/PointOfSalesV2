import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Expense } from '../data/expenseModel';
import { BaseResultModel } from '../data/baseResultModel';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: "root"
})

export class ExpenseService extends BaseService<Expense, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.expenses}`);
    }


    getExpensesToPay(searchModel: any, languageId: string = ""): Observable<Expense[]> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.post<Expense[]>(
            this.baseUrl+'/GetOwedExpenses',
            searchModel,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
}