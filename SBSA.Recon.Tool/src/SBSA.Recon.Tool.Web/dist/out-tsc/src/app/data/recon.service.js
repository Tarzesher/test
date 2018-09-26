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
var operators_1 = require("rxjs/operators");
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var ReconService = /** @class */ (function () {
    function ReconService(http) {
        this.http = http;
        this.httpOptions = {
            headers: new http_1.HttpHeaders({ 'Content-Type': 'application/json' })
        };
        // tslint:disable-next-line:no-inferrable-types
        this.url = 'http://localhost:63547/api/';
    }
    ReconService.prototype.createComment = function (formData) {
        return this.http.get(this.url + 'comment/create' + formData, this.httpOptions)
            .pipe(operators_1.map(function (r) { return r; }));
    };
    ReconService.prototype.getStats = function () {
        return this.http.get(this.url + 'stats/', this.httpOptions)
            .pipe(operators_1.map(function (r) { return r; }));
    };
    ReconService.prototype.getComments = function () {
        return this.http.get(this.url + 'comment/', this.httpOptions)
            .pipe(operators_1.map(function (r) { return r; }));
    };
    ReconService.prototype.getCommentById = function (reconId) {
        return this.http.get(this.url + 'comment/GetById' + reconId, this.httpOptions)
            .pipe(operators_1.map(function (r) { return r; }));
    };
    ReconService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], ReconService);
    return ReconService;
}());
exports.ReconService = ReconService;
//# sourceMappingURL=recon.service.js.map