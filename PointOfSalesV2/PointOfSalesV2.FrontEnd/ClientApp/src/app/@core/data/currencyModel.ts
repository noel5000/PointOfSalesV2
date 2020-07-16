import { BaseModel } from './baseModel';


export class Currency extends BaseModel {

    name: string;
    code: string;
    isLocalCurrency: boolean;
    exchangeRate: number;
    updatedRate: boolean;
}