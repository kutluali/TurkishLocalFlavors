using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TurkishLocalFlavorsUI.Dtos.BookingDtos;

namespace TurkishLocalFlavorsUI.ViewComponents.HomeComponents
{
    public class _HomeBookaTableComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //private readonly IHttpClientFactory _httpClientFactory;

        //public _HomeBookaTableComponentPartial(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var response = await client.GetAsync("https://localhost:7046/api/Booking");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var json = await response.Content.ReadAsStringAsync();
        //        var bookings = JsonConvert.DeserializeObject<List<CreateBookingDto>>(json);
        //        return View(bookings);
        //    }

        //    return View(new List<CreateBookingDto>());
        //}

    }
}
