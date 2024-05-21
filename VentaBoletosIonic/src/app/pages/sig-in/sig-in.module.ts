import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { SigInPageRoutingModule } from './sig-in-routing.module';

import { SigInPage } from './sig-in.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    SigInPageRoutingModule
  ],
  declarations: [SigInPage]
})
export class SigInPageModule {}
