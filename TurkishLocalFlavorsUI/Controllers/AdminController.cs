using Microsoft.AspNetCore.Mvc;

namespace TurkishLocalFlavorsUI.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
