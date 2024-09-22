using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TurkishLocalFlavorsUI.Dtos.ProductDtos;

namespace TurkishLocalFlavorsUI.ViewComponents.HomeComponents
{
    public class _HomeIndexMenuComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeIndexMenuComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7046/api/Product/ProductListWithCategory");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<ResultProductDto>>(json); // Deserialize işlemi

                // İlk 9 ürünü al
                var limitedProducts = products.Take(9).ToList();

                return View(limitedProducts); // View'e sadece 9 ürünü gönder
            }

            return View(new List<ResultProductDto>());// Hata durumunda boş liste döndür
        }
    }
}


