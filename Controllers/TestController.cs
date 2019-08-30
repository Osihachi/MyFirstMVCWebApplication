using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstWebApp.ViewModel;

namespace MyFirstWebApp.Controllers
{
    public class TestController : Controller
    {
		private BAProject1Entities1 db = new BAProject1Entities1();
        // GET: Test
        public ActionResult Index()
        {
			var user = db.UserSignUps.ToList();
			List<UserSignUp> list = db.UserSignUps.ToList();

			ViewBag.Namelist = list;
			return View();
        }
		public ActionResult Register()
		{
			// create an instance of the register view model class 
			RegisterViewModel userState = new RegisterViewModel();

			// retrieves the rows of states in the state table of the detabase and converts it to a list..
			
		List<StateOfOrigination> newstates = db.StateOfOriginations.ToList();

			// gets the list value from the state table and pass it to the view model for the register view...
			userState.states = newstates;
			
			return View(userState);
		}

		[HttpPost]
		public ActionResult Register(RegisterViewModel userSignUp)
		{
			RegisterViewModel userState = new RegisterViewModel();
			if (ModelState.IsValid)
			{
				
				try
				{
					//RegisterViewModel userState = new RegisterViewModel();
					List<StateOfOrigination> newstates = db.StateOfOriginations.ToList();

					// gets the list value from the state table and pass it to the view model for the register view...
					userState.states = newstates;
					UserSignUp newUserData = new UserSignUp
					{
						Firstname = userSignUp.Firstname,
						Surname = userSignUp.Surname,
						Email = userSignUp.Email,
						DateOfBirth = userSignUp.DateOfBirth,
						State_id = userSignUp.State_id,
						PhoneNumber = userSignUp.PhoneNumber,
						Password = userSignUp.Password
					};
					db.UserSignUps.Add(newUserData);
					db.SaveChanges();
					ViewBag.Result = "Saved Successfully";

				}catch(Exception e)
				{
					ViewBag.Result = e.Message;

				}
			}
			else
			{
				ModelState.AddModelError("", "Invalid Entry");
			}

			return View(userState);
		}
	}
}