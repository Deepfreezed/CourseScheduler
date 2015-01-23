

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "CourseScheduler.Data\App.config"
//     Connection String Name: "DatabaseConnection"
//     Connection String:      "Data Source=.\SQLEXPRESS;Initial Catalog=CourseScheduler;Integrated Security=True;Application Name=CourseScheduler"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.5

using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using CourseScheduler.Data.Entities;
using CourseScheduler.Data.Context;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace CourseScheduler.Data.Mappings
{

    // ************************************************************************
    // POCO Configuration

    // CERTIFICATION
    internal class CertificationMappings : EntityTypeConfiguration<Certification>
    {
        public CertificationMappings(string schema = "dbo")
        {
            ToTable(schema + ".CERTIFICATION");
            HasKey(x => x.Certid);

            Property(x => x.Certid).HasColumnName("CERTID").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Category).HasColumnName("CATEGORY").IsOptional().HasMaxLength(20);
            Property(x => x.Certification_).HasColumnName("CERTIFICATION").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Description).HasColumnName("DESCRIPTION").IsOptional().IsUnicode(false).HasMaxLength(200);
        }
    }

    // CLUSTER_SUB_PROGRAM
    internal class ClusterSubProgramMappings : EntityTypeConfiguration<ClusterSubProgram>
    {
        public ClusterSubProgramMappings(string schema = "dbo")
        {
            ToTable(schema + ".CLUSTER_SUB_PROGRAM");
            HasKey(x => new { x.ClusterId, x.SubProgId, x.ProgNum });

            Property(x => x.ClusterId).HasColumnName("CLUSTER_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SubProgId).HasColumnName("SUB_PROG_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditHours).HasColumnName("CREDIT_HOURS").IsRequired();
            Property(x => x.Name).HasColumnName("NAME").IsOptional().HasMaxLength(100);
            Property(x => x.HasOptions).HasColumnName("HAS_OPTIONS").IsOptional();

            // Foreign keys
            HasRequired(a => a.SubProgram).WithMany(b => b.ClusterSubPrograms).HasForeignKey(c => new { c.SubProgId, c.ProgNum }); // CLUSTER_SUB_PROGRAM_SUB_P_FK1
        }
    }

    // COMPANY
    internal class CompanyMappings : EntityTypeConfiguration<Company>
    {
        public CompanyMappings(string schema = "dbo")
        {
            ToTable(schema + ".COMPANY");
            HasKey(x => x.CompId);

            Property(x => x.CompId).HasColumnName("COMP_ID").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CompName).HasColumnName("COMP_NAME").IsOptional().HasMaxLength(50);
        }
    }

    // CONCURENT_COURSE
    internal class ConcurentCourseMappings : EntityTypeConfiguration<ConcurentCourse>
    {
        public ConcurentCourseMappings(string schema = "dbo")
        {
            ToTable(schema + ".CONCURENT_COURSE");
            HasKey(x => x.CourseNum);

            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ConCourseNum).HasColumnName("CON_COURSE_NUM").IsRequired().HasMaxLength(20);

            // Foreign keys
            HasRequired(a => a.Course).WithOptional(b => b.ConcurentCourse); // CONCURENT_COURSE_FK
        }
    }

    // COURSE
    internal class CourseMappings : EntityTypeConfiguration<Course>
    {
        public CourseMappings(string schema = "dbo")
        {
            ToTable(schema + ".COURSE");
            HasKey(x => x.CourseNum);

            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CourseName).HasColumnName("COURSE_NAME").IsOptional().HasMaxLength(100);
            Property(x => x.DeptNum).HasColumnName("DEPT_NUM").IsOptional().HasMaxLength(10);
            Property(x => x.CreditHrs).HasColumnName("CREDIT_HRS").IsOptional();
            Property(x => x.CourseOffered).HasColumnName("COURSE_OFFERED").IsOptional();

            // Foreign keys
            HasOptional(a => a.Department).WithMany(b => b.Courses).HasForeignKey(c => c.DeptNum); // COURSE_DEPT_NUM_FK
            HasOptional(a => a.CourseOffering).WithMany(b => b.Courses).HasForeignKey(c => c.CourseOffered); // COURSE_OFFERED_FK
        }
    }

    // COURSE_CHG_HIST
    internal class CourseChgHistMappings : EntityTypeConfiguration<CourseChgHist>
    {
        public CourseChgHistMappings(string schema = "dbo")
        {
            ToTable(schema + ".COURSE_CHG_HIST");
            HasKey(x => new { x.DateChanged, x.CourseNum });

            Property(x => x.ChgType).HasColumnName("CHG_TYPE").IsRequired().HasMaxLength(20);
            Property(x => x.DateChanged).HasColumnName("DATE_CHANGED").IsRequired();
            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ChangeFrom).HasColumnName("CHANGE_FROM").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ChangeTo).HasColumnName("CHANGE_TO").IsRequired().IsUnicode(false).HasMaxLength(20);

            // Foreign keys
            HasRequired(a => a.Course).WithMany(b => b.CourseChgHists).HasForeignKey(c => c.CourseNum); // COURSE_CHG_HIST_FK
        }
    }

    // COURSE_CLUSTER_SUB_PROGRAM
    internal class CourseClusterSubProgramMappings : EntityTypeConfiguration<CourseClusterSubProgram>
    {
        public CourseClusterSubProgramMappings(string schema = "dbo")
        {
            ToTable(schema + ".COURSE_CLUSTER_SUB_PROGRAM");
            HasKey(x => new { x.ClusterId, x.SubProgId, x.ProgNum, x.CourseNum });

            Property(x => x.ClusterId).HasColumnName("CLUSTER_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SubProgId).HasColumnName("SUB_PROG_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MinGrade).HasColumnName("MIN_GRADE").IsRequired().HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.ClusterSubProgram).WithMany(b => b.CourseClusterSubPrograms).HasForeignKey(c => new { c.ClusterId, c.SubProgId, c.ProgNum }); // COURSE_CLUSTER_SUB_PROGRAM_FK1
            HasRequired(a => a.Course).WithMany(b => b.CourseClusterSubPrograms).HasForeignKey(c => c.CourseNum); // COURSE_CLUSTER_SUB_PROGRAM_FK2
        }
    }

    // COURSE_MULTI_CREDIT
    internal class CourseMultiCreditMappings : EntityTypeConfiguration<CourseMultiCredit>
    {
        public CourseMultiCreditMappings(string schema = "dbo")
        {
            ToTable(schema + ".COURSE_MULTI_CREDIT");
            HasKey(x => new { x.MaxCh, x.MinCh, x.CourseNum });

            Property(x => x.MaxCh).HasColumnName("MAX_CH").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MinCh).HasColumnName("MIN_CH").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.Course).WithMany(b => b.CourseMultiCredits).HasForeignKey(c => c.CourseNum); // COURSE_MULTI_CRD_FK
        }
    }

    // COURSE_OFFERING
    internal class CourseOfferingMappings : EntityTypeConfiguration<CourseOffering>
    {
        public CourseOfferingMappings(string schema = "dbo")
        {
            ToTable(schema + ".COURSE_OFFERING");
            HasKey(x => x.CourseOffered);

            Property(x => x.CourseOffered).HasColumnName("COURSE_OFFERED").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Descriptions).HasColumnName("DESCRIPTIONS").IsRequired().HasMaxLength(50);
        }
    }

    // COURSE_OPTION_CLUSTER_SUB_PROG
    internal class CourseOptionClusterSubProgMappings : EntityTypeConfiguration<CourseOptionClusterSubProg>
    {
        public CourseOptionClusterSubProgMappings(string schema = "dbo")
        {
            ToTable(schema + ".COURSE_OPTION_CLUSTER_SUB_PROG");
            HasKey(x => new { x.OptionId, x.ClusterId, x.SubProgId, x.ProgNum, x.CourseNum });

            Property(x => x.OptionId).HasColumnName("OPTION_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ClusterId).HasColumnName("CLUSTER_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SubProgId).HasColumnName("SUB_PROG_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MinGrade).HasColumnName("MIN_GRADE").IsRequired().HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.OptionalClusterSubProgram).WithMany(b => b.CourseOptionClusterSubProgs).HasForeignKey(c => new { c.OptionId, c.ClusterId, c.SubProgId, c.ProgNum }); // COURSE_OPTION_CLUSTER_SUB_FK1
            HasRequired(a => a.Course).WithMany(b => b.CourseOptionClusterSubProgs).HasForeignKey(c => c.CourseNum); // COURSE_OPTION_CLUSTER_SUB_FK2
        }
    }

    // COURSE_SUB_PROGRAM
    internal class CourseSubProgramMappings : EntityTypeConfiguration<CourseSubProgram>
    {
        public CourseSubProgramMappings(string schema = "dbo")
        {
            ToTable(schema + ".COURSE_SUB_PROGRAM");
            HasKey(x => new { x.ProgNum, x.CourseNum, x.SubProgId });

            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SubProgId).HasColumnName("SUB_PROG_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MinGrade).HasColumnName("MIN_GRADE").IsRequired().HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.SubProgram).WithMany(b => b.CourseSubPrograms).HasForeignKey(c => new { c.SubProgId, c.ProgNum }); // COURSE_SUB_PROGRAM_FK1
            HasRequired(a => a.Course).WithMany(b => b.CourseSubPrograms).HasForeignKey(c => c.CourseNum); // COURSE_SUB_PROGRAM_FK2
        }
    }

    // DEPARTMENT
    internal class DepartmentMappings : EntityTypeConfiguration<Department>
    {
        public DepartmentMappings(string schema = "dbo")
        {
            ToTable(schema + ".DEPARTMENT");
            HasKey(x => x.DeptNum);

            Property(x => x.DeptNum).HasColumnName("DEPT_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DeptName).HasColumnName("DEPT_NAME").IsOptional().HasMaxLength(50);
        }
    }

    // DEPT_NAME_HIST
    internal class DeptNameHistMappings : EntityTypeConfiguration<DeptNameHist>
    {
        public DeptNameHistMappings(string schema = "dbo")
        {
            ToTable(schema + ".DEPT_NAME_HIST");
            HasKey(x => new { x.DateChanged, x.DeptNum });

            Property(x => x.DateChanged).HasColumnName("DATE_CHANGED").IsRequired();
            Property(x => x.DeptNum).HasColumnName("DEPT_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("NAME").IsRequired().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Department).WithMany(b => b.DeptNameHists).HasForeignKey(c => c.DeptNum); // DEPT_NAME_HIST_FK
        }
    }

    // GEN_ED_COURSE
    internal class GenEdCourseMappings : EntityTypeConfiguration<GenEdCourse>
    {
        public GenEdCourseMappings(string schema = "dbo")
        {
            ToTable(schema + ".GEN_ED_COURSE");
            HasKey(x => new { x.CourseNum, x.GoalAreaId, x.CatalogYear });

            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.GoalAreaId).HasColumnName("GOAL_AREA_ID").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Laboratory).HasColumnName("LABORATORY").IsOptional().HasMaxLength(1);
            Property(x => x.GoldCulturDiver).HasColumnName("GOLD_CULTUR_DIVER").IsOptional().HasMaxLength(1);
            Property(x => x.PurpleCulturDiver).HasColumnName("PURPLE_CULTUR_DIVER").IsOptional().HasMaxLength(1);
            Property(x => x.CatalogYear).HasColumnName("CATALOG_YEAR").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.Course).WithMany(b => b.GenEdCourses).HasForeignKey(c => c.CourseNum); // GEN_ED_COUR_FK
            HasRequired(a => a.GoalArea).WithMany(b => b.GenEdCourses).HasForeignKey(c => c.GoalAreaId); // GEN_ED_FK2
        }
    }

    // GOAL_AREA
    internal class GoalAreaMappings : EntityTypeConfiguration<GoalArea>
    {
        public GoalAreaMappings(string schema = "dbo")
        {
            ToTable(schema + ".GOAL_AREA");
            HasKey(x => x.GoalAreaId);

            Property(x => x.GoalAreaId).HasColumnName("GOAL_AREA_ID").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.GoalAreaName).HasColumnName("GOAL_AREA_NAME").IsOptional().HasMaxLength(50);
            Property(x => x.MaxCreditHoursReq).HasColumnName("MAX_CREDIT_HOURS_REQ").IsOptional();
            Property(x => x.MinCreditHoursReq).HasColumnName("MIN_CREDIT_HOURS_REQ").IsOptional();
            Property(x => x.SpecialNotes).HasColumnName("SPECIAL_NOTES").IsOptional().HasMaxLength(2000);
        }
    }

    // JOB
    internal class JobMappings : EntityTypeConfiguration<Job>
    {
        public JobMappings(string schema = "dbo")
        {
            ToTable(schema + ".JOB");
            HasKey(x => x.Jno);

            Property(x => x.Jno).HasColumnName("JNO").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.JobName).HasColumnName("JOB_NAME").IsOptional().HasMaxLength(100);
            Property(x => x.JobDesc).HasColumnName("JOB_DESC").IsOptional().HasMaxLength(200);
        }
    }

    // OPTIONAL_CLUSTER_SUB_PROGRAM
    internal class OptionalClusterSubProgramMappings : EntityTypeConfiguration<OptionalClusterSubProgram>
    {
        public OptionalClusterSubProgramMappings(string schema = "dbo")
        {
            ToTable(schema + ".OPTIONAL_CLUSTER_SUB_PROGRAM");
            HasKey(x => new { x.OptionId, x.ClusterId, x.SubProgId, x.ProgNum });

            Property(x => x.OptionId).HasColumnName("OPTION_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ClusterId).HasColumnName("CLUSTER_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SubProgId).HasColumnName("SUB_PROG_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("NAME").IsOptional().HasMaxLength(100);
            Property(x => x.CreditHours).HasColumnName("CREDIT_HOURS").IsRequired();

            // Foreign keys
            HasRequired(a => a.ClusterSubProgram).WithMany(b => b.OptionalClusterSubPrograms).HasForeignKey(c => new { c.ClusterId, c.SubProgId, c.ProgNum }); // OPTIONAL_CLUSTER_SUB_PROG_FK1
        }
    }

    // PREREQUISITE
    internal class PrerequisiteMappings : EntityTypeConfiguration<Prerequisite>
    {
        public PrerequisiteMappings(string schema = "dbo")
        {
            ToTable(schema + ".PREREQUISITE");
            HasKey(x => new { x.CourseNum, x.OptionNum, x.PreCourse });

            Property(x => x.CourseNum).HasColumnName("COURSE_NUM").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OptionNum).HasColumnName("OPTION_NUM").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PreCourse).HasColumnName("PRE_COURSE").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.GradeReq).HasColumnName("GRADE_REQ").IsOptional().HasPrecision(3,2);

            // Foreign keys
            HasRequired(a => a.Course_CourseNum).WithMany(b => b.Prerequisites_CourseNum).HasForeignKey(c => c.CourseNum); // PRE_COURSE_NO_FK
            HasRequired(a => a.Course_PreCourse).WithMany(b => b.Prerequisites_PreCourse).HasForeignKey(c => c.PreCourse); // PRE_PRE_COURSE_NO_FK
        }
    }

    // PROG_DETAIL
    internal class ProgDetailMappings : EntityTypeConfiguration<ProgDetail>
    {
        public ProgDetailMappings(string schema = "dbo")
        {
            ToTable(schema + ".PROG_DETAIL");
            HasKey(x => new { x.ProgNum, x.BulletinYear });

            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.BulletinYear).HasColumnName("BULLETIN_YEAR").IsRequired().HasMaxLength(11).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CoreCh).HasColumnName("CORE_CH").IsRequired();
            Property(x => x.SubProgCh).HasColumnName("SUB_PROG_CH").IsOptional();
            Property(x => x.ElectiveCh).HasColumnName("ELECTIVE_CH").IsOptional();
            Property(x => x.MinorCh).HasColumnName("MINOR_CH").IsOptional();
            Property(x => x.GenedCh).HasColumnName("GENED_CH").IsOptional();
            Property(x => x.ReqGenedCh).HasColumnName("REQ_GENED_CH").IsOptional();
            Property(x => x.OptionalCh).HasColumnName("OPTIONAL_CH").IsOptional();
            Property(x => x.TotalCh).HasColumnName("TOTAL_CH").IsOptional();

            // Foreign keys
            HasRequired(a => a.Program).WithMany(b => b.ProgDetails).HasForeignKey(c => c.ProgNum); // PROGRAM_PROG_NUM_FK1
        }
    }

    // PROG_NAME_HIST
    internal class ProgNameHistMappings : EntityTypeConfiguration<ProgNameHist>
    {
        public ProgNameHistMappings(string schema = "dbo")
        {
            ToTable(schema + ".PROG_NAME_HIST");
            HasKey(x => new { x.DateChanged, x.ProgNum });

            Property(x => x.DateChanged).HasColumnName("DATE_CHANGED").IsRequired();
            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("NAME").IsRequired().HasMaxLength(50);
        }
    }

    // PROGRAM
    internal class ProgramMappings : EntityTypeConfiguration<Program>
    {
        public ProgramMappings(string schema = "dbo")
        {
            ToTable(schema + ".PROGRAM");
            HasKey(x => x.ProgNum);

            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProgName).HasColumnName("PROG_NAME").IsOptional().HasMaxLength(50);
            Property(x => x.DeptNum).HasColumnName("DEPT_NUM").IsOptional().HasMaxLength(10);
            Property(x => x.Type).HasColumnName("TYPE").IsOptional().HasMaxLength(20);
            Property(x => x.Class).HasColumnName("CLASS").IsOptional().HasMaxLength(50);
            Property(x => x.TotalCh).HasColumnName("TOTAL_CH").IsOptional();
            Property(x => x.Description).HasColumnName("DESCRIPTION").IsOptional().HasMaxLength(4000);
            Property(x => x.CatalogYear).HasColumnName("CATALOG_YEAR").IsOptional().HasMaxLength(20);
            Property(x => x.MinorRequired).HasColumnName("MINOR_REQUIRED").IsOptional().HasMaxLength(2000);

            // Foreign keys
            HasOptional(a => a.Department).WithMany(b => b.Programs).HasForeignKey(c => c.DeptNum); // PROGRAM_DEPTNUM_FK
        }
    }

    // SUB_PROGRAM
    internal class SubProgramMappings : EntityTypeConfiguration<SubProgram>
    {
        public SubProgramMappings(string schema = "dbo")
        {
            ToTable(schema + ".SUB_PROGRAM");
            HasKey(x => new { x.ProgNum, x.SubProgId });

            Property(x => x.ProgNum).HasColumnName("PROG_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SubProgId).HasColumnName("SUB_PROG_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditHours).HasColumnName("CREDIT_HOURS").IsRequired();
            Property(x => x.HasClusters).HasColumnName("HAS_CLUSTERS").IsRequired();

            // Foreign keys
            HasRequired(a => a.Program).WithMany(b => b.SubPrograms).HasForeignKey(c => c.ProgNum); // SUB_PROGRAM_FK
            HasRequired(a => a.SubProgramIdentifier).WithMany(b => b.SubPrograms).HasForeignKey(c => c.SubProgId); // SUB_PROGRAM_FK2
        }
    }

    // SUB_PROGRAM_IDENTIFIER
    internal class SubProgramIdentifierMappings : EntityTypeConfiguration<SubProgramIdentifier>
    {
        public SubProgramIdentifierMappings(string schema = "dbo")
        {
            ToTable(schema + ".SUB_PROGRAM_IDENTIFIER");
            HasKey(x => x.SubProgId);

            Property(x => x.SubProgId).HasColumnName("SUB_PROG_ID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("NAME").IsRequired().HasMaxLength(50);
            Property(x => x.CommonName).HasColumnName("COMMON_NAME").IsOptional().HasMaxLength(100);
        }
    }

    // TEACHER
    internal class TeacherMappings : EntityTypeConfiguration<Teacher>
    {
        public TeacherMappings(string schema = "dbo")
        {
            ToTable(schema + ".TEACHER");
            HasKey(x => x.TeacherNum);

            Property(x => x.TeacherNum).HasColumnName("TEACHER_NUM").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DeptNum).HasColumnName("DEPT_NUM").IsOptional().HasMaxLength(10);
            Property(x => x.Lname).HasColumnName("LNAME").IsOptional().HasMaxLength(25);
            Property(x => x.Fname).HasColumnName("FNAME").IsOptional().HasMaxLength(25);

            // Foreign keys
            HasOptional(a => a.Department).WithMany(b => b.Teachers).HasForeignKey(c => c.DeptNum); // TEACHER_DEPTNUM_FK
        }
    }

}
