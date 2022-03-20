import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScholarshipFormUploadComponent } from './scholarship-form-upload.component';

describe('ScholarshipFormUploadComponent', () => {
  let component: ScholarshipFormUploadComponent;
  let fixture: ComponentFixture<ScholarshipFormUploadComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ScholarshipFormUploadComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ScholarshipFormUploadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});