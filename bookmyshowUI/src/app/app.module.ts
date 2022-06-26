import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgSelectModule } from '@ng-select/ng-select';

import { AppComponent } from './app.component';
import { TopnavComponent } from './components/topnav';
import { MoviecardComponent } from './components/moviecard';
import { MoviedetailsComponent } from './components/moviedetails';
import { CitytheaterComponent } from './components/citytheater';
import { BookticketComponent } from './components/bookticket';
import { SelectcityComponent } from './components/selectcity';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';
import { TokenInterceptorService } from './service/token-interceptor.service';
import { ApiserviceService } from './apiservice.service';
import { TicketComponent } from './components/ticket/ticket.component';
@NgModule({
  declarations: [
    AppComponent,
    TopnavComponent,   
    MoviecardComponent, 
    MoviedetailsComponent, 
    CitytheaterComponent, 
    BookticketComponent, 
    SelectcityComponent, RegisterComponent, LoginComponent, TicketComponent
  ],
  imports: [    
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule,
    NgSelectModule,
    ReactiveFormsModule
  ],
  providers: [ApiserviceService,{provide: HTTP_INTERCEPTORS,useClass:TokenInterceptorService,multi:true}],
  bootstrap: [AppComponent]
})
export class AppModule { }
