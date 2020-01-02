import { User } from './users';

export class AuthModel {
    status: number = -1;
    token: string = '';
    expiration: Date;
    user: User = null;
}
