using ETourProject1.Models;
using ETourProject1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingHeaderController : ControllerBase
    {
        private readonly IBookingHeaderRepository _repository;

        public BookingHeaderController(IBookingHeaderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingHeader>?>> GetBookings()
        {
            if (await _repository.GetAllBookings() == null)
                return NotFound();
            return await _repository.GetAllBookings();
        }

        [HttpGet("id")]
        public async Task<ActionResult<BookingHeader>?> GetBookingById(int id)
        {
            var booking = await _repository.GetBooking(id);
            return booking == null ? NotFound() : booking;
        }

        [HttpPost]
        public async Task<ActionResult<BookingHeader>> PostEmployee(BookingHeader booking)
        {
            await _repository.Add(booking);

            return CreatedAtAction("PostEmployee", new { id = booking.bookingId }, booking);
        }
        [ForeignKey(name: "DepartureId")]
        public int DepartureId { get; set; }

      //  public ICollection<Passanger_master> passanger_Masters { get; set; }

    }
}
