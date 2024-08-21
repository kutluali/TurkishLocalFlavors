using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurkishLocalFlavors.Business.Abstract;
using TurkishLocalFlavors.Dto.Booking;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok (values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail=createBookingDto.Mail,
                Date=createBookingDto.Date,
                Name=createBookingDto.Name, 
                PersonCount=createBookingDto.PersonCount,   
                Phone=createBookingDto.Phone,
                Description = createBookingDto.Description
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Alındı");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok("Rezervasyon Silindi");

        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                Description = updateBookingDto.Description
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return Ok(values);
        }

    }
}
