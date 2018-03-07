"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var post_service_1 = require("./post.service");
describe('PostService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [post_service_1.PostService]
        });
    });
    it('should be created', testing_1.inject([post_service_1.PostService], function (service) {
        expect(service).toBeTruthy();
    }));
});
//# sourceMappingURL=post.service.spec.js.map