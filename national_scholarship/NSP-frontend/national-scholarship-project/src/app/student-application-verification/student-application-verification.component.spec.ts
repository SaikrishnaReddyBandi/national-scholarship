import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentApplicationVerificationComponent } from './student-application-verification.component';

describe('StudentApplicationVerificationComponent', () => {
  let component: StudentApplicationVerificationComponent;
  let fixture: ComponentFixture<StudentApplicationVerificationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentApplicationVerificationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentApplicationVerificationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});