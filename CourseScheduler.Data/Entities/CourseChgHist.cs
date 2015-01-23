// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // COURSE_CHG_HIST
	using System.ComponentModel.DataAnnotations;
    public class CourseChgHist
    {
        [StringLength(20)]
		public string ChgType { get; set; } // CHG_TYPE
        [Range(0, 0)]
		public DateTime DateChanged { get; set; } // DATE_CHANGED (Primary key)
        [StringLength(20)]
		public string CourseNum { get; set; } // COURSE_NUM (Primary key)
        [StringLength(50)]
		public string ChangeFrom { get; set; } // CHANGE_FROM
        [StringLength(20)]
		public string ChangeTo { get; set; } // CHANGE_TO

        // Foreign keys
        public virtual Course Course { get; set; } // COURSE_CHG_HIST_FK
    }

}
