using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace nsp_project_api.Repository
{
    public partial class dbNSPContext : DbContext
    {
        public dbNSPContext()
        {
        }

        public dbNSPContext(DbContextOptions<dbNSPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aproval> Aproval { get; set; }
        public virtual DbSet<InstituteRegistrationForm> InstituteRegistrationForm { get; set; }
        public virtual DbSet<InstituteStateMinistryLogin> InstituteStateMinistryLogin { get; set; }
        public virtual DbSet<ScholarshipApplicationForm> ScholarshipApplicationForm { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentLogin> StudentLogin { get; set; }
        public virtual DbSet<StudentRegistrationForm> StudentRegistrationForm { get; set; }
        public virtual DbSet<_10thclass> _10thclass { get; set; }
        public virtual DbSet<_12thclass> _12thclass { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=USER;initial catalog=dbNSP;user id=sa;password=Saireddy@136");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aproval>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InstituteCode).HasColumnName("Institute_code");

                entity.HasOne(d => d.App)
                    .WithMany()
                    .HasForeignKey(d => d.Appid)
                    .HasConstraintName("FK__Aproval__Appid__4E88ABD4");

                entity.HasOne(d => d.InstituteCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.InstituteCode)
                    .HasConstraintName("FK__Aproval__Institu__4F7CD00D");
            });

            modelBuilder.Entity<InstituteRegistrationForm>(entity =>
            {
                entity.HasKey(e => e.InstituteCode)
                    .HasName("PK__Institut__F81111BB7AE7D173");

                entity.ToTable("InstituteRegistration_Form");

                entity.Property(e => e.InstituteCode)
                    .HasColumnName("Institute_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdmissionStartedYear).HasColumnType("date");

                entity.Property(e => e.AffiliatedBoardName)
                    .HasColumnName("Affiliated_BoardName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AffiliatedUniversityState)
                    .HasColumnName("Affiliated_UniversityState")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BoardCirtificate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiseCode)
                    .HasColumnName("Dise_Code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Line1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Line2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipleName)
                    .HasColumnName("Principle_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Setpassword)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityCirtificate)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstituteStateMinistryLogin>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__institut__CBA1B257BEFC80E8");

                entity.ToTable("institute/state/ministry_Login");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.InstituteStateMinistryLogin)
                    .HasForeignKey<InstituteStateMinistryLogin>(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__institute__useri__48CFD27E");
            });

            modelBuilder.Entity<ScholarshipApplicationForm>(entity =>
            {
                entity.HasKey(e => e.Appid)
                    .HasName("PK__Scholars__8E2FE871CC0B6DB9");

                entity.ToTable("ScholarshipApplication_Form");

                entity.Property(e => e.Appid).ValueGeneratedNever();

                entity.Property(e => e.AdharCard)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppliedScheme)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClassStartDate).HasColumnType("date");

                entity.Property(e => e.Community)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyIncome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModeofStudy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCourse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCourseYear).HasColumnType("date");

                entity.Property(e => e.PreviousCourse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousPassingYear).HasColumnType("date");

                entity.Property(e => e.Religion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.AdharCardNavigation)
                    .WithMany(p => p.ScholarshipApplicationForm)
                    .HasForeignKey(d => d.AdharCard)
                    .HasConstraintName("FK__Scholarsh__Adhar__46E78A0C");

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.ScholarshipApplicationForm)
                    .HasForeignKey(d => d.Regid)
                    .HasConstraintName("FK__Scholarsh__Regid__4D94879B");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.AdharCard)
                    .HasName("PK__Student__14AA54EBA7F02308");

                entity.Property(e => e.AdharCard)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Disability)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasColumnName("Email_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.House)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteCode).HasColumnName("Institute_Code");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("Marital_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("Mobile_Number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParentsProfession)
                    .HasColumnName("Parents_Profession")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PercentageOfDisability).HasColumnName("Percentage_of_Disability");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RollNumber).HasColumnName("Roll_Number");

                entity.Property(e => e.TypeOfDisability)
                    .HasColumnName("Type_of_Disability")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RnumberNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.Rnumber)
                    .HasConstraintName("FK__Student__Rnumber__49C3F6B7");

                entity.HasOne(d => d.RollNumberNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.RollNumber)
                    .HasConstraintName("FK__Student__Roll_Nu__4AB81AF0");
            });

            modelBuilder.Entity<StudentLogin>(entity =>
            {
                entity.HasKey(e => e.Regid)
                    .HasName("PK__StudentL__2C6CDE80C5B6DAAC");

                entity.Property(e => e.Regid).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Reg)
                    .WithOne(p => p.StudentLogin)
                    .HasForeignKey<StudentLogin>(d => d.Regid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentLo__Regid__47DBAE45");
            });

            modelBuilder.Entity<StudentRegistrationForm>(entity =>
            {
                entity.HasKey(e => e.Regid)
                    .HasName("PK__Student___2C6CDE80A4A6FEEA");

                entity.ToTable("Student_RegistrationForm");

                entity.Property(e => e.Regid).ValueGeneratedNever();

                entity.Property(e => e.AdharCard)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasColumnName("Bank_AccountNo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BankIfsccode)
                    .HasColumnName("Bank_IFSCcode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Setpassword)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e._10thRollno).HasColumnName("10th_Rollno");

                entity.Property(e => e._12thRollno).HasColumnName("12th_Rollno");

                entity.HasOne(d => d.AdharCardNavigation)
                    .WithMany(p => p.StudentRegistrationForm)
                    .HasForeignKey(d => d.AdharCard)
                    .HasConstraintName("FK__Student_R__Adhar__45F365D3");

                entity.HasOne(d => d._10thRollnoNavigation)
                    .WithMany(p => p.StudentRegistrationForm)
                    .HasForeignKey(d => d._10thRollno)
                    .HasConstraintName("FK__Student_R__10th___4BAC3F29");

                entity.HasOne(d => d._12thRollnoNavigation)
                    .WithMany(p => p.StudentRegistrationForm)
                    .HasForeignKey(d => d._12thRollno)
                    .HasConstraintName("FK__Student_R__12th___4CA06362");
            });

            modelBuilder.Entity<_10thclass>(entity =>
            {
                entity.HasKey(e => e.RollNumber)
                    .HasName("PK__10thclas__E9F06F170FE929A8");

                entity.ToTable("10thclass");

                entity.Property(e => e.RollNumber).ValueGeneratedNever();

                entity.Property(e => e.BoardName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_12thclass>(entity =>
            {
                entity.HasKey(e => e.Rnumber)
                    .HasName("PK__12thclas__2E715953A7353E90");

                entity.ToTable("12thclass");

                entity.Property(e => e.Rnumber).ValueGeneratedNever();

                entity.Property(e => e.BoardName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
