using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ETourProject1.Models
{
    public class Itinerary_Master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItrId { get; set; }

        [Required]
        [ForeignKey("PkgId")]
        public int PkgId { get; set; }

        [Required]
        [Range(1, 99)] // Adjust the range as needed
        public int DayNo { get; set; }

        [MaxLength(255)] // Adjust the max length as needed
        public string ItrDtl { get; set; }

        [ForeignKey(name: "catMasterID")]
        public int catMasterID { get; set; }

        /*  // Navigation property for the Package Master (assuming "Package" is the entity)
          public virtual Package Package { get; set; }*/
    }
}
