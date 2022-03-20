import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutUsComponent } from './about-us/about-us.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { HomeComponent } from './home/home.component';
import { InstituteHomepageComponent } from './institute-homepage/institute-homepage.component';
import { InstituteRequestFormComponent } from './institute-request-form/institute-request-form.component';

import { NewRegistrationComponent } from './new-registration/new-registration.component';
import { RegistrationSuccessComponent } from './registration-success/registration-success.component';
import { ScholarshipFormUploadComponent } from './scholarship-form-upload/scholarship-form-upload.component';
import { ScholarshipFormComponent } from './scholarship-form/scholarship-form.component';
import { StudentApplicationVerificationComponent } from './student-application-verification/student-application-verification.component';
import { StudentHomeComponent } from './student-home/student-home.component';
import { UsersLoginComponent } from './users-login/users-login.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'about-us', component: AboutUsComponent },
  { path: 'contact-us', component: ContactUsComponent },
  { path: 'register', component: NewRegistrationComponent },
  { path: 'users-login', component: UsersLoginComponent },
  { path: 'register-sucsess', component: RegistrationSuccessComponent },
  { path: 'student-home', component: StudentHomeComponent },
  { path: 'scholarship-form', component: ScholarshipFormComponent },
  {
    path: 'scholarship-form-upload',
    component: ScholarshipFormUploadComponent,
  },
  { path: 'institute-form', component: InstituteRequestFormComponent },
  {
    path: 'application-verification',
    component: StudentApplicationVerificationComponent,
  },
  { path: 'institute-home-page', component: InstituteHomepageComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
