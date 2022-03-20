import { TestBed } from '@angular/core/testing';

import { NationalScholarshipService } from './national-scholarship.service';

describe('NationalScholarshipService', () => {
  let service: NationalScholarshipService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(NationalScholarshipService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});