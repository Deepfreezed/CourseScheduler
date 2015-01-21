using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseScheduler.Data
{
	public interface ICourseSchedulerRepository
	{
		IQueryable<Department> GetDepartments();
		IQueryable<Course> GetCourses();
		IQueryable<Course> GetCoursesByDepartment(string departmentID);
	}
}
