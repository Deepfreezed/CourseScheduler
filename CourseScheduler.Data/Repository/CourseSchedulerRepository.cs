using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseScheduler.Data.Context;
using CourseScheduler.Data.Entities;

namespace CourseScheduler.Data.Repository
{
	public class CourseSchedulerRepository : ICourseSchedulerRepository
	{
		CourseSchedulerContext _ctx;

		#region ICourseSchedulerRepository Members

		public CourseSchedulerRepository(CourseSchedulerContext ctx)
		{
			_ctx = ctx;

			//Turn off lazy loading if you are going to serialize objects
			_ctx.Configuration.LazyLoadingEnabled = false;

			//causes issues with serialization
			_ctx.Configuration.ProxyCreationEnabled = false;			
		}

		/// <summary>
		/// Gets the departments.
		/// </summary>
		/// <returns></returns>
		public IQueryable<Department> GetDepartments()
		{
			return _ctx.Departments;
		}

		/// <summary>
		/// Gets the courses.
		/// </summary>
		/// <returns></returns>
		public IQueryable<Course> GetCourses()
		{
			return _ctx.Courses;
		}

		/// <summary>
		/// Gets the courses by department.
		/// </summary>
		/// <param name="departmentID">The department identifier.</param>
		/// <returns></returns>
		public IQueryable<Course> GetCoursesByDepartment(string departmentID)
		{
			return _ctx.Courses.Where(r => r.DeptNum == departmentID);
		}

		#endregion
	}
}
