import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { TRNControl } from './trnControlModel';
import { BranchOffice } from './branchOffice';
import { Supplier } from './Supplier';


export class Expense extends BaseModel {
   
  details :string;
 exchangeRateAmount:number;
  date :Date;
  state:string;
  branchOffice :BranchOffice;
  branchOfficeId :number;
  taxes:any[];
  currency :Currency;
  currencyId :number;
  owedAmount :number;
  givenAmount :number;
  returnedAmount :number;
  beforeTaxesAmount :number;
  taxesAmount :number;
  paidAmount :number;
  totalAmount :number;
  trn :string;
  sequence:string;
  currentPaidAmount:number;
  expenseReference:string; 
  supplier :Supplier;
  paymentType:any;
  supplierId :number;
  paymentTypeId? :number;
  numberOfDays:number;
}