
import { HttpClient, HttpResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Response } from '../../shared/response.model';

//import { OidcSecurityService } from 'angular-auth-oidc-client';



export class BaseService {
  protected http: HttpClient;
  //protected securityService: OidcSecurityService;
  protected endpoint: string;
  protected response: Response;

  public options =
    {
      headers: new HttpHeaders(),
      params: new HttpParams()
    };

  constructor
    (
    http: HttpClient,
    //securityService: OidcSecurityService,
    baseEndpoint: string = ''
  ) {
    debugger;;
    this.http = http;
    //this.securityService = securityService;
    this.endpoint = baseEndpoint;
  }

 
  //protected setHeaders() {
  //  this.options.headers = new HttpHeaders()
  //    .set('Content-Type', 'application/json')
  //    .set('Accept', 'application/json');

  //  //let token = this.securityService.getToken();
  //  //if (token !== '')
  //  //{
  //  //	let tokenValue = 'Bearer ' + token;
  //  //	this.options.headers = this.options.headers.set('Authorization', tokenValue);
  //  //}
  //}

  //protected extractSelectListValues(list: SelectListItem[]): string {
  //  let values: string[] = [];
  //  list
  //    .filter(i => i.selected)
  //    .forEach(i => { values.push(i.value); });
  //  return values.join(',');
  //}
  protected get(url): Response {
    this.http.get<Response>(url).subscribe(result => {
      this.response = result;
    }, error => console.error(error));
    return this.response;
  }

  //protected getEntity<T>(params: HttpParams = null, endpoint: string = this.endpoint): Observable<T> {
  //  if (params)
  //    this.options.params = params;

  //  return this.http
  //    .get<T>(endpoint, this.options)
  //    .catch(this.handleError);
  //}

  //protected findEntities<T>(params: HttpParams = null, endpoint: string = this.endpoint): Observable<Array<T>> {
  //  if (params)
  //    this.options.params = params;

  //  return this.http
  //    .get<Array<T>>(endpoint, this.options)
  //    .catch(this.handleError);
  //}

  //protected addEntity<T>(data: T, endpoint: string = this.endpoint): Observable<T> {
  //  return this.http
  //    .post<T>
  //    (
  //    endpoint,
  //    data,
  //    this.options
  //    )
  //    .catch(this.handleError);
  //}

  //protected updateEntity<T>(data: T, id: string, endpoint: string = this.endpoint): Observable<T> {
  //  return this.http
  //    .put<T>
  //    (
  //    endpoint + '/' + id,
  //    data,
  //    this.options
  //    )
  //    .catch(this.handleError);
  //}

  //protected deleteEntity<T>(data: T, id: string, endpoint: string = this.endpoint): Observable<T> {
  //  return this.http
  //    .delete<T>
  //    (
  //    endpoint + '/' + id,
  //    this.options
  //    )
  //    .catch(this.handleError);

  //}

  //protected extractData(res: Response) {
  //  let data = res.json() || [];
  //  return data;
  //}

  //protected handleError(error: any) {
  //  let errMsg =
  //    (error.message) ? error.message
  //      : error.status ? `${error.status} - ${error.statusText}`
  //        : 'Server error';

  //  console.error(errMsg);
  //  return Observable.throw(errMsg);
  //}
}
