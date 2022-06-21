import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AllmovieapiService {
  readonly APIUrl = "https://localhost:7120/api";
  constructor(private http:HttpClient) { }

  getMovies():Observable<any[]>{
    return this.http.get<any>(this.APIUrl +'/Movie')
  }
}
