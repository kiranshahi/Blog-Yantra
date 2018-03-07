import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app.component';
import { AppService } from './app.service';

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule } from 'ngx-bootstrap/modal';
import { PostComponent } from './components/post/post.component';
import { HomeComponent } from './components/home/home.component';
import { CreatepostComponent } from './createpost/createpost.component';

@NgModule({
  declarations: [
    AppComponent,
    PostComponent,
    CreatepostComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    BsDropdownModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot(),
    RouterModule.forRoot([
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: HomeComponent },
      { path: 'post/create', component: PostComponent },
      { path: '**', redirectTo: 'home' }
    ])
  ],
  providers: [AppService],
  bootstrap: [AppComponent]
})
export class AppModule { }
