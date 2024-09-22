using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TurkishLocalFlavorsUI.Dtos.ProductDtos;

namespace TurkishLocalFlavorsUI.ViewComponents.HomeComponents
{
    public class _HomeMenuComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeMenuComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Product/ProductListWithCategory");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);

        }
    }
}
