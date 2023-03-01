import { TestBed } from '@angular/core/testing';

import { PublicvotesService } from './publicvotes.service';

describe('PublicvotesService', () => {
  let service: PublicvotesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PublicvotesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
