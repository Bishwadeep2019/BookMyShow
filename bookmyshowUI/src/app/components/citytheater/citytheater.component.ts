import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
import { ApiserviceService } from 'src/app/apiservice.service';
@Component({
  selector: 'app-citytheater',
  templateUrl: './citytheater.component.html',
  styleUrls: ['./citytheater.component.scss']
})
export class CitytheaterComponent implements OnInit {

  constructor(private service: ApiserviceService, public activatedRoute: ActivatedRoute ) { }
  
  MovieDetails:any= [];
  cityTheaterDetails:any =[];
  ngOnInit(): void {
    this.activatedRoute.params.subscribe(param =>{
      let id = param['id'];
      let name = param['cityName'];
      this.getMovieDetailsById(id); 
      this.getTheaterByCityName(name, id);
    });
}
getMovieDetailsById(id: any){
  this.service.getMoviesById(id).subscribe(data =>{
    this.MovieDetails = data;
  });
}
getTheaterByCityName(name: string, id: any){
  this.service.getCityTheaterByName(name, id).subscribe(data =>{
    this.cityTheaterDetails = data;
  });
}
}
