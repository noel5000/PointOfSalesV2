import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Tax } from '../data/taxModel';

@Injectable({
    providedIn: "root"
})

export class TaxService extends BaseService<Tax, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.taxes}`);
    }
}