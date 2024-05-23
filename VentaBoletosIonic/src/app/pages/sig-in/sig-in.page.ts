import { Component, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';
import { HttpClient, HttpParams } from '@angular/common/http';


@Component({
  selector: 'app-sig-in',
  templateUrl: './sig-in.page.html',
  styleUrls: ['./sig-in.page.scss'],
})
export class SigInPage implements OnInit {
  correoElectronico: string = '';
  contrasenia: string = '';
  constructor(private router: Router, private http:HttpClient) { }

  ngOnInit() {
    console.log("");
  }
  enviarDatos() {
  const params = new HttpParams()
    .set('correoElectronico', this.correoElectronico)
    .set('contrasenia', this.contrasenia);

  this.http.get<any>("https://localhost:7114/api/Usuario", { params }).subscribe(response => {
    console.log(response);
    if(response !== null){
      this.irPaginaPrincipal();
    }
  });
}
  irAlRegistroUsuario(){
    this.router.navigate(['/register']);
  }
  irPaginaPrincipal(){
    this.router.navigate(['/home/:id']);
  }
  

}
