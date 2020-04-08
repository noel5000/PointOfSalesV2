import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { Tax } from './taxModel';
import { Unit } from './unitModel';


export class Product extends BaseModel {

    description:string;
    price:number;
    price2:number;
    price3:number;
    code:string;
    isService:boolean;
    isCompositeProduct:boolean;
    cost:number;
    sellerRate:number;
    currencyId:number;
    existence:number;
    name:string;
    details:string;
    currency :Currency
    taxes:any[];
    productUnits:any[];
    baseCompositeProducts:any[];
    suppliersCosts:any[]=[];
}
export class ProductTax extends BaseModel {

    productId:number;
    taxId:number;
    tax:Tax;
}

export class UnitProductEquivalence extends BaseModel {

         unitId:number; 
         productId:number; 
         equivalence:number;
         isPrimary :boolean;
         order :number; 
         costPrice :number;
         sellingPrice :number;
         unit:Unit;
}

export class CompositeProduct extends BaseModel {

        ProductId :number;
        currencyId:number;
        BaseProductId:number; 
        BaseProductUnitId :number;
        Quantity :number;
        TotalCost :number;
        TotalPrice :number;
        BaseProduct:Product;
        Product:Product; 
        UnitProductEquivalence: UnitProductEquivalence;
        Currency: Currency; 
}