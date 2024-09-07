using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TurkishLocalFlavorsUI.Dtos.ContactDtos;

namespace TurkishLocalFlavorsUI.ViewComponents.HomeComponents
{

    public class _HomeFooterComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeFooterComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Contact");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
            return View(values);

        }
    }
}
