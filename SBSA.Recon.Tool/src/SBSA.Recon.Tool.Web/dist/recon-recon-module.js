(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["recon-recon-module"],{

/***/ "./src/app/layout/recon/recon-routing.module.ts":
/*!******************************************************!*\
  !*** ./src/app/layout/recon/recon-routing.module.ts ***!
  \******************************************************/
/*! exports provided: ReconRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ReconRoutingModule", function() { return ReconRoutingModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _recon_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./recon.component */ "./src/app/layout/recon/recon.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};



var routes = [
    {
        path: '',
        component: _recon_component__WEBPACK_IMPORTED_MODULE_2__["ReconComponent"]
    }
];
var ReconRoutingModule = /** @class */ (function () {
    function ReconRoutingModule() {
    }
    ReconRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], ReconRoutingModule);
    return ReconRoutingModule;
}());



/***/ }),

/***/ "./src/app/layout/recon/recon.component.html":
/*!***************************************************!*\
  !*** ./src/app/layout/recon/recon.component.html ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-form-field>\n  <input matInput (keyup)=\"applyFilter($event.target.value)\" placeholder=\"Filter\">\n</mat-form-field>\n\n<div class=\"mat-elevation-z8\">\n  <table mat-table [dataSource]=\"dataSource\" matSort>\n<ng-container matColumnDef=\"reconID\">\n    <th mat-header-cell *matHeaderCellDef mat-sort-header> Recon Id </th>\n    <td mat-cell *matCellDef=\"let row\"> {{row.reconID}} </td>\n</ng-container>\n<ng-container matColumnDef=\"source\">\n    <th mat-header-cell *matHeaderCellDef mat-sort-header> Source </th>\n    <td mat-cell *matCellDef=\"let row\"> {{row.source}} </td>\n</ng-container>\n<ng-container matColumnDef=\"cdsBusinessDate\">\n    <th mat-header-cell *matHeaderCellDef mat-sort-header> CDS Business Date </th>\n    <td mat-cell *matCellDef=\"let row\"> {{row.cdsBusinessDate}} </td>\n</ng-container>\n<ng-container matColumnDef=\"reference\">\n        <th mat-header-cell *matHeaderCellDef mat-sort-header> Reference </th>\n        <td mat-cell *matCellDef=\"let row\"> {{row.reference}} </td>\n</ng-container>\n<ng-container matColumnDef=\"srcReference\">\n        <th mat-header-cell *matHeaderCellDef mat-sort-header> Src Reference </th>\n        <td mat-cell *matCellDef=\"let row\"> {{row.srcReference}} </td>\n    </ng-container>\n    <ng-container matColumnDef=\"tradeDate\">\n        <th mat-header-cell *matHeaderCellDef mat-sort-header> Trade Date </th>\n        <td mat-cell *matCellDef=\"let row\"> {{row.tradeDate}} </td>\n    </ng-container>\n    <ng-container matColumnDef=\"expiryDate\">\n            <th mat-header-cell *matHeaderCellDef mat-sort-header> Expiry Date </th>\n            <td mat-cell *matCellDef=\"let row\"> {{row.expiryDate}} </td>\n        </ng-container>\n    <ng-container matColumnDef=\"settlementDate\">\n            <th mat-header-cell *matHeaderCellDef mat-sort-header> Trade Date </th>\n            <td mat-cell *matCellDef=\"let row\"> {{row.settlementDate}} </td>\n    </ng-container>\n    <ng-container matColumnDef=\"cif\">\n        <th mat-header-cell *matHeaderCellDef mat-sort-header> CIF\n        <td mat-cell *matCellDef=\"let row\"> {{row.cif}} </td>\n    </ng-container>\n    <ng-container matColumnDef=\"product\">\n            <th mat-header-cell *matHeaderCellDef mat-sort-header> Product </th>\n            <td mat-cell *matCellDef=\"let row\"> {{row.product}} </td>\n    </ng-container>\n    <ng-container matColumnDef=\"notional\">\n            <th mat-header-cell *matHeaderCellDef mat-sort-header> notional </th>\n            <td mat-cell *matCellDef=\"let row\"> {{row.notional}} </td>\n    </ng-container>\n    <ng-container matColumnDef=\"mtm\">\n            <th mat-header-cell *matHeaderCellDef mat-sort-header>mtm </th>\n            <td mat-cell *matCellDef=\"let row\"> {{row.mtm}} </td>\n        </ng-container>\n    \n        <ng-container matColumnDef=\"logEvent\">\n            <th mat-header-cell *matHeaderCellDef mat-sort-header> Log Event </th>\n            <td mat-cell *matCellDef=\"let row\"> {{row.logEvent}} </td>\n        </ng-container>\n        <!-- <ng-container matColumnDef=\"comment\">\n                <th mat-header-cell *matHeaderCellDef mat-sort-header> Comment</th>\n                <td mat-cell *matCellDef=\"let row\"> {{row.commentCount}} </td>\n        </ng-container> -->\n\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns\"></tr>\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\"></tr>\n  </table>\n\n  <mat-paginator [pageSize]=\"10\" [pageSizeOptions]=\"[5, 10, 25, 100]\"></mat-paginator>\n</div>\n"

/***/ }),

/***/ "./src/app/layout/recon/recon.component.scss":
/*!***************************************************!*\
  !*** ./src/app/layout/recon/recon.component.scss ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "table {\n  width: 100%; }\n\n.mat-form-field {\n  font-size: 14px;\n  width: 100%; }\n\ntd,\nth {\n  width: 25%; }\n"

/***/ }),

/***/ "./src/app/layout/recon/recon.component.ts":
/*!*************************************************!*\
  !*** ./src/app/layout/recon/recon.component.ts ***!
  \*************************************************/
/*! exports provided: ReconComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ReconComponent", function() { return ReconComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");
/* harmony import */ var _data_recon_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../data/recon.service */ "./src/app/data/recon.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var ReconComponent = /** @class */ (function () {
    function ReconComponent(reconService) {
        this.reconService = reconService;
        this.overviewModel = [];
        this.comments = [];
        this.displayedColumns = [
            'reconID',
            'source',
            'cdsBusinessDate',
            'reference',
            'srcReference',
            'tradeDate',
            'expiryDate',
            'settlementDate',
            'cif',
            'product',
            'notional',
            'mtm',
            'logEvent'
        ];
        this.reconService = reconService;
    }
    ReconComponent.prototype.ngOnInit = function () {
        // this.reconService.getComments()
        // .subscribe(x => this.commentDataSource = new MatTableDataSource(x));
        // this.commentDataSource = new MatTableDataSource(this.comments);
        // this.commentDataSource.paginator = this.paginator;
        // this.commentDataSource.sort = this.sort;
        var _this = this;
        this.reconService.getStats()
            .subscribe(function (x) { return _this.dataSource = new _angular_material__WEBPACK_IMPORTED_MODULE_1__["MatTableDataSource"](x); });
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
    };
    ReconComponent.prototype.applyFilter = function (filterValue) {
        filterValue = filterValue.trim(); // Remove whitespace
        filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
        this.dataSource.filter = filterValue;
        if (this.dataSource.paginator) {
            this.dataSource.paginator.firstPage();
        }
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_1__["MatPaginator"]),
        __metadata("design:type", _angular_material__WEBPACK_IMPORTED_MODULE_1__["MatPaginator"])
    ], ReconComponent.prototype, "paginator", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_1__["MatSort"]),
        __metadata("design:type", _angular_material__WEBPACK_IMPORTED_MODULE_1__["MatSort"])
    ], ReconComponent.prototype, "sort", void 0);
    ReconComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-recon',
            template: __webpack_require__(/*! ./recon.component.html */ "./src/app/layout/recon/recon.component.html"),
            styles: [__webpack_require__(/*! ./recon.component.scss */ "./src/app/layout/recon/recon.component.scss")]
        }),
        __metadata("design:paramtypes", [_data_recon_service__WEBPACK_IMPORTED_MODULE_2__["ReconService"]])
    ], ReconComponent);
    return ReconComponent;
}());



/***/ }),

/***/ "./src/app/layout/recon/recon.module.ts":
/*!**********************************************!*\
  !*** ./src/app/layout/recon/recon.module.ts ***!
  \**********************************************/
/*! exports provided: ReconModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ReconModule", function() { return ReconModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");
/* harmony import */ var _recon_routing_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./recon-routing.module */ "./src/app/layout/recon/recon-routing.module.ts");
/* harmony import */ var _recon_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./recon.component */ "./src/app/layout/recon/recon.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};





var ReconModule = /** @class */ (function () {
    function ReconModule() {
    }
    ReconModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"],
                _recon_routing_module__WEBPACK_IMPORTED_MODULE_3__["ReconRoutingModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatTableModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatFormFieldModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatPaginatorModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatInputModule"]
            ],
            declarations: [_recon_component__WEBPACK_IMPORTED_MODULE_4__["ReconComponent"]]
        })
    ], ReconModule);
    return ReconModule;
}());



/***/ })

}]);
//# sourceMappingURL=recon-recon-module.js.map