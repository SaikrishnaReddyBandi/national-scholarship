using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class InstituteRegistrationForm
    {
        public int InstituteCode { get; set; }
        public string InstituteName { get; set; }
        public string InstituteCategory { get; set; }
        public string DiseCode { get; set; }
        public string Location { get; set; }
        public string AffiliatedUniversityState { get; set; }
        public string AffiliatedBoardName { get; set; }
        public DateTime? AdmissionStartedYear { get; set; }
        public string Setpassword { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string PrincipleName { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string UniversityCirtificate { get; set; }
        public string BoardCirtificate { get; set; }
        public string State { get; set; }
        public string District { get; set; }

        public virtual InstituteStateMinistryLogin InstituteStateMinistryLogin { get; set; }
    }
}
