using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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
		public IQueryable<Course> GetCoursesByDepartment(string departmentId)
		{
			return _ctx.Courses.Where(r => r.DeptNum == departmentId);
		}		

		/// <summary>
		/// Gets the courses by program.
		/// </summary>
		/// <param name="programId">The program identifier.</param>
		/// <returns></returns>
		public IQueryable<Course> GetCoursesByProgram(string programId)
		{
			return from csp in _ctx.CourseSubPrograms
				   where csp.ProgNum == programId
				   select csp.Course;
			
		}

		/// <summary>
		/// Saves this instance.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public bool Save()
		{
			try
			{
				return _ctx.SaveChanges() > 0;
			}
			catch(Exception)
			{
				//TODO Log error
				return false;
			}
		}

		/// <summary>
		/// Adds the course.
		/// </summary>
		/// <param name="newCourse">The new course.</param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public bool AddCourse(Course newCourse)
		{
			try
			{
				_ctx.Courses.Add(newCourse);

				return true;
			}
			catch(Exception)
			{
				//TODO Log error
				return false;
			}
		}
		
		/// <summary>
		/// Gets the programs.
		/// </summary>
		/// <returns></returns>
		public IQueryable<Program> GetPrograms()
		{
			return _ctx.Programs;
		}


		public bool AddProgram(Program newProgram)
		{
			try
			{
				_ctx.Programs.Add(newProgram);

				return true;
			}
			catch(Exception)
			{
				//TODO Log error
				return false;
			}
		}


		public IQueryable<Program> GetProgramsIncludeDepartments()
		{
			return _ctx.Programs
				//.Include(p => p.SubPrograms)
				.Include(p => p.Department);
		}
	}
}
