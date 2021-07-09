import { Component, OnInit } from '@angular/core';
import { TodoService } from '../todo.service';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {

  constructor(private service:TodoService) { }
  tasks:object;
  ngOnInit() {
    this.refreshTasks();
  }
  refreshTasks(){
    this.service.listTasks().subscribe(data=>{
      this.tasks=data;  
      console.log(this.tasks);
    });
  }
  editTasks(task){

     this.service.updateTasks(task).subscribe(status=>{
      this.refreshTasks();
     });
  }   
  //add task
  makeTasks(task){
    console.log(task);
    this.service.addTasks(task).subscribe(status=>{
      task.taskName ="";
     
      this.refreshTasks();
      
     }); 
  }
  //delete
  removeTask(task){
    this.service.deleteTask(task.taskId).subscribe(status=>{
      this.refreshTasks();
    });
  }
  //Task done
  doneTask(task){
    this.service.completedTask(task).subscribe(status=>{
      this.refreshTasks();
    });
  }
}
