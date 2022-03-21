using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class InstituteStateMinistryLogin
    {
        public int Userid { get; set; }
        public string Password { get; set; }

        public virtual InstituteRegistrationForm User { get; set; }
    }
}
