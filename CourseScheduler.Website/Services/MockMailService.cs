using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CourseScheduler.Website.Services
{
	public class MockMailService : IMailService
	{
		#region IMailService Members

		public bool SendMail(string from, string to, string subject, string body)
		{
			var msg = string.Format("Email From: {1}{0}To:{2}{0}Subject:{3}{0}Message:{4}{0}",
				Environment.NewLine, from, to, subject, body);

			Debug.WriteLine(msg);
			return true;
		}

		#endregion
	}
}