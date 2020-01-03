export interface IPagedList<T> {
    TotalItemCount: number;
    Count: number;
    PageCount: number
    CurrentPage: number
    Data: T[];


}