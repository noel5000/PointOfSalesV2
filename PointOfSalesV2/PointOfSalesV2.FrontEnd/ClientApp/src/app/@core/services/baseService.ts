
import { isNullOrUndefined } from 'util';
import { of, Observable, from } from "rxjs";
import { map } from "rxjs/operators";
import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient, HttpParams } from "@angular/common/http";
import { IPagedList } from '../data/pagedList';
import { BaseResultModel } from '../data/baseResultModel';
import { AuthModel } from './../data/authModel';
import { QueryFilter, ObjectTypes } from '../common/enums';




export interface IService<TEntity, TKey> {
    baseUrl: string;
    get();
    getAll(): Observable<BaseResultModel<TEntity>>;
    getById(id: TKey): Observable<BaseResultModel<TEntity>>;
    post(entity: TEntity): Observable<BaseResultModel<TEntity>>;
    patch(entity: TEntity, id: TKey): Observable<BaseResultModel<TEntity>>;
    put(id: TKey, entity: TEntity): Observable<BaseResultModel<TEntity>>;
    putList(entity: TEntity[]): Observable<BaseResultModel<TEntity>>;
    delete(id: TKey): Observable<BaseResultModel<TEntity>>;
}

@Injectable({
    providedIn: "root"
})
export class BaseService<TEntity, TKey> implements IService<TEntity, TKey> {
    public get baseUrl(): string {
        return this._baseUrl;
    }
    public set baseUrl(value: string) {
        this._baseUrl = value;
    }
    _headers: HttpHeaders;
    httpOptions = {};

    tempHttpOptions = {};

    constructor(protected _httpClient: HttpClient,
        
        private _baseUrl: string) {
        this.setHttpOptions();
    }

    setHttpOptions() {
        const currentUser = JSON.parse(localStorage.getItem("currentUser")) as AuthModel;
        this.tempHttpOptions = {
            headers: this._headers,
            params: null
        };



        this._headers = new HttpHeaders({
            "Content-Type": "application/json",
            "UserId": currentUser ? currentUser.user.userId : '',
            "LanguageId": currentUser ? currentUser.languageId : 'en',
            "Authorization": currentUser ? `Bearer ${currentUser.token}` : ''
        });
        this.httpOptions = {
            headers: this._headers,
            params: null
        };
    }

    get(languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<any>(
            this.baseUrl,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getGeneral(languageId: string = ""): Observable<any> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<any>(
            this.baseUrl,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getAll(languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        let data = this._httpClient.get<BaseResultModel<TEntity>>(
            this.baseUrl,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
        return data;
    }

    getPaged(
        page: number,
        max: number,
        languageId: string = ""
    ): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        let data = this._httpClient.get<BaseResultModel<TEntity>>(
            `${this.baseUrl}/${page}/${max}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
        return data;
    }

    getFiltered(
        page: number,
        max: number,
        filters: QueryFilter[] = [],
        orderBy: string = '',
        direction: string = 'desc',
        languageId: string = ""
    ): Observable<any> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        let data = this._httpClient.get<any>(
            `${this.baseUrl.replace('/api/','/odata/')}?${this.getODataQuery(filters, page, max, orderBy, direction)}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
       
        return data;
    }

    getODataQuery(filters: QueryFilter[], page: number, max: number, orderBy: string, direction: string): string {
        let result = '';
        let query = '$filter=';
        filters.forEach(f => {
            switch (f.type) {
                case ObjectTypes.String:
                    query =!f.isTranslated? `${query}contains(@word,${f.property})&@word='${f.value}' and '`:
                    `${query}contains(@word,${'translationData'})&@word='${f.value}' and '`
                    ;
                    break;
                case ObjectTypes.Number:
                    query = `${query}${f.property} eq ${f.value} and `;
                    break;
                case ObjectTypes.Date:
                    query = `${query}${f.property} eq '${f.value}' and `;
                    break;
                case ObjectTypes.Boolean:
                    query = `${query}${f.property} eq ${f.value} and `;
                    break;
            }
        })
        result = query.length > 8 ? `${result}${query}` : result;
        if (result.endsWith(" and '")|| result.endsWith(" and ")) {
            result = result.substring(0, result.length - 5);
        }
        const skipVal=((page-1) * max)<0?0:(page-1) * max;
        result = `${result}${result.length > 8 ? '&' : ''}$skip=${skipVal}&$count=true&$top=${max}&$orderby=${orderBy} ${direction}`;

        return result;
    }

    getById(id: TKey, languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<BaseResultModel<TEntity>>(
            this.baseUrl + "/" + id,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    public setLanguageInHeaders(languageId: string) {
        if (languageId) {
            let tempHeader = this._headers;
            let headers = languageId
                ? tempHeader.set("LanguageId", languageId)
                : tempHeader;

            this.tempHttpOptions['headers'] = headers;
            this.tempHttpOptions['params'] = this.httpOptions['params'];
        }
    }

    post(entity: TEntity, languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.post<BaseResultModel<TEntity>>(
            this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    postList(entity: TEntity[], languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.put<BaseResultModel<TEntity>>(
            this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    putList(entity: TEntity[], languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        return this._httpClient.put<BaseResultModel<TEntity>>(
            this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    patch(
        entity: TEntity,
        id: TKey,
        languageId: string = ""
    ): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.patch<BaseResultModel<TEntity>>(this.baseUrl + "/" + id, entity);
    }

    put(id: TKey, entity: TEntity, languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.put<BaseResultModel<TEntity>>(
            this.baseUrl + "/" + id,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    delete(id: TKey, languageId: string = ""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.delete<BaseResultModel<TEntity>>(
            this.baseUrl + "/" + id,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getByUrlParameters(
        params: string[],
        languageId: string = ""
    ): Observable<BaseResultModel<TEntity>> {
        let urlParams = params.join("/");
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<BaseResultModel<TEntity>>(
            `${this.baseUrl}/${urlParams}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getSingleByUrlParameters(
        params: string[],
        languageId: string = ""
    ): Observable<BaseResultModel<TEntity>> {
        let urlParams = params.join("/");
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<BaseResultModel<TEntity>>(
            `${this.baseUrl}/${urlParams}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getGenericByUrlParameters(
        params: string[],
        languageId: string = ""
    ): Observable<any> {
        let urlParams = params.join("/");
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<any>(
            `${this.baseUrl}/${urlParams}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    // requestResolver(request: any): Observable<TEntity[]> {
    //   const entity = from<TEntity[]>(request.pipe(map(d => d["data"])));

    //   if (!isNullOrUndefined(entity)) {
    //     return entity;
    //   }

    //   return request;
    // }

    // requestResolverPaged(request: any): Observable<IPagedList<TEntity>> {
    //   let entity = from<IPagedList<TEntity>>(request.pipe(map(d => d["data"])));

    //   if (!isNullOrUndefined(entity)) {
    //     return entity;
    //   }

    //   return request;
    // }


    // genericRequestResolver<T>(request: any): Observable<T[]> {
    //   const entity = from<T[]>(request.pipe(map(d => d["data"])));

    //   if (!isNullOrUndefined(entity)) {
    //     return entity;
    //   }

    //   return request;
    // }
}
