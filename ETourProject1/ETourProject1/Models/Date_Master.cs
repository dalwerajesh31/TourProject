using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ETourProject1.Models
{
    public class Date_Master
    {
        [Key]
        public int DepartureId { get; set; }
        public DateTime DepartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDays { get; set; }
        public int pkgId { get; set; }
        public ICollection<BookingHeader> BookingHeaders { get; set; }
    }
}
