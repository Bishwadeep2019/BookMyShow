import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { ActivatedRoute} from '@angular/router';
@Component({
  selector: 'app-moviecard',
  templateUrl: './moviecard.component.html',
  styleUrls: ['./moviecard.component.scss']
})
export class MoviecardComponent implements OnInit {

  constructor(private service: ApiserviceService, public activatedRoute: ActivatedRoute ) { }

  MovieList:any=[];
  cityName:any;
  ngOnInit(): void {
    this.getMovieList();
    this.activatedRoute.params.subscribe(param =>{
      this.cityName= param['cityName'];      
    }); 
  }

  getMovieList(){
    this.service.getMovies().subscribe(data =>{
      this.MovieList = data;
      console.log(this.MovieList.length);
    });    
  }

}
