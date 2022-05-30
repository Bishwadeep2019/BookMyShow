import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http'
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  readonly APIUrl = "https://localhost:7120/api";
  constructor(private http:HttpClient) { }

  getCities():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/City');
  }

  getMovies():Observable<any[]>{
    return this.http.get<any>(this.APIUrl + '/Movie')
  }

  getBooking():Observable<any[]>{
    return this.http.get<any>(this.APIUrl + '/Booking')
  }
  getCustomer():Observable<any[]>{
    return this.http.get<any>(this.APIUrl + '/Customer')
  }
  getCustomerSeat():Observable<any[]>{
    return this.http.get<any>(this.APIUrl + '/CustomerSeat')
  }

  getShow():Observable<any[]>{
    return this.http.get<any>(this.APIUrl +'/Show')
  }

  getTheater():Observable<any[]>{
    return this.http.get<any>(this.APIUrl +'/Theater')
  }
  getTheaterHall():Observable<any[]>{
    return this.http.get<any>(this.APIUrl +'/TheaterHall')
  }

  getMoviesById(id: number):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Movie/id?id=${id}`)
  }

  getAllCityTheater():Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Theater/theater`)
  }

  //get all the city theater with the movie it is running
  getCityTheaterByName(cityName:string, movieId: any):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Theater/name?name=${cityName}&movieId=${movieId}`)
  }

  //get seats according to the theater ID ex jhv = 3
  getTotalSeats(theaterId:any):Observable<any[]>{
      return this.http.get<any>(`${this.APIUrl}/TheaterHall/totalseats?theaterId=${theaterId}`)
  }

  getBookedSeats(hallId:any):Observable<any[]>{
    return this.http.get<any>(`${this.APIUrl}/Seat/hallId?hallId=${hallId}`)
  }

  insertBookedSeats(data:any):Observable<any[]>{
    return this.http.post<any>(`${this.APIUrl}/Seat`,data)
  }
}
