import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Customer } from '../data/customer';

@Injectable({
    providedIn: "root"
})

export class CustomerService extends BaseService<Customer, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.customers}`);
    }
}