import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SigInPage } from './sig-in.page';

const routes: Routes = [
  {
    path: '',
    component: SigInPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SigInPageRoutingModule {}
