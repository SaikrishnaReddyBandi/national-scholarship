import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CentralScholarshipDialogComponent } from '../central-scholarship-dialog/central-scholarship-dialog.component';
import { NationalmeritScholarshipDialogComponent } from '../nationalmerit-scholarship-dialog/nationalmerit-scholarship-dialog.component';
import { PostmatricScholarshipDialogComponent } from '../postmatric-scholarship-dialog/postmatric-scholarship-dialog.component';

@Component({
  selector: 'app-student-home',
  templateUrl: './student-home.component.html',
  styleUrls: ['./student-home.component.css'],
})
export class StudentHomeComponent implements OnInit {
  constructor(public dialog: MatDialog) {}
  openPostMatricDialog() {
    const dialogRef = this.dialog.open(PostmatricScholarshipDialogComponent, {
      width: 'calc(100% - 40%)',
      height: 'auto',
    });
  }
  openNationalMatricDialog() {
    const dialogRef = this.dialog.open(
      NationalmeritScholarshipDialogComponent,
      {
        width: 'calc(100% - 40%)',
        height: 'auto',
      }
    );
  }
  openCentralScholarshipDialog() {
    const dialogRef = this.dialog.open(CentralScholarshipDialogComponent, {
      width: 'calc(100% - 40%)',
      height: 'auto',
    });
  }
  ngOnInit(): void {}
}