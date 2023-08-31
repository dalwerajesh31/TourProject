using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class BookingHeaderRepository : IBookingHeaderRepository
    {
        private readonly Appdbcontext context;

        public BookingHeaderRepository(Appdbcontext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<BookingHeader>> Add(BookingHeader booking)
        {
            context.Bookings.Add(booking);
            await context.SaveChangesAsync();
            return booking;
        }

       
        public async Task<ActionResult<IEnumerable<BookingHeader>>> GetAllBookings()
        {
            if (context.Bookings == null)
                return null;

            return await context.Bookings.ToListAsync();
        }

        public async Task<ActionResult<BookingHeader>?> GetBooking(int Id)
        {
            if (context.Bookings == null)
                return null;
            BookingHeader booking = await context.Bookings.FindAsync(Id);

            if(booking == null)
                return null;
            return booking;
        }

        public bool BookingExists(int id)
        {
            return (context.Bookings?.Any(e => e.bookingId == id)).GetValueOrDefault();
        }
    }
}
