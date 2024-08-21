using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurkishLocalFlavors.Business.Abstract;
using TurkishLocalFlavors.Dto.Discount;
using TurkishLocalFlavors.Dto.DiscountDto;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                ImageUrl = createDiscountDto.ImageUrl,  
                Status = createDiscountDto.Status,  
                Title = createDiscountDto.Title

            });
            return Ok("İndirimli Ürün Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var values = _discountService.TGetByID(id);
            _discountService.TDelete(values);
            return Ok("İndirimli Ürün Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var values = _discountService.TGetByID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Amount=updateDiscountDto.Amount,
                Description=updateDiscountDto.Description,
                ImageUrl = updateDiscountDto.ImageUrl,
                Title = updateDiscountDto.Title,
                Status = updateDiscountDto.Status,  
                DiscountID = updateDiscountDto.DiscountID
            });
            return Ok("İndirimli Ürün Güncellendi");
        }
    }
}
