// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // PROGRAM
	using System.ComponentModel.DataAnnotations;
    public class Program
    {
        [StringLength(10)]
		public string ProgNum { get; set; } // PROG_NUM (Primary key)
        [StringLength(50)]
		public string ProgName { get; set; } // PROG_NAME
        [StringLength(10)]
		public string DeptNum { get; set; } // DEPT_NUM
        [StringLength(20)]
		public string Type { get; set; } // TYPE
        [StringLength(50)]
		public string Class { get; set; } // CLASS
        [Range(0, 10)]
		public decimal? TotalCh { get; set; } // TOTAL_CH
        [StringLength(4000)]
		public string Description { get; set; } // DESCRIPTION
        [StringLength(20)]
		public string CatalogYear { get; set; } // CATALOG_YEAR
        [StringLength(2000)]
		public string MinorRequired { get; set; } // MINOR_REQUIRED

        // Reverse navigation
        public virtual ICollection<ProgDetail> ProgDetails { get; set; } // Many to many mapping
        public virtual ICollection<SubProgram> SubPrograms { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Department Department { get; set; } // PROGRAM_DEPTNUM_FK

        public Program()
        {
            ProgDetails = new List<ProgDetail>();
            SubPrograms = new List<SubProgram>();
        }
    }

}
