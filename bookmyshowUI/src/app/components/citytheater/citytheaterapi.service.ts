import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CitytheaterapiService {
  readonly APIUrl = "https://localhost:7120/api";
  constructor(private http:HttpClient) { }
  
  getMoviesById(id: number):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Movie/id?id=${id}`)
  }

  //get all the city theater with the movie it is running
  getCityTheaterByName(cityName:string, movieId: any):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Theater/name?name=${cityName}&movieId=${movieId}`)
  }
}
