using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TurkishLocalFlavorsUI.Dtos.SliderDtos;
using TurkishLocalFlavorsUI.Dtos.TestimonialDtos;

namespace TurkishLocalFlavorsUI.ViewComponents.HomeComponents
{
    public class _HomeTestimonialComponentPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Testimonial");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
            return View(values);

        }
    }
}
