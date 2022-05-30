import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { ActivatedRoute} from '@angular/router';
@Component({
  selector: 'app-selectcity',
  templateUrl: './selectcity.component.html',
  styleUrls: ['./selectcity.component.scss']
})
export class SelectcityComponent implements OnInit {

  constructor(private service: ApiserviceService, public activatedRoute: ActivatedRoute ) { }
  cityList:any = [];
  cityName:string= "0";
  ngOnInit(): void {
    
      this.service.getCities().subscribe(data =>{
        this.cityList = data;
      });
  }  
}

