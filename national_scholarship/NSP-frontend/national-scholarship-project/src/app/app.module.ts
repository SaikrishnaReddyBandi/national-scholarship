import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { StudentLoginComponent } from './student-login/student-login.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { NewRegistrationComponent } from './new-registration/new-registration.component';
import { ScholarshipPortalComponent } from './scholarship-portal/scholarship-portal.component';
import { UsersLoginComponent } from './users-login/users-login.component';
import { RegistrationSuccessComponent } from './registration-success/registration-success.component';
import { StudentHomeComponent } from './student-home/student-home.component';
import { ScholarshipFormComponent } from './scholarship-form/scholarship-form.component';
import { ScholarshipFormUploadComponent } from './scholarship-form-upload/scholarship-form-upload.component';
import { InstituteRequestFormComponent } from './institute-request-form/institute-request-form.component';
import { StudentApplicationVerificationComponent } from './student-application-verification/student-application-verification.component';
import { InstituteHomepageComponent } from './institute-homepage/institute-homepage.component';
import { PostmatricScholarshipDialogComponent } from './postmatric-scholarship-dialog/postmatric-scholarship-dialog.component';
import { MaterialModule } from './material/material.module';
import { NationalmeritScholarshipDialogComponent } from './nationalmerit-scholarship-dialog/nationalmerit-scholarship-dialog.component';
import { CentralScholarshipDialogComponent } from './central-scholarship-dialog/central-scholarship-dialog.component';
import { InstituteLoginComponent } from './institute-login/institute-login.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentLoginComponent,
    AboutUsComponent,
    ContactUsComponent,
    NewRegistrationComponent,
    ScholarshipPortalComponent,
    UsersLoginComponent,
    RegistrationSuccessComponent,
    StudentHomeComponent,
    ScholarshipFormComponent,
    ScholarshipFormUploadComponent,
    InstituteRequestFormComponent,
    StudentApplicationVerificationComponent,
    InstituteHomepageComponent,
    PostmatricScholarshipDialogComponent,
    NationalmeritScholarshipDialogComponent,
    CentralScholarshipDialogComponent,
    InstituteLoginComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ReactiveFormsModule,
    MaterialModule,
  ],
  providers: [],
  entryComponents: [
    PostmatricScholarshipDialogComponent,
    NationalmeritScholarshipDialogComponent,
  ],

  bootstrap: [AppComponent],
})
export class AppModule {}
