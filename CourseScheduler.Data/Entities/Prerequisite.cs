// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // PREREQUISITE
	using System.ComponentModel.DataAnnotations;
    public class Prerequisite
    {
        [StringLength(20)]
		public string CourseNum { get; set; } // COURSE_NUM (Primary key)
        [Range(0, 10)]
		public int OptionNum { get; set; } // OPTION_NUM (Primary key)
        [StringLength(20)]
		public string PreCourse { get; set; } // PRE_COURSE (Primary key)
        [Range(2, 3)]
		public decimal? GradeReq { get; set; } // GRADE_REQ

        // Foreign keys
        public virtual Course Course_CourseNum { get; set; } // PRE_COURSE_NO_FK
        public virtual Course Course_PreCourse { get; set; } // PRE_PRE_COURSE_NO_FK
    }

}
