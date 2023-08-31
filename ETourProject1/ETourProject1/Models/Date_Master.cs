using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ETourProject1.Models
{
    public class Date_Master
    {
        [Key]
        public int DepartureId { get; set; }
        public DateTime DepartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDays { get; set; }

        [ForeignKey(name: "catMasterID")]
        public int catMasterID { get; set; }
        public int pkgId { get; set; }



        public ICollection<Booking_Header> BookingHeaders { get; set; }
        //this is for date_master

        [ForeignKey(name: "DepartureId")]
        public int DepartureId { get; set; }
        //this is for booking_header

       


        public ICollection<passanger_master> passanger_Masters { get; set; }
        //for booking_header


        [ForeignKey(name: "booking_Id")]
        public int booking_Id { get; set; }
        //for passanger_master


    }
}
