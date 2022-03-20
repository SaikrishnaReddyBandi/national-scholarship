import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NationalmeritScholarshipDialogComponent } from './nationalmerit-scholarship-dialog.component';

describe('NationalmeritScholarshipDialogComponent', () => {
  let component: NationalmeritScholarshipDialogComponent;
  let fixture: ComponentFixture<NationalmeritScholarshipDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NationalmeritScholarshipDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NationalmeritScholarshipDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});