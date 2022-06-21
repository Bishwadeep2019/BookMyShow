import { TestBed } from '@angular/core/testing';

import { AllmovieapiService } from './allmovieapi.service';

describe('AllmovieapiService', () => {
  let service: AllmovieapiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AllmovieapiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
