import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';


@Component({
  selector: 'app-topnav',
  templateUrl: './topnav.component.html',
  styleUrls: ['./topnav.component.scss']
})
export class TopnavComponent implements OnInit {

  display:boolean=false;
  
  constructor(private service: ApiserviceService) { }

  ngOnInit(): void {
    if(this.service.getToken()){
      this.display=true;      
    }
  }
  signout(){
    this.service.logout();
    this.display=false;
  }
}
