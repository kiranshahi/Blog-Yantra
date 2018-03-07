import { Injectable, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Injectable()
export class PostService {
  url: string = "";

  constructor(private _http: Http, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
  }

  getPosts() {
    return this._http.get(this.url + 'api/post')
      .map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

  getPostById(id: number) {
    return this._http.get(this.url + "api/post/" + id)
      .map((response: Response) => response.json())
  }

  savePost(post) {
    return this._http.post(this.url + "api/post", post)
      .map((response: Response) => response.json())
      .catch(this.errorHandler)
  }

  updatePost(post) {
    return this._http.put(this.url + 'api/post', post)
      .map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

  deletePost(id) {
    return this._http.delete(this.url + "api/post" + id)
      .map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

  errorHandler(error: Response) {
    console.log(error);
    return Observable.throw(error);
  }

}
