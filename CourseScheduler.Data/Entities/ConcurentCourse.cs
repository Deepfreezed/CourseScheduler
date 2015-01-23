// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // CONCURENT_COURSE
	using System.ComponentModel.DataAnnotations;
    public class ConcurentCourse
    {
        [StringLength(20)]
		public string CourseNum { get; set; } // COURSE_NUM (Primary key)
        [StringLength(20)]
		public string ConCourseNum { get; set; } // CON_COURSE_NUM

        // Foreign keys
        public virtual Course Course { get; set; } // CONCURENT_COURSE_FK
    }

}
