// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // SUB_PROGRAM
	using System.ComponentModel.DataAnnotations;
    public class SubProgram
    {
        [StringLength(10)]
		public string ProgNum { get; set; } // PROG_NUM (Primary key)
        [StringLength(20)]
		public string SubProgId { get; set; } // SUB_PROG_ID (Primary key)
        [Range(0, 10)]
		public decimal CreditHours { get; set; } // CREDIT_HOURS
        [Range(0, 1)]
		public decimal HasClusters { get; set; } // HAS_CLUSTERS

        // Reverse navigation
        public virtual ICollection<ClusterSubProgram> ClusterSubPrograms { get; set; } // Many to many mapping
        public virtual ICollection<CourseSubProgram> CourseSubPrograms { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Program Program { get; set; } // SUB_PROGRAM_FK
        public virtual SubProgramIdentifier SubProgramIdentifier { get; set; } // SUB_PROGRAM_FK2

        public SubProgram()
        {
            ClusterSubPrograms = new List<ClusterSubProgram>();
            CourseSubPrograms = new List<CourseSubProgram>();
        }
    }

}
