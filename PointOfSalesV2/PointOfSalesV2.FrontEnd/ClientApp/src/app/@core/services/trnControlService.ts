import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TRNControl } from '../data/trnControlModel';

@Injectable({
    providedIn: "root"
})

export class TRNControlService extends BaseService<TRNControl, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.trncontrol}`);
    }
}