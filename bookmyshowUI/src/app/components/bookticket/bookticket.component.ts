import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TicketbookingapiService } from './ticketbookingapi.service';
import { ShareDataService } from 'src/app/service/share-data.service';

@Component({
  selector: 'app-bookticket',
  templateUrl: './bookticket.component.html',
  styleUrls: ['./bookticket.component.scss']
})
export class BookticketComponent implements OnInit {

  noOfSeats: Array<number> = [];
  noOfBookedSeats: Array<any> = [];
  totalNoOfSeats: any = [];
  theaterId: any = [];
  alreadyBookedSeats:number=0;
  requiredSeats:number=1;
  
  
  constructor(private service: TicketbookingapiService ,
    public activatedRoute: ActivatedRoute,
    private dataService :ShareDataService
    ) {
  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(param => {
      this.theaterId = param['theaterId'];

      this.service.getBookedSeats(this.theaterId).subscribe(data =>{
        this.noOfBookedSeats = data;
        // console.log(this.noOfBookedSeats.length);
        this.alreadyBookedSeats=this.noOfBookedSeats.length;
        this.makeseats(this.alreadyBookedSeats);
      });     
      
    });
  }

  makeseats(value:any){
    this.service.getTotalSeats(this.theaterId).subscribe(data => {
      this.totalNoOfSeats = data;
      this.fillArray(this.totalNoOfSeats.totalSeats-value)
    });  
  }
  
  fillArray(value: any) {
    for (let c = 1; c <= value; c++) {
      this.noOfSeats.push(c);
    }
  }
  selectChangeHandler (event: any) {    
    this.requiredSeats = event.target.value;  
    // console.log(this.requiredSeats);
    // console.log(this.alreadyBookedSeats);
  }

  book(){
    var ab = Number(this.alreadyBookedSeats)+Number(this.requiredSeats);
    // console.log(Number(this.alreadyBookedSeats)+Number(this.requiredSeats));
    for(var c=this.alreadyBookedSeats+1; c<=ab;c++)
    {
      const newData = {seatId: c, hallId: this.theaterId, isDeleted: false}
      this.service.insertBookedSeats(newData).subscribe(data=>{        
      });
    }
    this.dataService.name.subscribe(data=>{
      console.log("hello"+data);
    });
    
  }
}
