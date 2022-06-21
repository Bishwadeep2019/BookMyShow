import { Component } from '@angular/core';
import { ApiserviceService } from './apiservice.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title : string = 'bookmyshowUI';
  display:boolean=false;
  displayLogoutButton: boolean= true;
  constructor(private service: ApiserviceService) { }
  ngOnInit(): void {
    if(this.service.getToken()){
      this.display=true;  
    }
  }
  signout(){
    this.display=false;
    this.displayLogoutButton = false;
    this.service.logout();
    
  }
}
