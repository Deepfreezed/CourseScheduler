// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // DEPARTMENT
	using System.ComponentModel.DataAnnotations;
    public class Department
    {
        [StringLength(10)]
		public string DeptNum { get; set; } // DEPT_NUM (Primary key)
        [StringLength(50)]
		public string DeptName { get; set; } // DEPT_NAME

        // Reverse navigation
        public virtual ICollection<Course> Courses { get; set; } // COURSE.COURSE_DEPT_NUM_FK
        public virtual ICollection<DeptNameHist> DeptNameHists { get; set; } // Many to many mapping
        public virtual ICollection<Program> Programs { get; set; } // PROGRAM.PROGRAM_DEPTNUM_FK
        public virtual ICollection<Teacher> Teachers { get; set; } // TEACHER.TEACHER_DEPTNUM_FK

        public Department()
        {
            Courses = new List<Course>();
            DeptNameHists = new List<DeptNameHist>();
            Programs = new List<Program>();
            Teachers = new List<Teacher>();
        }
    }

}
