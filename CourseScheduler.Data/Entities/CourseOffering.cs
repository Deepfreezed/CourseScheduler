// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // COURSE_OFFERING
	using System.ComponentModel.DataAnnotations;
    public class CourseOffering
    {
        [Range(0, 1)]
		public decimal CourseOffered { get; set; } // COURSE_OFFERED (Primary key)
        [StringLength(50)]
		public string Descriptions { get; set; } // DESCRIPTIONS

        // Reverse navigation
        public virtual ICollection<Course> Courses { get; set; } // COURSE.COURSE_OFFERED_FK

        public CourseOffering()
        {
            Courses = new List<Course>();
        }
    }

}
