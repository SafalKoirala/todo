import { Component, OnInit } from '@angular/core';
import { TodoService } from '../todo.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private service:TodoService) { }
  users: object;

  ngOnInit() {
    this.addUser();
  }
  addUser(){   
      // return this.http.post(this.baseUrl+'/Users',val); 
  }
}
