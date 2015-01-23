// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // COURSE
	using System.ComponentModel.DataAnnotations;
    public class Course
    {
        [StringLength(20)]
		public string CourseNum { get; set; } // COURSE_NUM (Primary key)
        [StringLength(100)]
		public string CourseName { get; set; } // COURSE_NAME
        [StringLength(10)]
		public string DeptNum { get; set; } // DEPT_NUM
        [Range(0, 3)]
		public decimal? CreditHrs { get; set; } // CREDIT_HRS
        [Range(0, 1)]
		public decimal? CourseOffered { get; set; } // COURSE_OFFERED

        // Reverse navigation
        public virtual ConcurentCourse ConcurentCourse { get; set; } // CONCURENT_COURSE.CONCURENT_COURSE_FK
        public virtual ICollection<CourseChgHist> CourseChgHists { get; set; } // Many to many mapping
        public virtual ICollection<CourseClusterSubProgram> CourseClusterSubPrograms { get; set; } // Many to many mapping
        public virtual ICollection<CourseMultiCredit> CourseMultiCredits { get; set; } // Many to many mapping
        public virtual ICollection<CourseOptionClusterSubProg> CourseOptionClusterSubProgs { get; set; } // Many to many mapping
        public virtual ICollection<CourseSubProgram> CourseSubPrograms { get; set; } // Many to many mapping
        public virtual ICollection<GenEdCourse> GenEdCourses { get; set; } // Many to many mapping
        public virtual ICollection<Prerequisite> Prerequisites_CourseNum { get; set; } // Many to many mapping
        public virtual ICollection<Prerequisite> Prerequisites_PreCourse { get; set; } // Many to many mapping

        // Foreign keys
        public virtual CourseOffering CourseOffering { get; set; } // COURSE_OFFERED_FK
        public virtual Department Department { get; set; } // COURSE_DEPT_NUM_FK

        public Course()
        {
            CourseChgHists = new List<CourseChgHist>();
            CourseClusterSubPrograms = new List<CourseClusterSubProgram>();
            CourseMultiCredits = new List<CourseMultiCredit>();
            CourseOptionClusterSubProgs = new List<CourseOptionClusterSubProg>();
            CourseSubPrograms = new List<CourseSubProgram>();
            GenEdCourses = new List<GenEdCourse>();
            Prerequisites_CourseNum = new List<Prerequisite>();
            Prerequisites_PreCourse = new List<Prerequisite>();
        }
    }

}
