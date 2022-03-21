using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class Student
    {
        public Student()
        {
            ScholarshipApplicationForm = new HashSet<ScholarshipApplicationForm>();
            StudentRegistrationForm = new HashSet<StudentRegistrationForm>();
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public DateTime? Dob { get; set; }
        public string AdharCard { get; set; }
        public int? RollNumber { get; set; }
        public string Disability { get; set; }
        public string TypeOfDisability { get; set; }
        public int? PercentageOfDisability { get; set; }
        public string MaritalStatus { get; set; }
        public string ParentsProfession { get; set; }
        public int? InstituteCode { get; set; }
        public string House { get; set; }
        public string Pincode { get; set; }
        public int? Rnumber { get; set; }

        public virtual _12thclass RnumberNavigation { get; set; }
        public virtual _10thclass RollNumberNavigation { get; set; }
        public virtual ICollection<ScholarshipApplicationForm> ScholarshipApplicationForm { get; set; }
        public virtual ICollection<StudentRegistrationForm> StudentRegistrationForm { get; set; }
    }
}
