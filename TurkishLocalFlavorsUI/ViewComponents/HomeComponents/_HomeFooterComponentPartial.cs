using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TurkishLocalFlavorsUI.Dtos.ContactDtos;
using TurkishLocalFlavorsUI.Dtos.SocialMediaDtos;
using TurkishLocalFlavorsUI.Models;

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

                // Contact API çağrısı
                var contactResponse = await client.GetAsync("https://localhost:7046/api/Contact");
                var contactJsonData = await contactResponse.Content.ReadAsStringAsync();
                var contactValues = JsonConvert.DeserializeObject<List<ResultContactDto>>(contactJsonData);

                // Social Media API çağrısı
                var socialMediaResponse = await client.GetAsync("https://localhost:7046/api/SocialMedia");
                var socialMediaJsonData = await socialMediaResponse.Content.ReadAsStringAsync();
                var socialMediaValues = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(socialMediaJsonData);

                // View'e hem contact hem de sosyal medya bilgilerini gönder
                var viewModel = new FooterViewModel
                {
                    ContactValues = contactValues,
                    SocialMediaValues = socialMediaValues
                };

                return View(viewModel);
            }
        }

}
