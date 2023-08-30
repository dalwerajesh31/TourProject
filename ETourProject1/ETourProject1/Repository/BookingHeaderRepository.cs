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

        public async Task<BookingHeader> Delete(int Id)
        {
            BookingHeader booking = context.Bookings.Find(Id);

            if (booking != null)
            {
                context.Bookings.Remove(booking);
                await context.SaveChangesAsync();
            }

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

        public async Task<BookingHeader> Update(int id, BookingHeader bookingchanges)
        {
            if (id != bookingchanges.bookingId)
                return null;

            context.Entry(bookingchanges).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!BookingExists(id))
                    return null;
                else
                    throw;
            }

            return null;
        }

        public bool BookingExists(int id)
        {
            return (context.Bookings?.Any(e => e.bookingId == id)).GetValueOrDefault();
        }
    }
}
