// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // PROG_NAME_HIST
	using System.ComponentModel.DataAnnotations;
    public class ProgNameHist
    {
        [Range(0, 0)]
		public DateTime DateChanged { get; set; } // DATE_CHANGED (Primary key)
        [StringLength(10)]
		public string ProgNum { get; set; } // PROG_NUM (Primary key)
        [StringLength(50)]
		public string Name { get; set; } // NAME
    }

}
