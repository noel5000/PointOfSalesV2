import { BaseModel } from './baseModel';
import { BranchOffice } from './branchOffice';
import { Currency } from './currencyModel';
import { User } from './users';
import { CashRegister } from './cashRegister';


export class CashRegisterOpening extends BaseModel {
      userId :string;
      currencyId :number;
      cashRegisterId :number;
      branchOfficeId :number;
      openingDate :Date;
      maxClosureDate :Date;
      closureDate :Date;
      totalPaymentsAmount :number;
      openingClosureDifference :number;
      userName :string;
      details:OpeningType[];
      state :string;
      totalOpeningAmount :number;
      totalClosureAmount :number;
      cashRegister :CashRegister;
      isClosing:boolean=false;
      user: User;
      currency :Currency;
      branchOffice: BranchOffice; 
}
export class OpeningType extends BaseModel{
      type:string;
      cashRegisterOpeningId:number;
      details:string;
      isClosing:boolean;
      totalAmount:number=0;

  }