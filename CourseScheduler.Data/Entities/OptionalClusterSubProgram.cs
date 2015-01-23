// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // OPTIONAL_CLUSTER_SUB_PROGRAM
	using System.ComponentModel.DataAnnotations;
    public class OptionalClusterSubProgram
    {
        [StringLength(20)]
		public string OptionId { get; set; } // OPTION_ID (Primary key)
        [StringLength(20)]
		public string ClusterId { get; set; } // CLUSTER_ID (Primary key)
        [StringLength(20)]
		public string SubProgId { get; set; } // SUB_PROG_ID (Primary key)
        [StringLength(10)]
		public string ProgNum { get; set; } // PROG_NUM (Primary key)
        [StringLength(100)]
		public string Name { get; set; } // NAME
        [Range(0, 10)]
		public decimal CreditHours { get; set; } // CREDIT_HOURS

        // Reverse navigation
        public virtual ICollection<CourseOptionClusterSubProg> CourseOptionClusterSubProgs { get; set; } // Many to many mapping

        // Foreign keys
        public virtual ClusterSubProgram ClusterSubProgram { get; set; } // OPTIONAL_CLUSTER_SUB_PROG_FK1

        public OptionalClusterSubProgram()
        {
            CourseOptionClusterSubProgs = new List<CourseOptionClusterSubProg>();
        }
    }

}
