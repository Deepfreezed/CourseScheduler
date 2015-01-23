// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // COMPANY
	using System.ComponentModel.DataAnnotations;
    public class Company
    {
        [StringLength(10)]
		public string CompId { get; set; } // COMP_ID (Primary key)
        [StringLength(50)]
		public string CompName { get; set; } // COMP_NAME
    }

}
