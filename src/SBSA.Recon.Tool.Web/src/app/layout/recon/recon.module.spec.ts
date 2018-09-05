import { ReconModule } from './recon.module';

describe('ReconModule', () => {
  let reconModule: ReconModule;

  beforeEach(() => {
    reconModule = new ReconModule();
  });

  it('should create an instance', () => {
    expect(reconModule).toBeTruthy();
  });
});
