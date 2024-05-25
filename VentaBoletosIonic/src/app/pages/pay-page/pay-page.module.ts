import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { PayPagePageRoutingModule } from './pay-page-routing.module';

import { PayPagePage } from './pay-page.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    PayPagePageRoutingModule
  ],
  declarations: [PayPagePage]
})
export class PayPagePageModule {}
