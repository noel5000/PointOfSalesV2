import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { TRNControl } from './trnControlModel';
import { BranchOffice } from './branchOffice';
import { Supplier } from './Supplier';
import { Expense } from './expenseModel';


export class ExpensePayment extends BaseModel {
   
  details :string;
 exchangeRateAmount:number;
 exchangeRate:number;
  date :Date;
  state:string;
  branchOffice :BranchOffice;
  branchOfficeId :number;
  taxes:any[];
  currency :Currency;
  currencyId :number;
  outstandingAmount :number;
  currentPaidAmount:number;
  givenAmount :number;
  returnedAmount :number;
  beforeTaxesAmount :number;
  taxesAmount :number;
  paidAmount :number;
  totalAmount :number;
  expenseCurrencyId :number;
  expenseCurrency:Currency;
  expenseId:number;
  expenseReference:string; 
  supplier :Supplier;
  paymentType:any;
  supplierId :number;
  paymentTypeId :number;
  numberOfDays:number;
  sequence:string;
  expense:Expense;
  currentOutstandingAmount:number;
}