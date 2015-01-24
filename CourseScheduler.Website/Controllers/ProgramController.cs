using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CourseScheduler.Data;
using CourseScheduler.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace CourseScheduler.Website.Controllers
{
    public class ProgramController : ApiController
    {
		private ICourseSchedulerRepository _repo;

		public ProgramController(ICourseSchedulerRepository repo)
		{
			_repo = repo;
		}

		/// <summary>
		/// Gets Program.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Program> Get(bool includeDepartments = false)
		{

			if(includeDepartments)
			{
				return _repo.GetProgramsIncludeDepartments()
				.OrderBy(p => p.ProgNum)
				.Take(25);
			}
			else
			{
				return _repo.GetPrograms()
				.OrderBy(p => p.ProgNum)
				.Take(25);
			}			
		}

		/// <summary>
		/// Gets Program.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Course> Get(string id)
		{
			return _repo.GetCoursesByProgram(id);
		}

		public HttpResponseMessage Post([FromBody]Program newProgram)
		{
			if(_repo.AddProgram(newProgram) && _repo.Save())
			{
				return Request.CreateResponse(HttpStatusCode.Created, newProgram);
			}

			return Request.CreateResponse(HttpStatusCode.BadRequest);
		}
    }
}
