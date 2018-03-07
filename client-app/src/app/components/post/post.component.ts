import { Component, Inject, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { Post } from '../post';
import { PostService } from '../../services/post.service';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html'
})
export class PostComponent implements OnInit {
  public postList: Post[];
  constructor(public http: Http, private _router: Router, private _postService: PostService) {
    this.getPosts();
  }

  getPosts() {
    this._postService.getPosts().subscribe(
      data => this.postList = data
    )
  }

  delete(postID) {
    var ans = confirm("Do you want to delete this post?");
    if (ans) {
      this._postService.deletePost(postID).subscribe((data) => {
        this.getPosts();
      }, error => console.error(error))
    }
  }

  ngOnInit() {
  }

}
