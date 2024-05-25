import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms'; // Agregado

import { RegisterPage } from './register.page';

const routes: Routes = [
  {
    path: '',
    component: RegisterPage
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes),
    FormsModule // Agregado FormsModule aquí
  ],
  exports: [RouterModule],
})
export class RegisterPageRoutingModule {}

