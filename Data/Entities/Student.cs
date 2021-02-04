using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversidadDeOriente.Data.Entities
{
	public class Student
	{
		public int ID { get; set; }
		[Display(Name = "Apellidos")]
		public String LastName { get; set; }
		[Display(Name = "Primer Nombre")]
		public String FirtsMidName { get; set; }
		[Display(Name = "Enrollment Date")]
		public DateTime EnrollmentDate { get; set; }
		[Display(Name = "Nombre Completo")]

		public String FullName
		{
			get
			{
				return FirtsMidName + " " + LastName;
			}
		}
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
