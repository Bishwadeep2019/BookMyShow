import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { ActivatedRoute} from '@angular/router';
import { CityapiService } from './cityapi.service';
import { AppComponent } from 'src/app/app.component';
@Component({
  selector: 'app-selectcity',
  templateUrl: './selectcity.component.html',
  styleUrls: ['./selectcity.component.scss']
})
export class SelectcityComponent implements OnInit {

  constructor(private service: CityapiService, public activatedRoute: ActivatedRoute, private app: AppComponent ) { }
  cityList:any = [];
  cityName:any= "0";
  ngOnInit(): void {
    
    this.app.displayLogoutButton = true;
    this.app.display = true;
      this.service.getCities().subscribe(data =>{
        this.cityList = data;
      });
  }  
}

