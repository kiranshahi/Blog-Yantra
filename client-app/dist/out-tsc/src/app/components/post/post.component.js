"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var post_service_1 = require("../../services/post.service");
var PostComponent = /** @class */ (function () {
    function PostComponent(http, _router, _postService) {
        this.http = http;
        this._router = _router;
        this._postService = _postService;
        this.getPosts();
    }
    PostComponent.prototype.getPosts = function () {
        var _this = this;
        this._postService.getPosts().subscribe(function (data) { return _this.postList = data; });
    };
    PostComponent.prototype.delete = function (postID) {
        var _this = this;
        var ans = confirm("Do you want to delete this post?");
        if (ans) {
            this._postService.deletePost(postID).subscribe(function (data) {
                _this.getPosts();
            }, function (error) { return console.error(error); });
        }
    };
    PostComponent.prototype.ngOnInit = function () {
    };
    PostComponent = __decorate([
        core_1.Component({
            selector: 'app-post',
            templateUrl: './post.component.html'
        }),
        __metadata("design:paramtypes", [http_1.Http, router_1.Router, post_service_1.PostService])
    ], PostComponent);
    return PostComponent;
}());
exports.PostComponent = PostComponent;
//# sourceMappingURL=post.component.js.map