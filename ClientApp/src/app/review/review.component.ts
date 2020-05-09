import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Ireview} from '../interfaces/ireview'

@Component({
  selector: 'app-review',
  templateUrl: './review.component.html',
  styleUrls: ['./review.component.css']
})
export class ReviewComponent implements OnInit {
  public reviews: Ireview[];
  
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

 async ngOnInit() {
    this.reviews = await this.http.get<Ireview[]>(this.baseUrl + 'review').toPromise();
    console.log(this.reviews);
  }

  

}

