using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace CourseScheduler.Data
{
	public class CourseSchedulerContext : DbContext
	{
		public CourseSchedulerContext()
			: base("DatabaseConnection")
		{
			#region Migration

			////Turn off lazy loading if you are going to serialize objects
			//this.Configuration.LazyLoadingEnabled = false;

			////causes issues with serialization
			//this.Configuration.ProxyCreationEnabled = false;

			//Database.SetInitializer(
			//	new MigrateDatabaseToLatestVersion<CourseSchedulerContext, CourseSchedulerMigrationsConfiguration>()
			//);

			#endregion
		}

		public DbSet<Department> Departments { get; set; }
		public DbSet<Course> Courses { get; set; }
	}
}
