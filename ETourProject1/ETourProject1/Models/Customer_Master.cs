using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ETourProject1.Models
{
    public class Customer_Master
    {

        [Required]
        public int CustId { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public String Gender { get; set; }

        [Required]
        public int CountryCode { get; set; }

        [Required]
            [RegularExpression("^[0-9]{10}$", ErrorMessage = "Number format is incorrect")]
        private long MobileNumber { get; set; }

        [Required]
        private String Address { get; set; }

        [Required(ErrorMessage = "Email Required")]
        public String Email { get; set; }

       
        [Required(ErrorMessage = "Adhar Required")]
        private long AdharNumber { get; set; }

        [Required]
        public String UserName { get; set; }

        [Required]
        public String PassWord { get; set; }


      //  public ICollection<BookingHeader> bookingHeaders { get; set; }
    }
}
