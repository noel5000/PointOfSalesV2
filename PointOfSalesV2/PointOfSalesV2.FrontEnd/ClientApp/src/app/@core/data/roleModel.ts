import { Unit } from './unitModel';
import { BaseModel } from './baseModel';


export class Role extends Unit {
}

export class UserRole extends BaseModel{
    userId:string;
    roleId:number;
}