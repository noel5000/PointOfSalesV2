export class BaseResultModel<T>{
    id: number = 0;
    status: number = -1;
    message: string = '';
    exception: any = null;
    data: T[] = [];
    totalItemCount: number = 0;
    count: number = 0;
    pageCount: number = 0;
    currentPage: number = 0;
}
