import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { School } from '../data/school';

@Injectable({
    providedIn: "root"
})

export class SchoolService extends BaseService<School, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.schools}`);
    }
}