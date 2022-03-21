using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class StudentRegistrationForm
    {
        public StudentRegistrationForm()
        {
            ScholarshipApplicationForm = new HashSet<ScholarshipApplicationForm>();
        }

        public int Regid { get; set; }
        public int? _10thRollno { get; set; }
        public int? _12thRollno { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankIfsccode { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Setpassword { get; set; }
        public string AdharCard { get; set; }

        public virtual Student AdharCardNavigation { get; set; }
        public virtual _10thclass _10thRollnoNavigation { get; set; }
        public virtual _12thclass _12thRollnoNavigation { get; set; }
        public virtual StudentLogin StudentLogin { get; set; }
        public virtual ICollection<ScholarshipApplicationForm> ScholarshipApplicationForm { get; set; }
    }
}
