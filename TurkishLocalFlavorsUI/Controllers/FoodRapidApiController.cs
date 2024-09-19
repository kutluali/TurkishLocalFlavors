using Microsoft.AspNetCore.Mvc;

namespace TurkishLocalFlavorsUI.Controllers
{
    public class FoodRapidApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
