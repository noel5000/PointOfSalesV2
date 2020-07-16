import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Supplier } from '../data/Supplier';

@Injectable({
    providedIn: "root"
})

export class SupplierService extends BaseService<Supplier, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.suppliers}`);
    }
}