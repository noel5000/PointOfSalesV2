import { BaseModel } from './baseModel';


export class TRNControl extends BaseModel {

    name: string;
    series:string; 
    type:string;
    sequence :number;
    numericControl :number;
    quantity :number;
}