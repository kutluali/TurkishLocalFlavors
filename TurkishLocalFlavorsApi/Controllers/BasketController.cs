using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http;
using TurkishLocalFlavors.Business.Abstract;
using TurkishLocalFlavors.DataAccess.Concrete;
using TurkishLocalFlavors.Dto.BasketDto;
using TurkishLocalFlavors.Entity.Entities;
using TurkishLocalFlavorsApi.Models;

namespace TurkishLocalFlavorsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public ActionResult GetBasketByMenuTableID(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }
        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new FlavorsContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new ResultBasketListWithProducts
            {
                BasketID = z.BasketID,
                Count = z.Count,
                MenuTableID = z.MenuTableID,
                Price = z.Price,
                ProductID = z.ProductID,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName
            }).ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createbasketDto)
        {
            using var context =new FlavorsContext();
            _basketService.TAdd(new Basket()
            {
                Count = 1,
                ProductID = createbasketDto.ProductID,
                MenuTableID = createbasketDto.MenuTableID,
                Price = context.Products.Where(x => x.ProductID == createbasketDto.ProductID).Select(y =>y.Price).FirstOrDefault(),
                TotalPrice=0,
            });
            return Ok(createbasketDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values = _basketService.TGetByID(id);
            _basketService.TDelete(values);
            return Ok("Ürün Silindi");
        }
    }
}

