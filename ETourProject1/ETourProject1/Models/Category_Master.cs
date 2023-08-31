using System.ComponentModel.DataAnnotations;
using ETourProject1.Models;



namespace ETourProject1.Models
{
    public class Category_Master
    {
        [Key]
        public int catMasterID { get; set; }
        [Required]
        public string catID { get; set; }
        [Required]
        public string subCatID { get; set; }
        [Required]
        public string catName { get; set; }
        [Required]
        public string catImagePath { get; set; }

        public ICollection<Date_Master> categorydate { get; set; }
        public ICollection<Package_master> categoryPackage { get; set; }
        public ICollection<Itinerary_Master> categoryItinerary { get; set; }
    }
}
