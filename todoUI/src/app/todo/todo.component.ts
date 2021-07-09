import { Component, OnInit } from '@angular/core';
import { TodoService } from '../todo.service';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {

  constructor(private service:TodoService) { }
  users:object;
  ngOnInit() {
    this.refreshUsers();
  }
  refreshUsers(){
    this.service.listUsers().subscribe(data=>{
      this.users=data;  
      console.log(this.users);
    });
  }
  

}
