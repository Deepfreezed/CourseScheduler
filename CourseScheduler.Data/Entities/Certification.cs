// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // CERTIFICATION
	using System.ComponentModel.DataAnnotations;
    public class Certification
    {
        [StringLength(10)]
		public string Certid { get; set; } // CERTID (Primary key)
        [StringLength(20)]
		public string Category { get; set; } // CATEGORY
        [StringLength(200)]
		public string Certification_ { get; set; } // CERTIFICATION
        [StringLength(200)]
		public string Description { get; set; } // DESCRIPTION
    }

}
