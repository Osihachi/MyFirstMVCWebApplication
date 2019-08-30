using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.ViewModel
{
	public class RegisterViewModel
	{
		public IEnumerable<StateOfOrigination> states { get; set; }
		public int id { get; set; }
		public string Firstname { get; set; }
		public string Surname { get; set; }
		public Nullable<System.DateTime> DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public int State_id { get; set; }
	}
}