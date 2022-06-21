import { TestBed } from '@angular/core/testing';

import { MoviedetailsapiService } from './moviedetailsapi.service';

describe('MoviedetailsapiService', () => {
  let service: MoviedetailsapiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MoviedetailsapiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
