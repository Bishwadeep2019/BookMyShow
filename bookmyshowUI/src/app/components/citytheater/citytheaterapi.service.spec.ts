import { TestBed } from '@angular/core/testing';

import { CitytheaterapiService } from './citytheaterapi.service';

describe('CitytheaterapiService', () => {
  let service: CitytheaterapiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CitytheaterapiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
