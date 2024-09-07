using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurkishLocalFlavors.Business.Abstract;

namespace TurkishLocalFlavorsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet]
        public IActionResult SliderList()
        {
            return Ok(_sliderService.TGetListAll());
        }
    }
}
