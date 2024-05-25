import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePage } from './home.page';

const routes: Routes = [
  {
    path: '',
    component: HomePage,
    children: [
      { path: '', redirectTo: 'concert', pathMatch: 'full' },
      { path: 'ticket', loadChildren: () => import('../ticket/ticket.module').then(m => m.TicketPageModule) },
      { path: 'concert', loadChildren: () => import('../concert/concert.module').then(m => m.ConcertPageModule) }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomePageRoutingModule {}
