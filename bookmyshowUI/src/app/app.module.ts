import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopnavComponent } from './components/topnav/topnav.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ButtonComponent } from './components/button/button.component';
import { HttpClientModule} from '@angular/common/http';
import { MoviecardComponent } from './components/moviecard/moviecard.component';
import { MoviedetailsComponent } from './components/moviedetails/moviedetails.component';
import { CitytheaterComponent } from './components/citytheater/citytheater.component';
import { BookticketComponent } from './components/bookticket/bookticket.component';
import { SelectcityComponent } from './components/selectcity/selectcity.component'
@NgModule({
  declarations: [
    AppComponent,
    TopnavComponent,
    ButtonComponent,   
    MoviecardComponent, MoviedetailsComponent, CitytheaterComponent, BookticketComponent, SelectcityComponent
  ],
  imports: [    
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent, TopnavComponent]
})
export class AppModule { }
