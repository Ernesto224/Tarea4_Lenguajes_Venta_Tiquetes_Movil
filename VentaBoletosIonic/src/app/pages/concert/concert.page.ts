import { Component, OnInit } from '@angular/core';
import { TaskService } from 'src/app/task.service';
import { HttpClient } from '@angular/common/http';
import { Route, Router } from '@angular/router';
@Component({
  selector: 'app-concert',
  templateUrl: './concert.page.html',
  styleUrls: ['./concert.page.scss'],
})
export class ConcertPage implements OnInit {
  task: string = '';
  concerts: any[] = [];
  ngOnInit(): void {
    this.obtenerConciertos();
  }
  constructor(private taskService: TaskService, private http: HttpClient, private route:Router) { }

  addTask() {
    if (this.task.trim()) {
      this.taskService.addTask(this.task);
      this.task = '';
    }
  }
  obtenerConciertos() {
    this.http.get<any>("https://localhost:7114/api/Concierto").subscribe(response => {
      this.concerts = response;
      console.log(response);
    });
  }
  openConcertDetail(concertId: number) {
    this.route.navigate(['/detail-concert', concertId]);
  }
}
