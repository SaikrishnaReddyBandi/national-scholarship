import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  FormControl,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { Validation } from '../validation';

@Component({
  selector: 'app-scholarship-form-upload',
  templateUrl: './scholarship-form-upload.component.html',
  styleUrls: ['./scholarship-form-upload.component.css'],
})
export class ScholarshipFormUploadComponent implements OnInit {
  City: any = [
    'Andhra Andaman and Nicobar (UT)',
    'Andhra Pradesh',
    'Arunachal Pradesh',
    'Assam',
    'Bihar',
    'Chandigarh (UT)',
    'Chhattisgarh',
    'Dadra and Nagar Haveli (UT)',
    'Daman and Diu (UT)',
    'Delhi',
    'Goa',
    'Gujarat',
    'Haryana',
    'Himachal Pradesh',
    'Jammu and Kashmir',
    'Jharkhand',
    'Karanataka',
    'Kerala',
    'Lakshadweep',
    'Madhya Pradesh',
    'Maharashtra',
    'Manipur',
    'Meghalaya',
    'Mizoram',
    'Nagaland',
    'Orissa',
    'Puducherry(UT)',
    'Punjab',
    'Rajasthan',
    'Sikkim',
    'Tamil Nadu',
    'Telangana',
    'Tirpura',
    'Uttara Pradesh',
    'Uttarakhnad',
    'West Bengal',
  ];
  District: any = ['apple', 'ant'];
  Taluck: any = ['Badvel', 'kadapaa', 'Nellore'];
  Schemes: any = [
    'National Merit scholarship',
    'PRAGATI SCHOLARSHIP',
    'Central Scholarship Scheme',
  ];

  scholarshipForm: FormGroup = new FormGroup({});
  submitted = false;
  isValidForm = false;

  constructor(private formBuilder: FormBuilder, private router: Router) {}

  ngOnInit(): void {
    this.scholarshipForm = this.formBuilder.group({
      district: ['', [Validators.required]],
      state: ['', [Validators.required]],
      taluk: ['', [Validators.required]],
      houseno: ['', [Validators.required]],
      streetno: ['', [Validators.required]],
      pincode: ['', [Validators.required]],
      schemeapplying: ['', [Validators.required]],
      domicilecerti: ['', [Validators.required]],
      studentphoto: ['', [Validators.required]],
      instiuteidcard: ['', [Validators.required]],
      cast: ['', [Validators.required]],
      previousyearmark: ['', [Validators.required]],
      feereceipt: ['', [Validators.required]],
      bankpassbook: ['', [Validators.required]],
      aadharcard: ['', [Validators.required]],
      tenclass: ['', [Validators.required]],
      twelthclass: ['', [Validators.required]],
      agree: [false, [Validators.requiredTrue]],
    });
  }

  get f(): { [key: string]: AbstractControl } {
    return this.scholarshipForm.controls;
  }

  onSubmit() {
    this.submitted = true;
    this.isValidForm = true;
    if (this.scholarshipForm.invalid) {
      this.isValidForm = true;
      return;
    }
    console.log(this.scholarshipForm.value);
    this.router.navigate(['/home']);
    this.reset();
  }
  reset() {
    this.submitted = false;
    this.isValidForm = false;
    this.scholarshipForm.reset();
  }
}