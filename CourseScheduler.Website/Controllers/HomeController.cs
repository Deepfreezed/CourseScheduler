using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseScheduler.Data;
using CourseScheduler.Website.Models;
using CourseScheduler.Website.Services;

namespace CourseScheduler.Website.Controllers
{
	//[RequireHttps]
	public class HomeController : Controller
	{
		private IMailService _mail;
		private ICourseSchedulerRepository _repo;

		public HomeController(IMailService mail, ICourseSchedulerRepository repo)
		{
			_mail = mail;
			_repo = repo;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		/// <summary>
		/// Contacts page.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		[HttpPost]
		public ActionResult Contact(ContactModel model)
		{
			var msg = string.Format("Comment From: {1}{0}Email:{2}{0}Website:{3}{0}Comment:{4}{0}",
				Environment.NewLine,model.Name, model.Email, model.Website, model.Comment);

			if(_mail.SendMail("noreply@yourdomain.com", "foo@yourdomain.com", "Website Contact", msg))
			{
				ViewBag.MailSent = true;
			}

			return View();
		}

		//[Authorize]
		public ActionResult CourseListing()
		{
			var courses = _repo.GetCourses()
				.OrderByDescending(c => c.Id)
				.Take(25)
				.ToList();

			return View(courses);
		}

		[Authorize(Roles="Admin")]
		public ActionResult Admin()
		{
			return View();
		}
	}
}