
using System.ComponentModel.DataAnnotations.Schema;

namespace ETourProject1.Models
{
    public class Package_master
    {
        public int PkgId { get; set; }
        public string? PkgName { get; set; }
        public int CatMasterId { get; set; }
        public ICollection<BookingHeader> BookingHeaders { get; set; }

        public ICollection<Cost_Master> CostMaster { get; set; }

        public ICollection<Cost_Master> Cost_Master { get; set; }

        public ICollection<Itinerary_Master> ItineraryMaster { get; set; }
        public ICollection<Date_Master> DateMaster { get; set; }

        [ForeignKey(name: "catMasterID")]
        public int catMasterID { get; set; }

        public ICollection<Cost_Master> PackageCost { get; set; }
    }
}
