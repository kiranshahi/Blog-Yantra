"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var app_service_1 = require("./services/app.service");
var dropdown_1 = require("ngx-bootstrap/dropdown");
var tooltip_1 = require("ngx-bootstrap/tooltip");
var modal_1 = require("ngx-bootstrap/modal");
var app_component_1 = require("./components/app/app.component");
var post_component_1 = require("./components/post/post.component");
var home_component_1 = require("./components/home/home.component");
var createpost_component_1 = require("./components/createpost/createpost.component");
var appRoutes = [
    {
        path: '',
        component: home_component_1.HomeComponent
    },
    {
        path: 'home',
        component: home_component_1.HomeComponent
    },
    {
        path: 'post/create',
        component: createpost_component_1.CreatepostComponent
    },
    {
        path: '**',
        redirectTo: 'home'
    }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                post_component_1.PostComponent,
                createpost_component_1.CreatepostComponent,
                home_component_1.HomeComponent
            ],
            imports: [
                platform_browser_1.BrowserModule,
                http_1.HttpModule,
                dropdown_1.BsDropdownModule.forRoot(),
                tooltip_1.TooltipModule.forRoot(),
                modal_1.ModalModule.forRoot(),
                router_1.RouterModule.forRoot(appRoutes)
            ],
            providers: [app_service_1.AppService],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map