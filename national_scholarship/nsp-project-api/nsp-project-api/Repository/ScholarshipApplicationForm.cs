using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class ScholarshipApplicationForm
    {
        public int Appid { get; set; }
        public int? Regid { get; set; }
        public string Religion { get; set; }
        public string Community { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string PresentCourse { get; set; }
        public DateTime? PresentCourseYear { get; set; }
        public string FamilyIncome { get; set; }
        public string ModeofStudy { get; set; }
        public DateTime? ClassStartDate { get; set; }
        public string UniversityName { get; set; }
        public string PreviousCourse { get; set; }
        public DateTime? PreviousPassingYear { get; set; }
        public double? PreviousYearPercentage { get; set; }
        public int? AdmissionFee { get; set; }
        public int? TutionFee { get; set; }
        public int? OtherFee { get; set; }
        public string AppliedScheme { get; set; }
        public int? Documentid { get; set; }
        public string AdharCard { get; set; }

        public virtual Student AdharCardNavigation { get; set; }
        public virtual StudentRegistrationForm Reg { get; set; }
    }
}
