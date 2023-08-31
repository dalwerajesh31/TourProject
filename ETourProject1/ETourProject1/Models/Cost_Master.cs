using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETourProject1.Models
{
    [Table("Cost_Master")]
    public class Cost_Master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CostId { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public int SinglePersonCost { get; set; }

        [Required]
        public int ExtraPersonCost { get; set; }

        [Required]
        public int ChildWithBed { get; set; }

        [Required]
        public int ChildWithoutBed { get; set; }

        [Required]
        public DateTime ValidFrom { get; set; }

        [Required]
        public DateTime ValidTo { get; set; }

        [Required]
        public int pkgId { get; set; }

        [ForeignKey(name: "PkgId")]
        public int PkgId { get; set; }

      

        [ForeignKey("PkgId")]

        public Package_master Package_Master { get; set; }



    }
}
