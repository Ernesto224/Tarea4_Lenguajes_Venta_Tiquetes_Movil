import { Component, OnInit } from '@angular/core';
import { TaskService } from 'src/app/task.service';
@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.page.html',
  styleUrls: ['./ticket.page.scss'],
})
export class TicketPage implements OnInit {
  tasks:string[]=[];
  constructor(private ticketService: TaskService) { }

  ngOnInit() {
    this.tasks = this.ticketService.getTasks();
  }

}
