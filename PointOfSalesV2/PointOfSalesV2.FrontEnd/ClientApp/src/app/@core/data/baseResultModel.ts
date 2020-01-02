export class BaseResultModel<T>{

    id: number = 0;
    status: number = -1;
    message: string = '';
    exception: any = null;
    data: T[] = [];
}
