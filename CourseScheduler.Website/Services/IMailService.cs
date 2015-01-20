using System;
namespace CourseScheduler.Website.Services
{
	public interface IMailService
	{
		bool SendMail(string from, string to, string subject, string body);
	}
}
