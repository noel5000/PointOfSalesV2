import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Warehouse } from '../data/warehouse';
import { CashRegister } from '../data/cashRegister';

@Injectable({
    providedIn: "root"
})

export class CashRegisterService extends BaseService<CashRegister, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.cashRegister}`);
    }
}