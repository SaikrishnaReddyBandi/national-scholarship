import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScholarshipPortalComponent } from './scholarship-portal.component';

describe('ScholarshipPortalComponent', () => {
  let component: ScholarshipPortalComponent;
  let fixture: ComponentFixture<ScholarshipPortalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ScholarshipPortalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ScholarshipPortalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});