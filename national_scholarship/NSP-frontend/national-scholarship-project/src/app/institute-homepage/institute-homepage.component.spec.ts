import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InstituteHomepageComponent } from './institute-homepage.component';

describe('InstituteHomepageComponent', () => {
  let component: InstituteHomepageComponent;
  let fixture: ComponentFixture<InstituteHomepageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InstituteHomepageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InstituteHomepageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});