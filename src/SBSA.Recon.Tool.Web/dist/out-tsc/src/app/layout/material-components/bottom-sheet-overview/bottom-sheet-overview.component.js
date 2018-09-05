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
var BottomSheetOverviewComponent = /** @class */ (function () {
    function BottomSheetOverviewComponent(bottomSheetRef) {
        this.bottomSheetRef = bottomSheetRef;
    }
    BottomSheetOverviewComponent.prototype.openLink = function (event) {
        this.bottomSheetRef.dismiss();
        event.preventDefault();
    };
    BottomSheetOverviewComponent.prototype.ngOnInit = function () { };
    BottomSheetOverviewComponent = __decorate([
        core_1.Component({
            selector: 'app-bottom-sheet-overview',
            templateUrl: './bottom-sheet-overview.component.html',
            styleUrls: ['./bottom-sheet-overview.component.scss']
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof material_1.MatBottomSheetRef !== "undefined" && material_1.MatBottomSheetRef) === "function" && _a || Object])
    ], BottomSheetOverviewComponent);
    return BottomSheetOverviewComponent;
    var _a;
}());
exports.BottomSheetOverviewComponent = BottomSheetOverviewComponent;
//# sourceMappingURL=bottom-sheet-overview.component.js.map