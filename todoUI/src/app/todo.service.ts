import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
readonly APIUrl = "http://localhost:52121/api";

  constructor(private http : HttpClient) { }

    listUsers(){
      return this.http.get(this.APIUrl+'/Users');
    }


  
}
