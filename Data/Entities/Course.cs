using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversidadDeOriente.Data.Entities
{
	public class Course
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int CourseID { get; set; }
		public String Title { get; set; }
		public int Credits { get; set; }
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
