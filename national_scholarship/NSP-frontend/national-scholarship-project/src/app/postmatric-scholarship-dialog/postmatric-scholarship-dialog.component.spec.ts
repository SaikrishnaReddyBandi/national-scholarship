import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostmatricScholarshipDialogComponent } from './postmatric-scholarship-dialog.component';

describe('PostmatricScholarshipDialogComponent', () => {
  let component: PostmatricScholarshipDialogComponent;
  let fixture: ComponentFixture<PostmatricScholarshipDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PostmatricScholarshipDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PostmatricScholarshipDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});