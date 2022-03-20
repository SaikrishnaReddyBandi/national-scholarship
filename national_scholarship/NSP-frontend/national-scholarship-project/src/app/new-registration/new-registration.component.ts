import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { Validation } from '../validation';

@Component({
  selector: 'app-new-registration',
  templateUrl: './new-registration.component.html',
  styleUrls: ['./new-registration.component.css'],
})
export class NewRegistrationComponent implements OnInit {
  City: any = [''];
  Gender: any = [''];

  registerForm: FormGroup = new FormGroup({});
  submitted = false;
  isValidForm = false;

  constructor(private formBuilder: FormBuilder, private router: Router) {}
  ngOnInit(): void {
    this.registerForm = this.formBuilder.group(
      {
        firstName: ['', [Validators.required]],
        district: ['', [Validators.required]],
        domicile: ['', [Validators.required]],
        mobile: [
          '',
          [
            Validators.required,
            Validators.pattern('^((\\+91-?)|0)?[0-9]{10}$'),
          ],
        ],
        email: ['', [Validators.required, Validators.email]],
        instituteCode: ['', [Validators.required]],
        aadharNumber: [
          '',
          [
            Validators.required,
            Validators.maxLength(12),
            Validators.pattern('^[0-9]{12}$'),
          ],
        ],
        ifscCode: ['', [Validators.required]],
        accountNumber: [
          '',
          [
            Validators.required,
            Validators.maxLength(15),
            Validators.pattern('^[0-9]{15}$'),
          ],
        ],
        bankName: ['', [Validators.required]],
        //setPassword: ['', [Validators.required, Validators.minLength(6)]],
        //confirmPassword: ['', [Validators.required]],
        agree: [false, [Validators.requiredTrue]],
        gender: ['', [Validators.required]],
        dob: ['', [Validators.required]],
        password: [
          '',
          [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(10),
          ],
        ],
        confirmPassword: ['', Validators.required],
        //acceptTerms: [false, Validators.requiredTrue],
      },
      {
        validators: [Validation.match('password', 'confirmPassword')],
      }
    );
  }

  get f(): { [key: string]: AbstractControl } {
    return this.registerForm.controls;
  }

  onSubmit() {
    this.submitted = true;
    this.isValidForm = true;
    if (this.registerForm.invalid) {
      this.isValidForm = true;
      return;
    }
    console.log(this.registerForm.value);
    this.router.navigate(['/register-sucsess']);
    this.reset();
  }

  reset() {
    this.submitted = false;
    this.isValidForm = false;
    this.registerForm.reset();
  }
}