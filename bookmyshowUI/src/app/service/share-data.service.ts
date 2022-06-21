import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ShareDataService {

  private nameSource = new BehaviorSubject<string>('');
  name = this.nameSource.asObservable();
  constructor() { }
  changeName(name :string){
    this.nameSource.next(name);
  }
}
