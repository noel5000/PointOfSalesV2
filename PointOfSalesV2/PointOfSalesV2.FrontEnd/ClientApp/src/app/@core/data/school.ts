import { BaseModel } from './baseModel';
import { Zone } from './zoneModel';


export class School extends BaseModel {

   
    name:string;
    assignedWarehouseId? :number;
    currencyId :number;
    customerId :number;
    leadDueDays :number;
    phoneNumber :string;
    address :string;
    code :string;
    zoneId? :number;
    comissionRate:number; 
    comissionByProduct :boolean;
    fixedComission :boolean;
    nameAndCode:string;
    branchOfficeId?:number;
    zone: Zone; 
    contacts:SchoolContact[];
}

export class SchoolContact extends BaseModel {

   
    name:string;
    cardId :string;
    phoneNumber :string;
    address :string;
    position :string;
    schoolId:number;
}