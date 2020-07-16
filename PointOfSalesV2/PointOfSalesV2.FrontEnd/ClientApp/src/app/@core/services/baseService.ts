
import { isNullOrUndefined } from 'util';
import { of, Observable, from } from "rxjs";
import { map, filter } from "rxjs/operators";
import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient, HttpParams } from "@angular/common/http";
import { IPagedList } from '../data/pagedList';
import { BaseResultModel } from '../data/baseResultModel';
import { AuthModel } from './../data/authModel';
import { QueryFilter, ObjectTypes } from '../common/enums';




export interface IService<TEntity, TKey> {
    baseUrl: string;
    get();
    getAll(): Observable<TEntity[]>;
    getById(id: TKey): Observable<BaseResultModel<TEntity>>;
    post(entity: TEntity): Observable<BaseResultModel<TEntity>>;
    patch(entity: TEntity, id: TKey): Observable<BaseResultModel<TEntity>>;
    put(entity: TEntity): Observable<BaseResultModel<TEntity>>;
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

    setHttpOptions(responseType:string="") {
        const currentUser = JSON.parse(localStorage.getItem("currentUser")) as AuthModel;
        this.tempHttpOptions = {
            headers: this._headers,
            params: null,
            responseType:responseType?responseType:'application/json'
        };

        


        this._headers = new HttpHeaders({
            "Content-Type": responseType?responseType:"application/json",
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

    downLoadFile(data: any, type: string, fileName:string='Report', fileExt:string='xls') {
        let blob = new Blob([data], { type: type});
        let url = window.URL.createObjectURL(blob);
        var anchor = document.createElement("a");
anchor.download = `${fileName}.${fileExt}`;
anchor.href = url;
anchor.click();
        
    }

    getAllFiltered(
        filters: QueryFilter[] = [],
        languageId: string = ""
    ): Observable<any> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        let data = this._httpClient.get<any>(
            `${this.baseUrl.replace('/api/','/odata/')}?${this.getODataQueryAll(filters)}`,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
       
        return data;
    }

    getAllFilteredToExport(
        filters: QueryFilter[] = [],
        languageId: string = ""
    ): Observable<Blob> {
        const currentUser = JSON.parse(localStorage.getItem("currentUser")) as AuthModel;
        return this._httpClient.post(`${this.baseUrl}/exporttoexcel`,
        {filters}
        ,{responseType:'blob',
        headers:new HttpHeaders({
            "UserId": currentUser ? currentUser.user.userId : '',
            "LanguageId": currentUser ? currentUser.languageId : 'en',
            "Authorization": currentUser ? `Bearer ${currentUser.token}` : ''
        })})
    }

    exportToExcel(
        data:any={},
        url:string="",
        languageId: string = "",
    ): Observable<Blob> {
        const currentUser = JSON.parse(localStorage.getItem("currentUser")) as AuthModel;
        return this._httpClient.post(`${this.baseUrl}${url?'/'+url:''}`,
        data
        ,{responseType:'blob',
        headers:new HttpHeaders({
            "UserId": currentUser ? currentUser.user.userId : '',
            "LanguageId": currentUser ? currentUser.languageId : 'en',
            "Authorization": currentUser ? `Bearer ${currentUser.token}` : ''
        })})
    }

    getODataQuery(filters: QueryFilter[], page: number, max: number, orderBy: string, direction: string): string {
        let result = '';

        const expandFilters = filters.filter(x=>x.type== ObjectTypes.ChildObject);
        if(expandFilters && expandFilters.length>0){
            let expandResult='$expand=';
            for(let i=0;i<expandFilters.length;i++){
                expandResult+=`${expandFilters[i].property}${expandFilters[i].value?`($select=${expandFilters[i].value})`:''}${i==expandFilters.length-1?'&':','}`;
            }
          result+=expandResult;
        }
        let query = '$filter=';
      
        filters.forEach(f => {
            let comparer= f.comparer?f.comparer.toString():'eq';
            switch (f.type) {
                
                case ObjectTypes.String:
                    query =!f.isTranslated? `${query}(contains(toLower(${f.property}), '${f.value}')) and `:
                    `${query}(contains(toLower(TranslationData), '${f.value}')) and `
                    ;
                    break;
                case ObjectTypes.Number:
                    query = `${query}(${f.property} ${comparer} ${f.value}) and `;
                    break;
                case ObjectTypes.Date:
                    query = `${query}(${f.property} ${comparer} '${f.value}') and `;
                    break;
                case ObjectTypes.Boolean:
                    query = `${query}(${f.property} ${comparer} ${f.value}) and `;
                    break;
            }
        })
        result = query.length > 8 ? `${result}${query}` : result;
        if (result.endsWith(" and '")|| result.endsWith(" and ")) {
            result = result.substring(0, result.length - 5);
        }

        if (result.endsWith("&")) {
            result = result.substring(0, result.length - 1);
        }
        const skipVal=((page-1) * max)<0?0:(page-1) * max;
        result = `${result}${result.length > 8 ? '&' : ''}$skip=${skipVal}&$count=true&$top=${max}&$orderby=${orderBy} ${direction}`;

        return result;
    }

    getODataQueryAll(filters: QueryFilter[]): string {
        let result = '';

        const expandFilters = filters.filter(x=>x.type== ObjectTypes.ChildObject);
        if(expandFilters && expandFilters.length>0){
            let expandResult='$expand=';
            for(let i=0;i<expandFilters.length;i++){
                expandResult+=`${expandFilters[i].property}${expandFilters[i].value?`($select=${expandFilters[i].value})`:''}${i==expandFilters.length-1?'&':','}`;
            }
            result+=expandResult;
        }
        let query = '$filter=';
      
        filters.forEach(f => {
            let comparer= f.comparer?f.comparer.toString():'eq';
            switch (f.type) {
                case ObjectTypes.String:
                    query =comparer=='eq'?( !f.isTranslated? `${query}(contains(toLower(${f.property}), '${f.value}')) and `:
                    `${query}(contains(toLower(TranslationData), '${f.value}')) and `):
                    (`${query}(${f.property} ${comparer} '${f.value}') and `);
                    break;
                case ObjectTypes.Number:
                    query = `${query}(${f.property} ${comparer} ${f.value}) and `;
                    break;
                case ObjectTypes.Date:
                    query = `${query}(${f.property} ${comparer} '${f.value}') and `;
                    break;
                case ObjectTypes.Boolean:
                    query = `${query}(${f.property} ${comparer} ${f.value}) and `;
                    break;
            }
        })
        result = query.length > 8 ? `${result}${query}` : result;
        if (result.endsWith(" and '")|| result.endsWith(" and ")) {
            result = result.substring(0, result.length - 5);
        }

        if (result.endsWith("&")) {
            result = result.substring(0, result.length - 1);
        }
      
        result = `${result}`;

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

    post(entity: TEntity, languageId: string = "", optionalUrl=""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.post<BaseResultModel<TEntity>>(
          optionalUrl?`${this.baseUrl}/${optionalUrl}`:  this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    postList(entity: TEntity[], languageId: string = "", optionalUrl:string=''): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.put<BaseResultModel<TEntity>>(
            optionalUrl?`${this.baseUrl}/${optionalUrl}`:  this.baseUrl,
            entity,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
    putList(entity: TEntity[], languageId: string = "", optionalUrl:string=""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        return this._httpClient.put<BaseResultModel<TEntity>>(
            optionalUrl?`${this.baseUrl}/${optionalUrl}`:  this.baseUrl,
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

    put(entity: TEntity, languageId: string = "",optionalUrl:string=""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        entity=this.SetTranslationData(entity);
        return this._httpClient.put<BaseResultModel<TEntity>>(
            optionalUrl?`${this.baseUrl}/${optionalUrl}`:  this.baseUrl,
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

    deleteGeneric(id: string, languageId: string = "", optionalUrl:string=""): Observable<BaseResultModel<TEntity>> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.delete<BaseResultModel<TEntity>>(
            optionalUrl?`${this.baseUrl}/${optionalUrl}/${id}`:  `${this.baseUrl}/${id}`,
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

    SetTranslationData(data:TEntity):TEntity{
        if(data['translationData'])
        data['translationData']=null;
        return data;
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

    patchGenericByUrlParameters(
        params: string[],
        languageId: string = "",
        data:any=null
    ): Observable<any> {
        let urlParams = params.join("/");
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.patch<any>(
            `${this.baseUrl}/${urlParams}`,
            data,
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
