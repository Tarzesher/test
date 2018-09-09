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
var ReconComponent = /** @class */ (function () {
    function ReconComponent() {
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
            'logEvent',
            'comment'
        ];
        // Create 100 overview
        var stats = [];
        for (var i = 1; i <= 100; i++) {
            stats.push(createOverview(i));
        }
        // Assign the data to the data source for the table to render
        this.dataSource = new material_1.MatTableDataSource(stats);
    }
    ReconComponent.prototype.ngOnInit = function () {
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
        __metadata("design:paramtypes", [])
    ], ReconComponent);
    return ReconComponent;
}());
exports.ReconComponent = ReconComponent;
function createOverview(id) {
    var stats = {
        reconID: id,
        source: 'BNKT',
        cdsBusinessDate: new Date('2018-05-14'),
        reference: 'BNKT_M619252000',
        srcReference: 'M619252000',
        tradeDate: new Date('Feb 15 2018 12:00AM'),
        expiryDate: new Date('Feb 15 2018 12:00AM'),
        SettlementDate: new Date('Feb 15 2018 12:00AM'),
        cif: 0,
        product: 'N/A',
        notional: 56000000,
        mtm: null,
        logEvent: 'LogFilter',
        comment: 'LogFilter: BNKT_M560348000 filtered. Invalid Trade Indicator from Source'
    };
    return stats;
}
//# sourceMappingURL=recon.component.js.map