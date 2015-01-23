// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CourseScheduler.Data.Entities
{
    // GEN_ED_COURSE
	using System.ComponentModel.DataAnnotations;
    public class GenEdCourse
    {
        [StringLength(20)]
		public string CourseNum { get; set; } // COURSE_NUM (Primary key)
        [StringLength(5)]
		public string GoalAreaId { get; set; } // GOAL_AREA_ID (Primary key)
        [StringLength(1)]
		public string Laboratory { get; set; } // LABORATORY
        [StringLength(1)]
		public string GoldCulturDiver { get; set; } // GOLD_CULTUR_DIVER
        [StringLength(1)]
		public string PurpleCulturDiver { get; set; } // PURPLE_CULTUR_DIVER
        [StringLength(20)]
		public string CatalogYear { get; set; } // CATALOG_YEAR (Primary key)

        // Foreign keys
        public virtual Course Course { get; set; } // GEN_ED_COUR_FK
        public virtual GoalArea GoalArea { get; set; } // GEN_ED_FK2
    }

}
