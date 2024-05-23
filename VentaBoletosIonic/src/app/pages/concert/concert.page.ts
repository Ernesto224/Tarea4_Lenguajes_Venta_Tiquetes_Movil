import { Component } from '@angular/core';
import { TaskService } from 'src/app/task.service';

@Component({
  selector: 'app-concert',
  templateUrl: './concert.page.html',
  styleUrls: ['./concert.page.scss'],
})
export class ConcertPage {
  task: string = '';
  concerts = [
    {
      artist: 'Miley Cyrus',
      date: new Date('2024-05-23'),
      venue: 'Madison Square Garden, NY',
      image: 'path/to/miley-cyrus.jpg'
    },
    {
      artist: 'Madonna',
      date: new Date('2024-08-04'),
      venue: 'Madison Square Garden, NY',
      image: 'path/to/madonna.jpg'
    },
    // Añade más conciertos según sea necesario
  ];

  constructor(private taskService: TaskService) { }

  addTask() {
    if (this.task.trim()) {
      this.taskService.addTask(this.task);
      this.task = '';
    }
  }
}
