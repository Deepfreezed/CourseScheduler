

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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using CourseScheduler.Data.Entities;
using CourseScheduler.Data.Mappings;

namespace CourseScheduler.Data.Context
{
    // ************************************************************************
    // Unit of work
    public interface ICourseSchedulerContext : IDisposable
    {
        IDbSet<Certification> Certifications { get; set; } // CERTIFICATION
        IDbSet<ClusterSubProgram> ClusterSubPrograms { get; set; } // CLUSTER_SUB_PROGRAM
        IDbSet<Company> Companies { get; set; } // COMPANY
        IDbSet<ConcurentCourse> ConcurentCourses { get; set; } // CONCURENT_COURSE
        IDbSet<Course> Courses { get; set; } // COURSE
        IDbSet<CourseChgHist> CourseChgHists { get; set; } // COURSE_CHG_HIST
        IDbSet<CourseClusterSubProgram> CourseClusterSubPrograms { get; set; } // COURSE_CLUSTER_SUB_PROGRAM
        IDbSet<CourseMultiCredit> CourseMultiCredits { get; set; } // COURSE_MULTI_CREDIT
        IDbSet<CourseOffering> CourseOfferings { get; set; } // COURSE_OFFERING
        IDbSet<CourseOptionClusterSubProg> CourseOptionClusterSubProgs { get; set; } // COURSE_OPTION_CLUSTER_SUB_PROG
        IDbSet<CourseSubProgram> CourseSubPrograms { get; set; } // COURSE_SUB_PROGRAM
        IDbSet<Department> Departments { get; set; } // DEPARTMENT
        IDbSet<DeptNameHist> DeptNameHists { get; set; } // DEPT_NAME_HIST
        IDbSet<GenEdCourse> GenEdCourses { get; set; } // GEN_ED_COURSE
        IDbSet<GoalArea> GoalAreas { get; set; } // GOAL_AREA
        IDbSet<Job> Jobs { get; set; } // JOB
        IDbSet<OptionalClusterSubProgram> OptionalClusterSubPrograms { get; set; } // OPTIONAL_CLUSTER_SUB_PROGRAM
        IDbSet<Prerequisite> Prerequisites { get; set; } // PREREQUISITE
        IDbSet<ProgDetail> ProgDetails { get; set; } // PROG_DETAIL
        IDbSet<ProgNameHist> ProgNameHists { get; set; } // PROG_NAME_HIST
        IDbSet<Program> Programs { get; set; } // PROGRAM
        IDbSet<SubProgram> SubPrograms { get; set; } // SUB_PROGRAM
        IDbSet<SubProgramIdentifier> SubProgramIdentifiers { get; set; } // SUB_PROGRAM_IDENTIFIER
        IDbSet<Teacher> Teachers { get; set; } // TEACHER

        int SaveChanges();
    }

    // ************************************************************************
    // Database context
    public class CourseSchedulerContext : DbContext, ICourseSchedulerContext
    {
        public IDbSet<Certification> Certifications { get; set; } // CERTIFICATION
        public IDbSet<ClusterSubProgram> ClusterSubPrograms { get; set; } // CLUSTER_SUB_PROGRAM
        public IDbSet<Company> Companies { get; set; } // COMPANY
        public IDbSet<ConcurentCourse> ConcurentCourses { get; set; } // CONCURENT_COURSE
        public IDbSet<Course> Courses { get; set; } // COURSE
        public IDbSet<CourseChgHist> CourseChgHists { get; set; } // COURSE_CHG_HIST
        public IDbSet<CourseClusterSubProgram> CourseClusterSubPrograms { get; set; } // COURSE_CLUSTER_SUB_PROGRAM
        public IDbSet<CourseMultiCredit> CourseMultiCredits { get; set; } // COURSE_MULTI_CREDIT
        public IDbSet<CourseOffering> CourseOfferings { get; set; } // COURSE_OFFERING
        public IDbSet<CourseOptionClusterSubProg> CourseOptionClusterSubProgs { get; set; } // COURSE_OPTION_CLUSTER_SUB_PROG
        public IDbSet<CourseSubProgram> CourseSubPrograms { get; set; } // COURSE_SUB_PROGRAM
        public IDbSet<Department> Departments { get; set; } // DEPARTMENT
        public IDbSet<DeptNameHist> DeptNameHists { get; set; } // DEPT_NAME_HIST
        public IDbSet<GenEdCourse> GenEdCourses { get; set; } // GEN_ED_COURSE
        public IDbSet<GoalArea> GoalAreas { get; set; } // GOAL_AREA
        public IDbSet<Job> Jobs { get; set; } // JOB
        public IDbSet<OptionalClusterSubProgram> OptionalClusterSubPrograms { get; set; } // OPTIONAL_CLUSTER_SUB_PROGRAM
        public IDbSet<Prerequisite> Prerequisites { get; set; } // PREREQUISITE
        public IDbSet<ProgDetail> ProgDetails { get; set; } // PROG_DETAIL
        public IDbSet<ProgNameHist> ProgNameHists { get; set; } // PROG_NAME_HIST
        public IDbSet<Program> Programs { get; set; } // PROGRAM
        public IDbSet<SubProgram> SubPrograms { get; set; } // SUB_PROGRAM
        public IDbSet<SubProgramIdentifier> SubProgramIdentifiers { get; set; } // SUB_PROGRAM_IDENTIFIER
        public IDbSet<Teacher> Teachers { get; set; } // TEACHER

        static CourseSchedulerContext()
        {
            Database.SetInitializer<CourseSchedulerContext>(null);
        }

        public CourseSchedulerContext()
            : base("Name=DatabaseConnection")
        {
        }

        public CourseSchedulerContext(string connectionString) : base(connectionString)
        {
        }

        public CourseSchedulerContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CertificationMappings());
            modelBuilder.Configurations.Add(new ClusterSubProgramMappings());
            modelBuilder.Configurations.Add(new CompanyMappings());
            modelBuilder.Configurations.Add(new ConcurentCourseMappings());
            modelBuilder.Configurations.Add(new CourseMappings());
            modelBuilder.Configurations.Add(new CourseChgHistMappings());
            modelBuilder.Configurations.Add(new CourseClusterSubProgramMappings());
            modelBuilder.Configurations.Add(new CourseMultiCreditMappings());
            modelBuilder.Configurations.Add(new CourseOfferingMappings());
            modelBuilder.Configurations.Add(new CourseOptionClusterSubProgMappings());
            modelBuilder.Configurations.Add(new CourseSubProgramMappings());
            modelBuilder.Configurations.Add(new DepartmentMappings());
            modelBuilder.Configurations.Add(new DeptNameHistMappings());
            modelBuilder.Configurations.Add(new GenEdCourseMappings());
            modelBuilder.Configurations.Add(new GoalAreaMappings());
            modelBuilder.Configurations.Add(new JobMappings());
            modelBuilder.Configurations.Add(new OptionalClusterSubProgramMappings());
            modelBuilder.Configurations.Add(new PrerequisiteMappings());
            modelBuilder.Configurations.Add(new ProgDetailMappings());
            modelBuilder.Configurations.Add(new ProgNameHistMappings());
            modelBuilder.Configurations.Add(new ProgramMappings());
            modelBuilder.Configurations.Add(new SubProgramMappings());
            modelBuilder.Configurations.Add(new SubProgramIdentifierMappings());
            modelBuilder.Configurations.Add(new TeacherMappings());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CertificationMappings(schema));
            modelBuilder.Configurations.Add(new ClusterSubProgramMappings(schema));
            modelBuilder.Configurations.Add(new CompanyMappings(schema));
            modelBuilder.Configurations.Add(new ConcurentCourseMappings(schema));
            modelBuilder.Configurations.Add(new CourseMappings(schema));
            modelBuilder.Configurations.Add(new CourseChgHistMappings(schema));
            modelBuilder.Configurations.Add(new CourseClusterSubProgramMappings(schema));
            modelBuilder.Configurations.Add(new CourseMultiCreditMappings(schema));
            modelBuilder.Configurations.Add(new CourseOfferingMappings(schema));
            modelBuilder.Configurations.Add(new CourseOptionClusterSubProgMappings(schema));
            modelBuilder.Configurations.Add(new CourseSubProgramMappings(schema));
            modelBuilder.Configurations.Add(new DepartmentMappings(schema));
            modelBuilder.Configurations.Add(new DeptNameHistMappings(schema));
            modelBuilder.Configurations.Add(new GenEdCourseMappings(schema));
            modelBuilder.Configurations.Add(new GoalAreaMappings(schema));
            modelBuilder.Configurations.Add(new JobMappings(schema));
            modelBuilder.Configurations.Add(new OptionalClusterSubProgramMappings(schema));
            modelBuilder.Configurations.Add(new PrerequisiteMappings(schema));
            modelBuilder.Configurations.Add(new ProgDetailMappings(schema));
            modelBuilder.Configurations.Add(new ProgNameHistMappings(schema));
            modelBuilder.Configurations.Add(new ProgramMappings(schema));
            modelBuilder.Configurations.Add(new SubProgramMappings(schema));
            modelBuilder.Configurations.Add(new SubProgramIdentifierMappings(schema));
            modelBuilder.Configurations.Add(new TeacherMappings(schema));
            return modelBuilder;
        }
    }

    // ************************************************************************
    // Fake Database context
    public class FakeCourseSchedulerContext : ICourseSchedulerContext
    {
        public IDbSet<Certification> Certifications { get; set; }
        public IDbSet<ClusterSubProgram> ClusterSubPrograms { get; set; }
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<ConcurentCourse> ConcurentCourses { get; set; }
        public IDbSet<Course> Courses { get; set; }
        public IDbSet<CourseChgHist> CourseChgHists { get; set; }
        public IDbSet<CourseClusterSubProgram> CourseClusterSubPrograms { get; set; }
        public IDbSet<CourseMultiCredit> CourseMultiCredits { get; set; }
        public IDbSet<CourseOffering> CourseOfferings { get; set; }
        public IDbSet<CourseOptionClusterSubProg> CourseOptionClusterSubProgs { get; set; }
        public IDbSet<CourseSubProgram> CourseSubPrograms { get; set; }
        public IDbSet<Department> Departments { get; set; }
        public IDbSet<DeptNameHist> DeptNameHists { get; set; }
        public IDbSet<GenEdCourse> GenEdCourses { get; set; }
        public IDbSet<GoalArea> GoalAreas { get; set; }
        public IDbSet<Job> Jobs { get; set; }
        public IDbSet<OptionalClusterSubProgram> OptionalClusterSubPrograms { get; set; }
        public IDbSet<Prerequisite> Prerequisites { get; set; }
        public IDbSet<ProgDetail> ProgDetails { get; set; }
        public IDbSet<ProgNameHist> ProgNameHists { get; set; }
        public IDbSet<Program> Programs { get; set; }
        public IDbSet<SubProgram> SubPrograms { get; set; }
        public IDbSet<SubProgramIdentifier> SubProgramIdentifiers { get; set; }
        public IDbSet<Teacher> Teachers { get; set; }

        public FakeCourseSchedulerContext()
        {
            Certifications = new FakeDbSet<Certification>();
            ClusterSubPrograms = new FakeDbSet<ClusterSubProgram>();
            Companies = new FakeDbSet<Company>();
            ConcurentCourses = new FakeDbSet<ConcurentCourse>();
            Courses = new FakeDbSet<Course>();
            CourseChgHists = new FakeDbSet<CourseChgHist>();
            CourseClusterSubPrograms = new FakeDbSet<CourseClusterSubProgram>();
            CourseMultiCredits = new FakeDbSet<CourseMultiCredit>();
            CourseOfferings = new FakeDbSet<CourseOffering>();
            CourseOptionClusterSubProgs = new FakeDbSet<CourseOptionClusterSubProg>();
            CourseSubPrograms = new FakeDbSet<CourseSubProgram>();
            Departments = new FakeDbSet<Department>();
            DeptNameHists = new FakeDbSet<DeptNameHist>();
            GenEdCourses = new FakeDbSet<GenEdCourse>();
            GoalAreas = new FakeDbSet<GoalArea>();
            Jobs = new FakeDbSet<Job>();
            OptionalClusterSubPrograms = new FakeDbSet<OptionalClusterSubProgram>();
            Prerequisites = new FakeDbSet<Prerequisite>();
            ProgDetails = new FakeDbSet<ProgDetail>();
            ProgNameHists = new FakeDbSet<ProgNameHist>();
            Programs = new FakeDbSet<Program>();
            SubPrograms = new FakeDbSet<SubProgram>();
            SubProgramIdentifiers = new FakeDbSet<SubProgramIdentifier>();
            Teachers = new FakeDbSet<Teacher>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException(); 
        }
    }

    // ************************************************************************
    // Fake DbSet
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }
}
