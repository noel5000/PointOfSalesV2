import { Observable } from 'rxjs';
import { AppSections, Operations } from '../common/enums';

export class User {
  name: string = '';
  picture: string = '';
  userId: string = '';
  languageCode: string = '';
  active: boolean = false;
  language: any = null;
  tokenKey: string = '';
  lastName: string = '';
  birthDay: Date;
  phone: string = '';
  mobile: string = '';
  address: string = '';
  userName: string = '';
  password: string = '';
  email: string = '';
  contentType: string = '';
  width: number = 0;
  height: number = 0;
  size: number = 0;
  branchOfficeId?: number;
  cashRegisterId?: number;
  warehouseId?: number;
  cashRegisterOpenningTimeHours: number = 0;
  fullName = (): string => `${this.name} ${this.lastName}`;
  gender: string = '';
  branchOffice: any = null;
  cashRegister: any = null;
  warehouse: any = null;
  claims: any[] = [];
  permissions: UserOperation[] = [];
}

export class UserOperation {
  operationId: number;
  sectionId: number;
  sectionName = (): string => {
    return AppSections[this.sectionId];
  }
  operationName = (): string => {
    return Operations[this.operationId];
  }

}
export interface Contacts {
  user: User;
  type: string;
}

export interface RecentUsers extends Contacts {
  time: number;
}

export abstract class UserData {
  abstract getUsers(): Observable<User[]>;
  abstract getContacts(): Observable<Contacts[]>;
  abstract getRecentUsers(): Observable<RecentUsers[]>;
}
