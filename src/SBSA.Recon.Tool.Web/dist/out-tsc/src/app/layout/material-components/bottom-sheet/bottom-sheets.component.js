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
var bottom_sheet_overview_component_1 = require("../bottom-sheet-overview/bottom-sheet-overview.component");
var BottomSheetComponent = /** @class */ (function () {
    function BottomSheetComponent(bottomSheet) {
        this.bottomSheet = bottomSheet;
    }
    BottomSheetComponent.prototype.openBottomSheet = function () {
        this.bottomSheet.open(bottom_sheet_overview_component_1.BottomSheetOverviewComponent);
    };
    BottomSheetComponent.prototype.ngOnInit = function () { };
    BottomSheetComponent = __decorate([
        core_1.Component({
            selector: 'app-bottom-sheet',
            templateUrl: './bottom-sheets.component.html',
            styleUrls: ['./bottom-sheets.component.scss']
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof material_1.MatBottomSheet !== "undefined" && material_1.MatBottomSheet) === "function" && _a || Object])
    ], BottomSheetComponent);
    return BottomSheetComponent;
    var _a;
}());
exports.BottomSheetComponent = BottomSheetComponent;
//# sourceMappingURL=bottom-sheets.component.js.map