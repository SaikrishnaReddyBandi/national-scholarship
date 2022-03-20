import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  Validators,
  FormControl,
} from '@angular/forms';

import { Router } from '@angular/router';
import { Validation } from '../validation';

@Component({
  selector: 'app-users-login',
  templateUrl: './users-login.component.html',
  styleUrls: ['./users-login.component.css'],
})
export class UsersLoginComponent implements OnInit {
  isValidForm = false;
  submitted = false;

  loginForm = new FormGroup({
    userId: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required),
  });
  constructor(private route: Router) {}

  ngOnInit(): void {}

  onSubmit() {
    this.submitted = true;
    if (this.loginForm.invalid) {
      this.isValidForm = true;
      return;
    }
    this.route.navigate(['/student-home']);
    console.log(this.loginForm.value);
  }
}