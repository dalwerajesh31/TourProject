namespace ETourProject1.Models
{
    public class Package_master
    {
        public int PkgId { get; set; }
        public string? PkgName { get; set; }
        public int CatMasterId { get; set; }
        public ICollection<BookingHeader> BookingHeaders { get; set; }
        public ICollection<CostMaster> CostMaster { get; set; }
        public ICollection<Itinerary_Master> ItineraryMaster { get; set; }
        public ICollection<Date_Master> DateMaster { get; set; }
    }
}
