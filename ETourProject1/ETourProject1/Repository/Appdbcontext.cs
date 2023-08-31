using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;



namespace ETourProject1.Repository
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {

        }
        public DbSet<Passanger_Master> Passanger { get; set; }

        public DbSet<Package_master> Packages { get; set; }

      
        public DbSet<Itinerary_Master> Itinerary_Master{ get; set; }

      
        public Itinerary_MasterInterface ItineraryMasterRepository { get;  set; }

       

        public DbSet<Customer_Master> Customer_Master { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<BookingHeader> Bookings { get; set; }

        public DbSet<Cost_Master> Cost { get; set; }


        public DbSet<Category_Master> Category { get; set; }


        public DbSet<Date_Master> Date { get; set; }




    }
}
