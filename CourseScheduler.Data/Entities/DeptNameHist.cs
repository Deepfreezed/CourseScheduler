// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // DEPT_NAME_HIST
	using System.ComponentModel.DataAnnotations;
    public class DeptNameHist
    {
        [Range(0, 0)]
		public DateTime DateChanged { get; set; } // DATE_CHANGED (Primary key)
        [StringLength(10)]
		public string DeptNum { get; set; } // DEPT_NUM (Primary key)
        [StringLength(50)]
		public string Name { get; set; } // NAME

        // Foreign keys
        public virtual Department Department { get; set; } // DEPT_NAME_HIST_FK
    }

}
