import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';
import { debug } from 'util';
import { User } from '../../shared/user.model';
import { Response } from '../../shared/response.model';

//import { UserService } from '../service/user.service'

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent{

  
  public users: User[];
  public response: Response;


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl) {
  
    http.get<Response>(baseUrl + 'api/User/GetUsers').subscribe(result => {
      this.response = result;
      
      if (result.status == true) {
        this.users = result.data;
      }
      console.log(this.users);
    }, error => console.error(error));
  }

  ngOnInit() {
   
  }

}

