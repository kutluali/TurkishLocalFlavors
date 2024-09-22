using Microsoft.AspNetCore.Mvc;

namespace TurkishLocalFlavorsUI.Controllers
{
    public class AboutUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
