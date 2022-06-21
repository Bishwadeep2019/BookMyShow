
import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {HttpClient} from '@angular/common/http';
import {Router} from '@angular/router';
import { ApiserviceService } from 'src/app/apiservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  form!: FormGroup;
  
  constructor(
    private formBuilder: FormBuilder,
    private http: HttpClient,
    private router: Router,
    private service: ApiserviceService
  ) {
  }

  ngOnInit(): void {
    
    
    this.form = this.formBuilder.group({
      UserName: ['',Validators.required],
      email: ['',Validators.required],
      password: ['',Validators.required],
      
    });
  }

  submit(){
    if(this.form.valid) {
      console.log(this.form.value);
      this.service.insertCustomerDetails(this.form.value).subscribe(data=>{
        console.log(data);
        this.router.navigate(['login']);   
      })
    }
    else{
      alert("Fill all the fields");
    }
    
  }
 
}