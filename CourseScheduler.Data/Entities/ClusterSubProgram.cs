// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // CLUSTER_SUB_PROGRAM
	using System.ComponentModel.DataAnnotations;
    public class ClusterSubProgram
    {
        [StringLength(20)]
		public string ClusterId { get; set; } // CLUSTER_ID (Primary key)
        [StringLength(20)]
		public string SubProgId { get; set; } // SUB_PROG_ID (Primary key)
        [StringLength(10)]
		public string ProgNum { get; set; } // PROG_NUM (Primary key)
        [Range(0, 10)]
		public decimal CreditHours { get; set; } // CREDIT_HOURS
        [StringLength(100)]
		public string Name { get; set; } // NAME
        [Range(0, 18)]
		public decimal? HasOptions { get; set; } // HAS_OPTIONS

        // Reverse navigation
        public virtual ICollection<CourseClusterSubProgram> CourseClusterSubPrograms { get; set; } // Many to many mapping
        public virtual ICollection<OptionalClusterSubProgram> OptionalClusterSubPrograms { get; set; } // Many to many mapping

        // Foreign keys
        public virtual SubProgram SubProgram { get; set; } // CLUSTER_SUB_PROGRAM_SUB_P_FK1

        public ClusterSubProgram()
        {
            CourseClusterSubPrograms = new List<CourseClusterSubProgram>();
            OptionalClusterSubPrograms = new List<OptionalClusterSubProgram>();
        }
    }

}
