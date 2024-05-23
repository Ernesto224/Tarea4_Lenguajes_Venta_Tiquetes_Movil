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

  constructor(private route: ActivatedRoute, private http: HttpClient) {}

  ngOnInit() {
    const idParam = this.route.snapshot.paramMap.get('id');
    if (idParam) {
      this.concertId = +idParam;
      this.obtenerConciertos();
    } else {
      console.error('ID del concierto no encontrado en la URL');
    }
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
  
}
