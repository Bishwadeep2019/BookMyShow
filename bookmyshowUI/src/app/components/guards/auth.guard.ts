import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { ApiserviceService } from 'src/app/apiservice.service';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private service: ApiserviceService,private router:Router){}
  canActivate(): boolean{
      if(this.service.isLoggedIn()){
        return true;
      }
      else{
        this.router.navigate(['login']);
        return false;
      }
    }
}