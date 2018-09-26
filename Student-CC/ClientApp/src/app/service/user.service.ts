import { Injectable, Inject } from '@angular/core';
import { BaseService } from './base.service'
import { HttpClient, HttpResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { User } from '../../shared/user.model'
import { endianness } from 'os';
import { Response } from '../../shared/response.model';

@Injectable()
export class UserService extends BaseService {

  constructor
    (http: HttpClient, @Inject('BASE_URL') baseUrl: string)
  {
    super
      (
      http,
      baseUrl + '/user'
      );
  }


  public getuser():Response {
    return this.get(this.endpoint + '/GetUsers');
  }
}
