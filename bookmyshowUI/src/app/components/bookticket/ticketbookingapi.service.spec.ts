import { TestBed } from '@angular/core/testing';

import { TicketbookingapiService } from './ticketbookingapi.service';

describe('TicketbookingapiService', () => {
  let service: TicketbookingapiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TicketbookingapiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
