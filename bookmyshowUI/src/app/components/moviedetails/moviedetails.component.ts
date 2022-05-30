import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { ActivatedRoute} from '@angular/router';


@Component({
  selector: 'app-moviedetails',
  templateUrl: './moviedetails.component.html',
  styleUrls: ['./moviedetails.component.scss']
})
export class MoviedetailsComponent implements OnInit {

  constructor(private service: ApiserviceService, public activatedRoute: ActivatedRoute ) { }
  
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
