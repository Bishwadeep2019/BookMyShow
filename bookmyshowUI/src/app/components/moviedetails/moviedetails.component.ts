import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
import { MoviedetailsapiService } from './moviedetailsapi.service';


@Component({
  selector: 'app-moviedetails',
  templateUrl: './moviedetails.component.html',
  styleUrls: ['./moviedetails.component.scss']
})
export class MoviedetailsComponent implements OnInit {

  constructor(private service: MoviedetailsapiService, public activatedRoute: ActivatedRoute ) { }
  
  MovieDetails:any= [];
  cityName:string= "0";
  cityList:any = [];
  ngOnInit(): void {
    this.activatedRoute.params.subscribe(param =>{
      let id = param['id'];
      this.cityName = param['cityName'];
      this.getMovieDetailsById(id); 
     
    });  
    this.getCityList();      
  }
  
  getMovieDetailsById(id: any){
    this.service.getMoviesById(id).subscribe(data =>{
      this.MovieDetails = data;
    }); 
  }

  getCityList(){
    this.service.getCities().subscribe(data =>{
      this.cityList = data;
    });
   }
   
}
