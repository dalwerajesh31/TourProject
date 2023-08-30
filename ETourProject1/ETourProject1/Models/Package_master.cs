namespace ETourProject1.Models
{
    public class Package_master
    {
        public int PkgId { get; set; }
        public string? PkgName { get; set; }
        public int CatMasterId { get; set; }
        public ICollection<BookingHeader> BookingHeaders { get; set; }
<<<<<<< HEAD
        public ICollection<CostMaster> CostMaster { get; set; }
=======
        public ICollection<Cost_Master> CostMaster { get; set; }
>>>>>>> 608c68b2eeca3754cb3025811b353e9eaafff2c5
        public ICollection<Itinerary_Master> ItineraryMaster { get; set; }
        public ICollection<Date_Master> DateMaster { get; set; }
    }
}
