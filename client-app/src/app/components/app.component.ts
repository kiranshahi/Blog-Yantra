import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';

import { AppService } from '../app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  greetings = '';

  constructor(private _appService: AppService) { }

  ngOnInit(): void {
    this._appService.getData()
      .subscribe(
      result => {
        this.greetings = result;
      }
      );
  }

}
