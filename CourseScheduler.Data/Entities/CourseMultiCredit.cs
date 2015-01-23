// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // COURSE_MULTI_CREDIT
	using System.ComponentModel.DataAnnotations;
    public class CourseMultiCredit
    {
        [Range(0, 3)]
		public decimal MaxCh { get; set; } // MAX_CH (Primary key)
        [Range(0, 3)]
		public decimal MinCh { get; set; } // MIN_CH (Primary key)
        [StringLength(20)]
		public string CourseNum { get; set; } // COURSE_NUM (Primary key)

        // Foreign keys
        public virtual Course Course { get; set; } // COURSE_MULTI_CRD_FK
    }

}
