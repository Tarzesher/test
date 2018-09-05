"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var common_1 = require("@angular/common");
var material_1 = require("@angular/material");
var material_2 = require("@angular/material");
var material_3 = require("@angular/material");
var recon_routing_module_1 = require("./recon-routing.module");
var recon_component_1 = require("./recon.component");
var ReconModule = /** @class */ (function () {
    function ReconModule() {
    }
    ReconModule = __decorate([
        core_1.NgModule({
            imports: [
                common_1.CommonModule,
                recon_routing_module_1.ReconRoutingModule,
                material_1.MatTableModule,
                material_2.MatFormFieldModule,
                material_2.MatPaginatorModule,
                material_3.MatInputModule
            ],
            declarations: [recon_component_1.ReconComponent]
        })
    ], ReconModule);
    return ReconModule;
}());
exports.ReconModule = ReconModule;
//# sourceMappingURL=recon.module.js.map