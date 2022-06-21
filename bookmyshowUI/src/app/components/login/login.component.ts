import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {HttpClient} from '@angular/common/http';
import {Router} from '@angular/router';
import { ApiserviceService } from 'src/app/apiservice.service';
import { ShareDataService } from 'src/app/service/share-data.service';
import { AppComponent } from 'src/app/app.component';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  form!: FormGroup;
 
  constructor(
    private formBuilder: FormBuilder,
    private http: HttpClient,
    private router: Router,
    private service: ApiserviceService,
    private dataService : ShareDataService,
    private app:AppComponent
  ) {
  }

  ngOnInit(): void {
     this.app.displayLogoutButton = false;
    this.form = this.formBuilder.group({
      email: ['',Validators.required],
      password: ['',Validators.required],
    });
  }
  responsedata: any;
  submit():void{
    if(this.form.valid){
      this.dataService.changeName(this.form.value.email);
      this.service.getJwtToken(this.form.value).subscribe(result=>{
        console.log(this.form.value.email);
        sessionStorage.setItem('token',result.token);        
        this.router.navigate(['selectCity']);     
        });
    }  
    else{
      alert("Fill the details properly");
    }     
  }
}