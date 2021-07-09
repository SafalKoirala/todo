import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
readonly baseUrl = "http://localhost:52121/api";

  constructor(private http : HttpClient) { }

    listTasks(){
      return this.http.get(this.baseUrl+'/Tasks/'+1);
    }

    updateTasks(task){
      return this.http.put(this.baseUrl+'/Tasks',task);

    }

    addTasks(task){
      console.log("from service");
      console.log(task);
      return this.http.post(this.baseUrl+'/Tasks',task);
    }

    deleteTask(id){
      return this.http.delete(this.baseUrl+'/Tasks/'+id);
    }
    completedTask(task){
      return this.http.patch(this.baseUrl+'/Tasks',task);
    }

  
}
