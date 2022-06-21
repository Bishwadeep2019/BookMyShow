import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
import { AllmovieapiService } from './allmovieapi.service';
@Component({
  selector: 'app-moviecard',
  templateUrl: './moviecard.component.html',
  styleUrls: ['./moviecard.component.scss']
})
export class MoviecardComponent implements OnInit {

  constructor(
     private service: AllmovieapiService,
     public activatedRoute: ActivatedRoute 
     ) { }

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
