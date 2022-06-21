import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TicketbookingapiService {
  readonly APIUrl = "https://localhost:7120/api";
  constructor(private http:HttpClient) { }

  getBookedSeats(hallId:any):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Seat/hallId?hallId=${hallId}`)
  }

  getTotalSeats(theaterId:any):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/TheaterHall/totalseats?theaterId=${theaterId}`)
  }

  insertBookedSeats(data:any):Observable<any[]>{
    return this.http.post<any>(`${this.APIUrl}/Seat`,data)
  }
}
