import { Component} from '@angular/core';
import { TaskService } from 'src/app/task.service';
@Component({
  selector: 'app-concert',
  templateUrl: './concert.page.html',
  styleUrls: ['./concert.page.scss'],
})
export class ConcertPage {
  task: string='';
  constructor(private concertService: TaskService) { }
  addTask() {
    if (this.task) {
      this.concertService.addTask(this.task);
      this.task = '';
    }
  }
}
