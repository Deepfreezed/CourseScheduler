// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // COURSE_OPTION_CLUSTER_SUB_PROG
	using System.ComponentModel.DataAnnotations;
    public class CourseOptionClusterSubProg
    {
        [StringLength(20)]
		public string OptionId { get; set; } // OPTION_ID (Primary key)
        [StringLength(20)]
		public string ClusterId { get; set; } // CLUSTER_ID (Primary key)
        [StringLength(20)]
		public string SubProgId { get; set; } // SUB_PROG_ID (Primary key)
        [StringLength(10)]
		public string ProgNum { get; set; } // PROG_NUM (Primary key)
        [StringLength(20)]
		public string CourseNum { get; set; } // COURSE_NUM (Primary key)
        [StringLength(10)]
		public string MinGrade { get; set; } // MIN_GRADE

        // Foreign keys
        public virtual Course Course { get; set; } // COURSE_OPTION_CLUSTER_SUB_FK2
        public virtual OptionalClusterSubProgram OptionalClusterSubProgram { get; set; } // COURSE_OPTION_CLUSTER_SUB_FK1
    }

}
