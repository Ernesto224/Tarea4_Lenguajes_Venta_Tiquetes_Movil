import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient, HttpParams } from '@angular/common/http';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-pay-page',
  templateUrl: './pay-page.page.html',
  styleUrls: ['./pay-page.page.scss'],
})
export class PayPagePage implements OnInit {
  concertId: number | null = null;
  concert: any;
  concerts: any[] = [];
  
  tarjetahabiente: string = '';
  numeroTarjeta: string = '';
  fechaVencimiento: string = '';
  cvv: string = '';

  cantidadAsientos: number = 0;
  zona: string = '';
  asientos: string[] = [];

  usuario: any; 

  constructor(private route: ActivatedRoute, private http: HttpClient) { }

  ngOnInit() {
    const usuarioString = sessionStorage.getItem('usuarioData');

    if (usuarioString) {
      this.usuario = JSON.parse(usuarioString);
      console.log('Usuario:', this.usuario);
    } else {
      console.error('No se encontró ningún usuario en sessionStorage');
    }

    const idParam = this.route.snapshot.paramMap.get('id');
    if (idParam) {
      this.concertId = +idParam;
      this.obtenerConciertos();
    } else {
      console.error('ID del concierto no encontrado en la URL');
    }

    this.route.queryParams.subscribe(params => {
      this.cantidadAsientos = +params['cantidadAsientos'] || 0;
      this.zona = params['zona'] || '';
      this.asientos = Array.isArray(params['asientos']) ? params['asientos'] : params['asientos'].split(','); 

      console.log('Cantidad de Asientos:', this.cantidadAsientos);
      console.log('Zona:', this.zona);
      console.log('Asientos:', this.asientos);

      // Separar los datos de idAsiento y codigoAsiento y mostrarlos en la consola
      this.asientos.forEach(asiento => {
        const [idAsiento, codigoAsiento] = asiento.split('-');
        console.log('idAsiento:', idAsiento);
        console.log('codigoAsiento:', codigoAsiento);
      });
    });
  }

  obtenerConciertos() {
    this.http.get<any[]>("https://localhost:7114/api/Concierto").subscribe(
      response => {
        this.concerts = response;
        if (this.concertId !== null) {
          this.concert = this.concerts.find(c => c.idConcierto === this.concertId);
        }
      }
    );
  }

  comprar() {
    console.log('Comprando...', {
      tarjetahabiente: this.tarjetahabiente,
      numeroTarjeta: this.numeroTarjeta,
      fechaVencimiento: this.fechaVencimiento,
      cvv: this.cvv
    });
  
    const fechaCompra = formatDate(new Date(), 'yyyy-MM-dd HH:mm:ss', 'en-US');
  
    this.asientos.forEach(asiento => {
      const [idAsiento, codigoAsiento] = asiento.split('-');
      
      // Realizar la solicitud PUT a la API de Asientos
      this.http.put("https://localhost:7114/api/Asientos", {}, { params: { idAsiento } }).subscribe(response => {
        console.log("PUT ASIENTOS: ", response);
      });
  
      // Construir los parámetros de la solicitud POST a la API de Reservas
      const reservaParams = new HttpParams()
        .set('idUsuario', this.usuario.idUsuario)
        .set('idAsiento', idAsiento)
        .set('fechaCompra', fechaCompra);
  
      // Realizar la solicitud POST a la API de Reservas
      this.http.post("https://localhost:7114/api/Reservas", {}, { params: reservaParams }).subscribe(response => {
        console.log("Post Reservas: ", response);
      });
    });
  }  
  get formattedAsientos(): string {
    return this.asientos.map(asiento => asiento.split('-')[1]).join(', ');
  }
  
}
