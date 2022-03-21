using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class Aproval
    {
        public int? Appid { get; set; }
        public int? InstituteCode { get; set; }

        public virtual ScholarshipApplicationForm App { get; set; }
        public virtual InstituteRegistrationForm InstituteCodeNavigation { get; set; }
    }
}
