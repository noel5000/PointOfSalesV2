import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Unit } from '../data/unitModel';

@Injectable({
    providedIn: "root"
})

export class UnitService extends BaseService<Unit, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.units}`);
    }
}