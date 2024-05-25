import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-detail-concert',
  templateUrl: './detail-concert.page.html',
  styleUrls: ['./detail-concert.page.scss'],
})
export class DetailConcertPage implements OnInit {
  concertId: number | null = null;
  concert: any;
  concerts: any[] = [];
  cantidadAsientos: number = 0;
  zona: string = '';
  asientos: string = '';
  zonas: string[] = []; // Lista de zonas
  asientosDisponibles: string[] = []; // Lista de asientos
  

  constructor(private route: ActivatedRoute, private http: HttpClient) {}

  ngOnInit() {
    const idParam = this.route.snapshot.paramMap.get('id');
    if (idParam) {
      this.concertId = +idParam;
      this.obtenerConciertos();
    } else {
      console.error('ID del concierto no encontrado en la URL');
    }
    this.cargarDatosDinamicos();
  }

  obtenerConciertos() {
    this.http.get<any[]>("https://localhost:7114/api/Concierto").subscribe(
      response => {
        this.concerts = response;
        if (this.concertId !== null) {
          this.concert = this.concerts.find(c => c.idConcierto === this.concertId);
          console.log(this.concert);
        }
      }
    );
  }
  cargarDatosDinamicos() {
    // Aquí puedes reemplazar estos datos con una llamada a un API si es necesario
    this.zonas = ['VIP', 'Platea', 'General'];
  }
  obtenerDatosSeleccionados() {
    console.log('Cantidad de Asientos:', this.cantidadAsientos);
    console.log('Zona:', this.zona);
    console.log('Asientos:', this.asientos);
  }
  cargarAsientosDisponibles() {
    this.asientosDisponibles = this.obtenerAsientosDisponiblesPorZona(this.zona);
  }
  
  obtenerAsientosDisponiblesPorZona(zona: string): string[] {
    if (zona === 'VIP') {
      console.log("VIP");
      return ['Asiento A1', 'Asiento A2', 'Asiento A3'];
    } else if (zona === 'Zona B') {
      return ['Asiento B1', 'Asiento B2', 'Asiento B3'];
    } else {
      return [];
    }
  }
  
  
}
