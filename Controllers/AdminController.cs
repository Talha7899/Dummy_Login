using Microsoft.AspNetCore.Mvc;

namespace Dummy_Login_System.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Login(string email, string password)
		{
			if(email == "admin@gmail.com" && password == "12345")
			{
				return RedirectToAction("Index");
			}else if (email == "user@gmail.com" && password == "12345")
			{
				return RedirectToAction("Index","Home");
			}
			else
			{
				ViewData["Message"] = "Invalid Email Or Password";
				return View();
			}
		}

	}
}
