using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace CourseScheduler.Data
{
	public class CourseSchedulerMigrationsConfiguration : DbMigrationsConfiguration<CourseSchedulerContext>
	{
		public CourseSchedulerMigrationsConfiguration()
		{
			this.AutomaticMigrationDataLossAllowed = true;
			this.AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(CourseSchedulerContext context)
		{
			base.Seed(context);

#if DEBUG
			if (context.Courses.Count() == 0)
			{
				var course = new Course()
				{
					Name = "test Course",
					CreditHrs = 4
				};

				context.Courses.Add(course);

				try
				{
					context.SaveChanges();
				}
				catch(Exception ex)
				{
					var msg = ex.Message;
				}
			}
#endif
		}
	}
}
