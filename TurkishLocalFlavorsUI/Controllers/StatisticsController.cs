using Microsoft.AspNetCore.Mvc;

namespace TurkishLocalFlavorsUI.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
