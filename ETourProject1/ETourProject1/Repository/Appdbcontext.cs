<<<<<<< HEAD
﻿
=======

﻿using Microsoft.EntityFrameworkCore;﻿
>>>>>>> de3632a5b00d0d0dad8f9079b43726e3db32f183
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;

namespace ETourProject1.Repository
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {

        }

        public DbSet<Package_master> Packages { get; set; }

        // Add DbSet properties for your entities
        public DbSet<Itinerary_Master> ItineraryMasters { get; set; }

        // Add the repository interface as a property
        public Itinerary_MasterInterface ItineraryMasterRepository { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity relationships and mappings here

            // Initialize the repository in the constructor
            

            base.OnModelCreating(modelBuilder);
        }

<<<<<<< HEAD
        public DbSet<BookingHeader> Bookings { get; set; }

=======

// HEAD
        public DbSet<Cost_Master> Cost { get; set; }




        public DbSet<Date_Master> Date { get; set; }


        public DbSet<Customer_Master> Customer_Master { get; set; }
// 4e7af376857a3c83558dae30978ac8e6caa5ea36
>>>>>>> de3632a5b00d0d0dad8f9079b43726e3db32f183
        /* 
       *     ____!!!! Data set of Poco Classes !!!_______
       *     
       * 

        //public DbSet<Employee> Employees { get; set; }*/

    }
}
