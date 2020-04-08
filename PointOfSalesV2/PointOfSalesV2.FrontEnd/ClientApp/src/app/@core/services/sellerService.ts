import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Seller } from '../data/seller';

@Injectable({
    providedIn: "root"
})

export class SellerService extends BaseService<Seller, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.sellers}`);
    }
}