import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';


// Cấu hình
import {HttpClientModule} from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap'

 // Bootrap
import {NgbPaginationModule, NgbAlertModule} from '@ng-bootstrap/ng-bootstrap';

//
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';

import {MatIconModule} from '@angular/material/icon';
import { SidebarComponent } from './sidebar/sidebar.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavbarComponent,
    SidebarComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
    // Cấu hình
    ,HttpClientModule
    , NgbModule
    // Bootrap
    ,[NgbPaginationModule, NgbAlertModule]

    ,MatToolbarModule
    ,MatButtonModule
    ,MatIconModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
