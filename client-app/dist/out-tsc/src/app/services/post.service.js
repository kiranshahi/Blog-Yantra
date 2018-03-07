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
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
var Observable_1 = require("rxjs/Observable");
require("rxjs/add/operator/map");
require("rxjs/add/operator/catch");
require("rxjs/add/observable/throw");
var PostService = /** @class */ (function () {
    function PostService(_http, baseUrl) {
        this._http = _http;
        this.url = "";
        this.url = baseUrl;
    }
    PostService.prototype.getPosts = function () {
        return this._http.get(this.url + 'api/post')
            .map(function (response) { return response.json(); })
            .catch(this.errorHandler);
    };
    PostService.prototype.getPostById = function (id) {
        return this._http.get(this.url + "api/post/" + id)
            .map(function (response) { return response.json(); });
    };
    PostService.prototype.savePost = function (post) {
        return this._http.post(this.url + "api/post", post)
            .map(function (response) { return response.json(); })
            .catch(this.errorHandler);
    };
    PostService.prototype.updatePost = function (post) {
        return this._http.put(this.url + 'api/post', post)
            .map(function (response) { return response.json(); })
            .catch(this.errorHandler);
    };
    PostService.prototype.deletePost = function (id) {
        return this._http.delete(this.url + "api/post" + id)
            .map(function (response) { return response.json(); })
            .catch(this.errorHandler);
    };
    PostService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable_1.Observable.throw(error);
    };
    PostService = __decorate([
        core_1.Injectable(),
        __param(1, core_1.Inject('BASE_URL')),
        __metadata("design:paramtypes", [http_1.Http, String])
    ], PostService);
    return PostService;
}());
exports.PostService = PostService;
//# sourceMappingURL=post.service.js.map