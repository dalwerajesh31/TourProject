using System.ComponentModel.DataAnnotations;

namespace ETourProject1.Models
{
    public class BookingHeader
    {
        [Key]
        public int bookingId { get; set; }
        public DateTime bookingDate { get; set; }
        public int numberOfPassengers { get; set; }
        public int tourAmount { get; set; }
        public int taxes { get; set; }
        public int totalAmount { get; set; }
        public int packageId { get; set; }
        public int departureId { get; set; }
        public int customerId { get; set; }

      /*  public ICollection<PassangerMaster>? passengerMaster { get; set; }*/
    }
}
