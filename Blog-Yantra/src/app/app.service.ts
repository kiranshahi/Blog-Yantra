import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Rx';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class AppService {

  private apiURL = 'api/Test';

  constructor(private _http: Http) { }

  getData(): Observable<any> {
    return this._http.get(this.apiURL).map((response: Response) => {
      return response.text();
    });
  }

}
