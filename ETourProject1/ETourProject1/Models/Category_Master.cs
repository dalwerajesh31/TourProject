using System.ComponentModel.DataAnnotations;

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
    }
}
