using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CourseScheduler.Data;
using CourseScheduler.Data.Entities;

namespace CourseScheduler.Website.Controllers
{
    public class CourseController : ApiController
    {
		private ICourseSchedulerRepository _repo;

		public CourseController(ICourseSchedulerRepository repo)
		{
			_repo = repo;
		}

		/// <summary>
		/// Gets courses.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Course> Get()
		{
			return _repo.GetCourses()
				.OrderBy(c => c.CourseNum);
		}

		/// <summary>
		/// Save a new Course.
		/// </summary>
		/// <param name="departmentId">The department identifier.</param>
		/// <param name="newCourse">The new course.</param>
		/// <returns></returns>
		public HttpResponseMessage Post(string departmentId, [FromBody]Course newCourse)
		{
			newCourse.DeptNum = departmentId;

			if(_repo.AddCourse(newCourse) && _repo.Save())
			{
				return Request.CreateResponse(HttpStatusCode.Created, newCourse);
			}

			return Request.CreateResponse(HttpStatusCode.BadRequest);
		}
    }
}
