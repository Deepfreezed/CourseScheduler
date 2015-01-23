// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // SUB_PROGRAM_IDENTIFIER
	using System.ComponentModel.DataAnnotations;
    public class SubProgramIdentifier
    {
        [StringLength(20)]
		public string SubProgId { get; set; } // SUB_PROG_ID (Primary key)
        [StringLength(50)]
		public string Name { get; set; } // NAME
        [StringLength(100)]
		public string CommonName { get; set; } // COMMON_NAME

        // Reverse navigation
        public virtual ICollection<SubProgram> SubPrograms { get; set; } // Many to many mapping

        public SubProgramIdentifier()
        {
            SubPrograms = new List<SubProgram>();
        }
    }

}
