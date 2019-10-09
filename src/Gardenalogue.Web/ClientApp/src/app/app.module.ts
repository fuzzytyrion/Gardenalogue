import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { GardensComponent } from './gardens/gardens.component';
import { GardenService } from './services/garden.service';

@NgModule({
  declarations: [
    AppComponent,
    GardensComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [GardenService],
  bootstrap: [AppComponent]
})
export class AppModule { }
