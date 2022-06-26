import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { MoviedetailsComponent } from './components/moviedetails/moviedetails.component';
import { MoviecardComponent } from './components/moviecard/moviecard.component';
import { BookticketComponent } from './components/bookticket/bookticket.component';
import { CitytheaterComponent } from './components/citytheater/citytheater.component';
import { SelectcityComponent } from './components/selectcity/selectcity.component';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';
import { AuthGuard } from './components/guards/auth.guard';
import { TicketComponent } from './components/ticket/ticket.component';
const routes: Routes = [
  
  {path: 'moviedetails/:id/:cityName' ,canActivate:[AuthGuard], component: MoviedetailsComponent},
  {path: 'citytheater/:id/:cityName',canActivate:[AuthGuard], component: CitytheaterComponent},
  {path: 'bookticket/:id/:time/:cityName/:theaterId',canActivate:[AuthGuard], component: BookticketComponent},
  {path: 'movies/:cityName',canActivate:[AuthGuard], component: MoviecardComponent},
  {path: 'register', component: RegisterComponent},
  {path: 'login', component: LoginComponent},
  {path: 'selectCity',canActivate:[AuthGuard], component: SelectcityComponent},
  {path: 'ticket', canActivate:[AuthGuard], component: TicketComponent},
  {path:'',component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
