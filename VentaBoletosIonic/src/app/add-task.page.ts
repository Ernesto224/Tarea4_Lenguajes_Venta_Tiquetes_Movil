import { Component } from '@angular/core';
import { TaskService } from './task.service';

@Component({
  selector: 'app-add-task',
  templateUrl: './home.page.html',
  styleUrls: ['./home.page.scss'],
})
export class AddTaskPage {

  task: string='';

  constructor(private taskService: TaskService) { }

  addTask() {
    if (this.task) {
      this.taskService.addTask(this.task);
      this.task = '';
    }
  }
}
