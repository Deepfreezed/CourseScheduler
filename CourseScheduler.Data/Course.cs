using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseScheduler.Data
{
	public class Course
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int CreditHrs { get; set; }

		public string DepartmentId { get; set; }
	}
}
