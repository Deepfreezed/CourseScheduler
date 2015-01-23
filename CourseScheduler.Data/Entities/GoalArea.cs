// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // GOAL_AREA
	using System.ComponentModel.DataAnnotations;
    public class GoalArea
    {
        [StringLength(5)]
		public string GoalAreaId { get; set; } // GOAL_AREA_ID (Primary key)
        [StringLength(50)]
		public string GoalAreaName { get; set; } // GOAL_AREA_NAME
        [Range(0, 2)]
		public decimal? MaxCreditHoursReq { get; set; } // MAX_CREDIT_HOURS_REQ
        [Range(0, 2)]
		public decimal? MinCreditHoursReq { get; set; } // MIN_CREDIT_HOURS_REQ
        [StringLength(2000)]
		public string SpecialNotes { get; set; } // SPECIAL_NOTES

        // Reverse navigation
        public virtual ICollection<GenEdCourse> GenEdCourses { get; set; } // Many to many mapping

        public GoalArea()
        {
            GenEdCourses = new List<GenEdCourse>();
        }
    }

}
