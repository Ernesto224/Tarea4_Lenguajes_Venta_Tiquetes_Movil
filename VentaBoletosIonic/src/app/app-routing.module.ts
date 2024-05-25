import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'home',
    loadChildren: () => import('./pages/home/home.module').then(m => m.HomePageModule)
  },
  {
    path: '',
    redirectTo: 'sig-in',
    pathMatch: 'full'
  },
  {
    path: 'sig-in',
    loadChildren: () => import('./pages/sig-in/sig-in.module').then(m => m.SigInPageModule)
  },
  {
    path: 'register',
    loadChildren: () => import('./pages/register/register.module').then(m => m.RegisterPageModule)
  },
  {
    path: 'concert',
    loadChildren: () => import('./pages/concert/concert.module').then(m => m.ConcertPageModule)
  },
  {
    path: 'ticket',
    loadChildren: () => import('./pages/ticket/ticket.module').then(m => m.TicketPageModule)
  },
  {
    path: 'detail-concert/:id', // Agregar el parámetro id
    loadChildren: () => import('./pages/detail-concert/detail-concert.module').then(m => m.DetailConcertPageModule)
  },
  {
    path: 'pay-page/:id',
    loadChildren: () => import('./pages/pay-page/pay-page.module').then( m => m.PayPagePageModule)
  },

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
