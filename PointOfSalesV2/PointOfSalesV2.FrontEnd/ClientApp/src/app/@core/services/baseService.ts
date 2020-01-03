
import { isNullOrUndefined } from 'util';
import { of, Observable, from } from "rxjs";
import { map } from "rxjs/operators";
import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient, HttpParams } from "@angular/common/http";
import { IPagedList } from '../data/pagedList';




export interface IService<TEntity, TKey> {
    baseUrl: string;
    get();
    getAll(): Observable<TEntity[]>;
    getById(id: TKey): Observable<TEntity>;
    post(entity: TEntity): Observable<Object>;
    patch(entity: TEntity, id: TKey): Observable<Object>;
    put(id: TKey, entity: TEntity): Observable<Object>;
    putList(entity: TEntity[]): Observable<Object>;
    delete(id: TKey): Observable<Object>;
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

    constructor(protected _httpClient: HttpClient, private _baseUrl: string) {
        this.setHttpOptions();
    }

    setHttpOptions() {
        const currentUser = JSON.parse(localStorage.getItem("currentUser"));
        this.tempHttpOptions = {
            headers: this._headers,
            params: null
        };



        this._headers = new HttpHeaders({
            "Content-Type": "application/json",
            "UserId": currentUser ? currentUser.user.userId : '',
            "LanguageId": currentUser ? currentUser.user.languageCode : 'en',
            "Authorization": currentUser ? `Bearer ${currentUser.token}` : ''
        });
        this.httpOptions = {
            headers: this._headers,
            params: null
        };
    }

    get(languageId: string = ""): Observable<TEntity[]> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<any>(
            this.baseUrl,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getAll(languageId: string = ""): Observable<TEntity[]> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        let data = this._httpClient.get<TEntity[]>(
            this.baseUrl,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
        return data;
    }

    getPaged(
        page: number,
        max: number,
        languageId: string = ""
    ): Observable<IPagedList<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        let data = this._httpClient.get<IPagedList<TEntity>>(
            `${this.baseUrl}/${page}/${max}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
        return data;
    }

    getFiltered(
        page: number,
        max: number,
        languageId: string = ""
    ): Observable<IPagedList<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        let data = this._httpClient.get<IPagedList<TEntity>>(
            `${this.baseUrl}/${page}/${max}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
        return data;
    }

    getById(id: TKey, languageId: string = ""): Observable<TEntity> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<TEntity>(
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

    post(entity: TEntity, languageId: string = ""): Observable<Object> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.post(
            this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    postList(entity: TEntity[], languageId: string = ""): Observable<Object> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.put(
            this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    putList(entity: TEntity[], languageId: string = ""): Observable<Object> {
        this.setHttpOptions();
        return this._httpClient.put(
            this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    patch(
        entity: TEntity,
        id: TKey,
        languageId: string = ""
    ): Observable<Object> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.patch(this.baseUrl + "/" + id, entity);
    }

    put(id: TKey, entity: TEntity, languageId: string = ""): Observable<Object> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.put(
            this.baseUrl + "/" + id,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    delete(id: TKey, languageId: string = ""): Observable<Object> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.delete(
            this.baseUrl + "/" + id,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getByUrlParameters(
        params: string[],
        languageId: string = ""
    ): Observable<TEntity[]> {
        let urlParams = params.join("/");
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<TEntity[]>(
            `${this.baseUrl}/${urlParams}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }

    getSingleByUrlParameters(
        params: string[],
        languageId: string = ""
    ): Observable<TEntity> {
        let urlParams = params.join("/");
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.get<TEntity>(
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