using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using TurkishLocalFlavorsUI.Dtos.BasketDtos;
using TurkishLocalFlavorsUI.Dtos.ProductDtos;

namespace TurkishLocalFlavorsUI.Controllers
{
    public class BasketsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public BasketsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Basket/BasketListByMenuTableWithProductName?id=4");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> DeleteBasket(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7046/api/Basket/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return NoContent();
        }

        //[HttpPost]
        //public IActionResult UpdateQuantity(int basketId, int count)
        //{
        //    var basketItem = _context.BasketItems.FirstOrDefault(b => b.BasketID == basketId);
        //    if (basketItem != null)
        //    {
        //        basketItem.Count = count;
        //        _context.SaveChanges();
        //    }
        //    return Ok();
        //}

        //[HttpGet]
        //public async Task<IActionResult> UpdateProduct(int id)
        //{

        //    var client1 = _httpClientFactory.CreateClient();
        //    var responseMessage1 = await client1.GetAsync("https://localhost:7046/api/Category");
        //    var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
        //    var values1 = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData1);
        //    List<SelectListItem> values2 = (from x in values1
        //                                    select new SelectListItem
        //                                    {
        //                                        Text = x.CategoryName,
        //                                        Value = x.CategoryID.ToString()
        //                                    }).ToList();
        //    ViewBag.v = values2;


        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"https://localhost:7046/api/Product/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}


    }
}
