import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Validation } from '../validation';

@Component({
  selector: 'app-institute-request-form',
  templateUrl: './institute-request-form.component.html',
  styleUrls: ['./institute-request-form.component.css'],
})
export class InstituteRequestFormComponent implements OnInit {
  instituteRegisterForm: FormGroup = new FormGroup({});
  submitted = false;
  isValidForm = false;
  states = ['AndhraPradesh', 'Karnataka', 'TamilNadu', 'Kerala'];

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.instituteRegisterForm = this.formBuilder.group(
      {
        name: ['', [Validators.required]],
        instituteCatagory: ['', Validators.required],
        instituteCode: ['', Validators.required],
        diseCode: ['', Validators.required],
        location: ['', Validators.required],
        instituteType: ['', Validators.required],
        affilatedUniversityState: ['', Validators.required],
        affilatedUniversityName: ['', Validators.required],
        admissionStarted: ['', Validators.required],
        lineOne: ['', Validators.required],
        lineTwo: ['', Validators.required],
        state: ['', Validators.required],
        district: ['', Validators.required],
        city: ['', Validators.required],
        pinCode: ['', Validators.required],
        principalName: ['', Validators.required],
        mobileNumber: ['', Validators.required],
        telePhone: ['', Validators.required],
        password: [
          '',
          [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(10),
          ],
        ],
        confirmPassword: ['', Validators.required],
        acceptTerms: [false, Validators.requiredTrue],
      },
      {
        validators: [Validation.match('password', 'confirmPassword')],
      }
    );
  }

  get f(): { [key: string]: AbstractControl } {
    return this.instituteRegisterForm.controls;
  }

  onSubmit() {
    this.submitted = true;
    this.isValidForm = true;
    if (this.instituteRegisterForm.invalid) {
      this.isValidForm = true;
      return;
    }
    console.log(this.instituteRegisterForm.value);
    this.reset();
  }
  reset() {
    this.submitted = false;
    this.isValidForm = false;
    this.instituteRegisterForm.reset();
  }
}