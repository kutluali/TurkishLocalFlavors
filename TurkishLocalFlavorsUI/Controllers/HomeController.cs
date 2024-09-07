using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TurkishLocalFlavorsUI.Models;

namespace TurkishLocalFlavorsUI.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

	}
}
