import { BaseModel } from './baseModel';
import { BranchOffice } from './branchOffice';


export class Warehouse extends BaseModel {

     branchOfficeId :number;
     code:string; 
     name :string;
     inventory :any[];
     branchOffice :BranchOffice; 
     
}