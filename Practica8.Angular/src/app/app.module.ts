import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AbmEmployeesModule } from './abmEmployees/abmEmployees.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AbmEmployeesModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
