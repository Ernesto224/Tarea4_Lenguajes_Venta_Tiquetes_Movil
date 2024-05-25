import { Component, OnInit } from '@angular/core';
import { TaskService } from 'src/app/task.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.page.html',
  styleUrls: ['./ticket.page.scss'],
})
export class TicketPage implements OnInit {
  groupedTickets: any[] = [];
  usuario: any;

  constructor(private ticketService: TaskService, private http: HttpClient) { }

  ngOnInit() {
    const usuarioString = sessionStorage.getItem('usuarioData');

    if (usuarioString) {
      this.usuario = JSON.parse(usuarioString);
      console.log('Usuario:', this.usuario);
      this.obtenerConciertos();
    } else {
      console.error('No se encontró ningún usuario en sessionStorage');
    }
  }

  obtenerConciertos() {
    const idUsuario = this.usuario.idUsuario;
    this.http.get<any[]>(`https://localhost:7114/api/Reservas/${idUsuario}`).subscribe(response => {
      this.groupedTickets = response;
      console.log(response);
    });
  }

}