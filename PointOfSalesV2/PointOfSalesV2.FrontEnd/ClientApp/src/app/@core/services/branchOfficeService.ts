import { BaseService } from './baseService';
import { BranchOffice } from '../data/branchOffice';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
    providedIn: "root"
})

export class BranchOfficeService extends BaseService<BranchOffice, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.branchOffices}`);
    }
}