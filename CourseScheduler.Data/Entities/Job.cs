// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // JOB
	using System.ComponentModel.DataAnnotations;
    public class Job
    {
        [StringLength(10)]
		public string Jno { get; set; } // JNO (Primary key)
        [StringLength(100)]
		public string JobName { get; set; } // JOB_NAME
        [StringLength(200)]
		public string JobDesc { get; set; } // JOB_DESC
    }

}
