using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Repository
{
    public interface IBookingHeaderRepository
    {
        Task<ActionResult<IEnumerable<BookingHeader>>> GetAllBookings();
        Task<ActionResult<BookingHeader>?> GetBooking(int Id);
        Task<ActionResult<BookingHeader>> Add(BookingHeader booking);
       
    }
}
