import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Currency } from '../data/currencyModel';

@Injectable({
    providedIn: "root"
})

export class CurrencyService extends BaseService<Currency, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.currencies}`);
    }
}