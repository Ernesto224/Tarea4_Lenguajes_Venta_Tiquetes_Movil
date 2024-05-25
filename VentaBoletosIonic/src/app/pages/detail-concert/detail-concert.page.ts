import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
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
  asientos: any[] = [];
  zonas: any[] = []; // Lista de zonas
  asientosDisponibles: any[] = []; // Lista de asientos
  

  constructor(private route: ActivatedRoute, private http: HttpClient, private router: Router) {}

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

  cargarDatosDinamicos() {
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

  obtenerConciertos() {
    this.http.get<any[]>(`https://localhost:7114/api/TipoZona?idConcierto=${this.concertId}`).subscribe(
      response => {
        this.zonas = response;
      }
    );
  }

  obtenerDatosSeleccionados() {
    console.log('Cantidad de Asientos:', this.cantidadAsientos);
    let zona = this.zonas.find(valor => valor.idTipoZona === this.zona);
    console.log('Zona:', zona.nombreZona);
    console.log('Asientos:', this.asientos);

    // Redireccionar a la página de pago con los datos seleccionados
    this.router.navigate(['/pay-page', this.concertId], {
      queryParams: {
        cantidadAsientos: this.cantidadAsientos,
        zona: zona.nombreZona,
        asientos: this.asientos
      }
    });
  }

  cargarAsientosDisponibles() {
    this.http.get<any[]>(`https://localhost:7114/api/Asientos?idConcierto=${this.concertId}&idTipoZona=${this.zona}`).subscribe(
      response => {
        this.asientosDisponibles = response;
        console.log(this.asientosDisponibles);
      }
    );
  }

  onSelectionChange() {
    if (this.asientos.length - 1 >= this.cantidadAsientos) {
      for (let index = 0; this.cantidadAsientos < this.asientos.length; index++) {       
        this.asientos.pop();  
      }
    }
  }
}
