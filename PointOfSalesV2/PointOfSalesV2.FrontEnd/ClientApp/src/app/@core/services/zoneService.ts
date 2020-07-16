import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Zone } from '../data/zoneModel';

@Injectable({
    providedIn: "root"
})

export class ZoneService extends BaseService<Zone, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.zones}`);
    }
}