import { Component, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-register',
  templateUrl: './register.page.html',
  styleUrls: ['./register.page.scss'],
})
export class RegisterPage implements OnInit {
  nombre: string = '';
  apellidos: string = '';
  fechaNacimiento: string = '';
  correoElectronico: string = '';
  contrasenia: string = '';
  id: number = 0;

  constructor(private router: Router, private http: HttpClient) { }

  ngOnInit() { }

  enviarDatos() {
    const datos = {
      idUsuario: 0,  // Cambiado de 'id' a 'idUsuario'
      nombre: this.nombre,
      apellido: this.apellidos,  // Cambiado de 'apellidos' a 'apellido'
      fechaNacimiento: this.fechaNacimiento,
      correoElectronico: this.correoElectronico,
      contrasenia: this.contrasenia
    };
    this.http.post('https://localhost:7114/api/Usuario', datos).subscribe(response => {
      console.log('Datos enviados:', response);
      if(response===true){
        this.volverInicioSesion();
      }
    }, error => {
      console.error('Error al enviar los datos:', error);
      if (error.status === 400) {
        console.error('Error de validación:', error.error);
      }
    });
  }
  

  volverInicioSesion(){
    this.router.navigate(['/sig-in'])
  };

  
  

}
