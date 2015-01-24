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
		public IEnumerable<Program> Get()
		{
			return _repo.GetPrograms()
				//.Include(p => p.SubPrograms)
				.Include(p => p.Department)
				.OrderBy(p => p.ProgNum)
				.Take(25);
		}

		/// <summary>
		/// Gets Program.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Course> Get(string id)
		{
			return _repo.GetCoursesByProgram(id);
		}		
    }
}
