"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var recon_service_1 = require("./recon.service");
describe('ReconService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [recon_service_1.ReconService]
        });
    });
    it('should be created', testing_1.inject([recon_service_1.ReconService], function (service) {
        expect(service).toBeTruthy();
    }));
});
//# sourceMappingURL=recon.service.spec.js.map