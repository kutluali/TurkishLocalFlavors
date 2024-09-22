using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using TurkishLocalFlavorsUI.Dtos.BookingDtos;

namespace TurkishLocalFlavorsUI.ViewComponents.HomeComponents
{
    public class _HomeBookaTableComponentPartial : ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public _HomeBookaTableComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.GetAsync("https://localhost:7046/api/Contact");
			response.EnsureSuccessStatusCode();
			string responseBody = await response.Content.ReadAsStringAsync();
			JArray item = JArray.Parse(responseBody);
			string value = item[0]["location"].ToString();
			ViewBag.location = value;
			return View();
		}
    }
}
