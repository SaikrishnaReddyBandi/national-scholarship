import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-student-login',
  templateUrl: './student-login.component.html',
  styleUrls: ['./student-login.component.css'],
})
export class StudentLoginComponent implements OnInit {
  isValidForm = false;
  submitted = false;

  studentLoginForm = new FormGroup({
    userId: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required),
  });
  constructor(private route: Router) {}

  ngOnInit(): void {}

  onSubmit() {
    this.submitted = true;
    if (this.studentLoginForm.invalid) {
      this.isValidForm = true;
      return;
    }
    this.route.navigate(['/users-login']);
    console.log(this.studentLoginForm.value);
  }
}