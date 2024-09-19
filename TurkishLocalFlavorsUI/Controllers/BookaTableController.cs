using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TurkishLocalFlavorsUI.Dtos.BookingDtos;

namespace TurkishLocalFlavorsUI.Controllers
{
    [AllowAnonymous]
    public class BookaTableController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookaTableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
