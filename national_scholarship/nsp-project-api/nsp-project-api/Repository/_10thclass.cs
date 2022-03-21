using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class _10thclass
    {
        public _10thclass()
        {
            Student = new HashSet<Student>();
            StudentRegistrationForm = new HashSet<StudentRegistrationForm>();
        }

        public int RollNumber { get; set; }
        public string BoardName { get; set; }
        public int? PassingYear { get; set; }
        public int? Percentage { get; set; }

        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<StudentRegistrationForm> StudentRegistrationForm { get; set; }
    }
}
