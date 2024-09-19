using Microsoft.AspNetCore.Mvc;

namespace TurkishLocalFlavorsUI.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFound404Page()
        {
            return View();
        }
    }
}
