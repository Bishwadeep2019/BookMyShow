import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http'
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class MoviedetailsapiService {
  readonly APIUrl = "https://localhost:7120/api";
  constructor(private http:HttpClient) { }

  getCities():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/City');
  }
  getMoviesById(id: number):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Movie/id?id=${id}`)
  }
}
