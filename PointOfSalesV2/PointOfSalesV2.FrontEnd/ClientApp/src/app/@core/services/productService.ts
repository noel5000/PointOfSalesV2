import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product, UnitProductEquivalence } from '../data/product';

@Injectable({
    providedIn: "root"
})

export class ProductService extends BaseService<Product, number>{
    constructor(
        http: HttpClient
    ) {
        super(http, `${endpointUrl}${endpointControllers.products}`);
    }

    ConvertFromProductPrincipalUnit(quantity:number, unitId:number,units:UnitProductEquivalence[]):number{
        const actualUnit = units.find(u => u.unitId == unitId);
        if (actualUnit == null)
            return 0;

        const equivalence = (quantity * actualUnit.equivalence);

       return equivalence;
    }

    ConvertToProductPrincipalUnit(quantity:number, unitId:number,  units:UnitProductEquivalence[]):number
    {
        const actualUnit = units.find(u => u.unitId == unitId);
        if (actualUnit == null) 
            return 0;
        
        const parentUnit = units.find(u => u.isPrimary);
        if (parentUnit == null)
            return  0; 

        const equivalence = (quantity * parentUnit.equivalence) / actualUnit.equivalence;

        return equivalence;
    }
}