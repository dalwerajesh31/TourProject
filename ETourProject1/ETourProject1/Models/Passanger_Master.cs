using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETourProject1.Models
{
    public class Passanger_Master
    {
        [Key]
        public int PassangerId { get; set; }

        public String PassangerName { get; set; }

        public DateTime BirthDate { get; set; }

        public String PassangerType { get; set; }

        public int PassangerAmount { get; set; }

        [ForeignKey("bookingId")]

        public BookingHeader BooKingHeader { get; set; }

    }
}