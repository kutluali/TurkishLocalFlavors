using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TurkishLocalFlavorsUI.Dtos.BookingDtos;

namespace TurkishLocalFlavorsUI.Controllers
{
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

        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingDto createBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7046/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
