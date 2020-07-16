import { BaseModel } from './baseModel';
import { Zone } from './zoneModel';


export class Seller extends BaseModel {

   
    name:string;
    cardId :string;
    phoneNumber :string;
    address :string;
    code :string;
    zoneId :number;
    comissionRate:number; 
    comissionByProduct :boolean;
    fixedComission :boolean;
    nameAndCode:string;
    zone: Zone; 
}