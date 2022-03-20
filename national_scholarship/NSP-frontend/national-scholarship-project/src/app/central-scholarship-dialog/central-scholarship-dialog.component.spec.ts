import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CentralScholarshipDialogComponent } from './central-scholarship-dialog.component';

describe('CentralScholarshipDialogComponent', () => {
  let component: CentralScholarshipDialogComponent;
  let fixture: ComponentFixture<CentralScholarshipDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CentralScholarshipDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CentralScholarshipDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});