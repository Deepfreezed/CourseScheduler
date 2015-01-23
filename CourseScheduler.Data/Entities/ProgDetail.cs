// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // PROG_DETAIL
	using System.ComponentModel.DataAnnotations;
    public class ProgDetail
    {
        [StringLength(10)]
		public string ProgNum { get; set; } // PROG_NUM (Primary key)
        [StringLength(11)]
		public string BulletinYear { get; set; } // BULLETIN_YEAR (Primary key)
        [Range(0, 3)]
		public decimal CoreCh { get; set; } // CORE_CH
        [Range(0, 3)]
		public decimal? SubProgCh { get; set; } // SUB_PROG_CH
        [Range(0, 3)]
		public decimal? ElectiveCh { get; set; } // ELECTIVE_CH
        [Range(0, 3)]
		public decimal? MinorCh { get; set; } // MINOR_CH
        [Range(0, 3)]
		public decimal? GenedCh { get; set; } // GENED_CH
        [Range(0, 3)]
		public decimal? ReqGenedCh { get; set; } // REQ_GENED_CH
        [Range(0, 3)]
		public decimal? OptionalCh { get; set; } // OPTIONAL_CH
        [Range(0, 3)]
		public decimal? TotalCh { get; set; } // TOTAL_CH

        // Foreign keys
        public virtual Program Program { get; set; } // PROGRAM_PROG_NUM_FK1
    }

}
