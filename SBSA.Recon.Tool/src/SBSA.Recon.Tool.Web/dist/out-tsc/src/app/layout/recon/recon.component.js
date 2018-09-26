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
var material_1 = require("@angular/material");
var recon_service_1 = require("../../data/recon.service");
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
            .subscribe(function (x) { return _this.dataSource = new material_1.MatTableDataSource(x); });
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
        core_1.ViewChild(material_1.MatPaginator),
        __metadata("design:type", material_1.MatPaginator)
    ], ReconComponent.prototype, "paginator", void 0);
    __decorate([
        core_1.ViewChild(material_1.MatSort),
        __metadata("design:type", material_1.MatSort)
    ], ReconComponent.prototype, "sort", void 0);
    ReconComponent = __decorate([
        core_1.Component({
            selector: 'app-recon',
            templateUrl: './recon.component.html',
            styleUrls: ['./recon.component.scss']
        }),
        __metadata("design:paramtypes", [recon_service_1.ReconService])
    ], ReconComponent);
    return ReconComponent;
}());
exports.ReconComponent = ReconComponent;
//# sourceMappingURL=recon.component.js.map