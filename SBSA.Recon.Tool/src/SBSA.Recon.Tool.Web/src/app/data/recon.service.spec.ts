import { TestBed, inject } from '@angular/core/testing';

import { ReconService } from './recon.service';

describe('ReconService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ReconService]
    });
  });

  it('should be created', inject([ReconService], (service: ReconService) => {
    expect(service).toBeTruthy();
  }));
});
