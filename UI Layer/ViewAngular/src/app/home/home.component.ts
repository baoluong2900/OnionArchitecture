import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
users:any;
   constructor (private http: HttpClient) {}

   ngOnInit(): void {
       this.getUsers();
   }
  getUsers() {
    this.http.get('https://localhost:44300/api/Employee/GetAllEmployee').subscribe(
      Response => {
        this.users = Response;
      }, error => {
        console.log(error);
      }
    )
  }

}