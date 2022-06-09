using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoRentDemoApp.Models
{
	public class Renter
	{
		public int RenterId { get; set; }
		
		[Display(Name ="First Name")]
		[MaxLength(30)]
		[Required]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		[MaxLength(30)]
		[Required]
		public string LastName { get; set; }
		[BindProperty, DataType(DataType.Date)]
		[Display(Name = "Rented Date")]
		public DateTime RentedDate { get; set; }

		public virtual ICollection<Movie> Movies { get; set; }

		//private int _movieId;
		//public int MovieId
		//{
		//	get
		//	{
		//		return _movieId;
		//	}
		//}
	}
}
