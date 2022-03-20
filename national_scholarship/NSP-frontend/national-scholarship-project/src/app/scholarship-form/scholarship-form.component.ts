import { Component, OnInit } from '@angular/core';
import {
  FormControl,
  FormGroup,
  AbstractControl,
  Validators,
  FormBuilder,
} from '@angular/forms';
import { Validation } from '../validation';
import { Router } from '@angular/router';

@Component({
  selector: 'app-scholarship-form',
  templateUrl: './scholarship-form.component.html',
  styleUrls: ['./scholarship-form.component.css'],
})
export class ScholarshipFormComponent implements OnInit {
  scholarshipForm: FormGroup = new FormGroup({});
  submitted = false;

  constructor(private formBuilder: FormBuilder, private router: Router) {}

  ngOnInit(): void {
    this.scholarshipForm = this.formBuilder.group({
      regligion: ['', [Validators.required]],
      community: ['', [Validators.required]],
      fatherName: ['', [Validators.required]],
      mothername: ['', [Validators.required]],
      familyincome: ['', [Validators.required]],
      institutename: ['', [Validators.required]],
      presentclasscourse: ['', [Validators.required]],
      presentclassyear: ['', [Validators.required]],
      modeofstudy: ['', [Validators.required]],
      classstartdate: ['', [Validators.required]],
      universityname: ['', [Validators.required]],
      previousclasscourse: ['', [Validators.required]],
      previouspassingyear: ['', [Validators.required]],

      tenthRollNumber: ['', [Validators.required]],
      tenthboardname: ['', [Validators.required]],
      tenthpassingyear: ['', [Validators.required]],
      tenthpercentageobtained: ['', [Validators.required]],

      twelthrollnumber: ['', [Validators.required]],
      twelthboardname: ['', [Validators.required]],
      twelthpassingyear: ['', [Validators.required]],
      twelthpercentageobtained: ['', [Validators.required]],

      admissionFee: ['', [Validators.required]],
      tutionFee: ['', [Validators.required]],
      otherFee: ['', [Validators.required]],
      typeOfDisabled: ['', [Validators.required]],
      maritalStatus: ['', [Validators.required]],
      parentsProfession: ['', [Validators.required]],
      isDisabled: ['', [Validators.required]],
      percentageDisabled: ['', [Validators.required]],
      previousclasspercentage: ['', [Validators.required]],

      aadharNumber: [
        '',
        [
          Validators.required,
          Validators.maxLength(12),
          Validators.pattern('^[0-9]{12}$'),
        ],
      ],
    });
  }

  get f(): { [key: string]: AbstractControl } {
    return this.scholarshipForm.controls;
  }

  onSubmit() {
    this.submitted = true;
    if (this.scholarshipForm.invalid) {
      return;
    }
    console.log(this.scholarshipForm.value);
    this.router.navigate(['/scholarship-form-upload']);
  }
}