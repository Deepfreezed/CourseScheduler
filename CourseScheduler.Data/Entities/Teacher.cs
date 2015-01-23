// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // TEACHER
	using System.ComponentModel.DataAnnotations;
    public class Teacher
    {
        [StringLength(10)]
		public string TeacherNum { get; set; } // TEACHER_NUM (Primary key)
        [StringLength(10)]
		public string DeptNum { get; set; } // DEPT_NUM
        [StringLength(25)]
		public string Lname { get; set; } // LNAME
        [StringLength(25)]
		public string Fname { get; set; } // FNAME

        // Foreign keys
        public virtual Department Department { get; set; } // TEACHER_DEPTNUM_FK
    }

}
