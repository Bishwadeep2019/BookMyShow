import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoviedetailsComponent } from './components/moviedetails/moviedetails.component';
import { MoviecardComponent } from './components/moviecard/moviecard.component';
import { BookticketComponent } from './components/bookticket/bookticket.component';
import { CitytheaterComponent } from './components/citytheater/citytheater.component';
import { SelectcityComponent } from './components/selectcity/selectcity.component';
const routes: Routes = [
  
  {path: 'moviedetails/:id/:cityName' , component: MoviedetailsComponent},
  {path: 'citytheater/:id/:cityName', component: CitytheaterComponent},
  {path: 'bookticket/:id/:time/:cityName/:theaterId', component: BookticketComponent},
  {path: 'movies/:cityName', component: MoviecardComponent},
  {path:'',component:SelectcityComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
