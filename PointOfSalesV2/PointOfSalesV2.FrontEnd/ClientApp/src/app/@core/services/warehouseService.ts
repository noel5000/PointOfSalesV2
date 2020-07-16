import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Warehouse } from '../data/warehouse';

@Injectable({
    providedIn: "root"
})

export class WarehouseService extends BaseService<Warehouse, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.warehoses}`);
    }
}