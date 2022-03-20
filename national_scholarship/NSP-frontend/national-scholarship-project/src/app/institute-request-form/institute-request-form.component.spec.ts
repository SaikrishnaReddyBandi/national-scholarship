import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InstituteRequestFormComponent } from './institute-request-form.component';

describe('InstituteRequestFormComponent', () => {
  let component: InstituteRequestFormComponent;
  let fixture: ComponentFixture<InstituteRequestFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InstituteRequestFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InstituteRequestFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});