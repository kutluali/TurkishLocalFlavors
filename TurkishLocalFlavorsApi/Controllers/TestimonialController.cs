using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurkishLocalFlavors.Business.Abstract;
using TurkishLocalFlavors.Dto.TestimonialDto;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestoimonialService _testoimonialService;
        private readonly IMapper _mapper;
        public TestimonialController(ITestoimonialService testoimonialService, IMapper mapper)
        {
            _testoimonialService = testoimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testoimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var values=_mapper.Map<Testimonial>(createTestimonialDto);
            _testoimonialService.TAdd(values);
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testoimonialService.TGetByID(id);
            _testoimonialService.TDelete(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testoimonialService.TGetByID(id);
            return Ok(_mapper.Map<GetTestimonialDto>(value));
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var values = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testoimonialService.TUpdate(values);
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }
    }
}
