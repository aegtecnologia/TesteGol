import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{HttpClientModule} from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AeronavesListagemComponent } from './aeronaves-listagem/aeronaves-listagem.component';
import{AeronaveService} from './aeronave.service'


@NgModule({
  declarations: [
    AppComponent,
    AeronavesListagemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [AeronaveService],
  bootstrap: [AppComponent]
})
export class AppModule { }
