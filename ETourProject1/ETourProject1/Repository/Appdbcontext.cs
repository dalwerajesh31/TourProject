
<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;

﻿
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;

=======

using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;
>>>>>>> 608c68b2eeca3754cb3025811b353e9eaafff2c5
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
        public DbSet<Itinerary_Master> Itinerary_Master{ get; set; }

        // Add the repository interface as a property
        public Itinerary_MasterInterface ItineraryMasterRepository { get;  set; }
<<<<<<< HEAD
=======

        public DbSet<Customer_Master> Customer_Master { get; set; }
>>>>>>> 608c68b2eeca3754cb3025811b353e9eaafff2c5

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity relationships and mappings here

            // Initialize the repository in the constructor
            

            base.OnModelCreating(modelBuilder);
        }

<<<<<<< HEAD
=======
        public DbSet<BookingHeader> Bookings { get; set; }


// HEAD
        public DbSet<Cost_Master> Cost { get; set; }



>>>>>>> 608c68b2eeca3754cb3025811b353e9eaafff2c5

        public DbSet<Date_Master> Date { get; set; }


      
// 4e7af376857a3c83558dae30978ac8e6caa5ea36
        /* 
       *     ____!!!! Data set of Poco Classes !!!_______
       *     
       * 

        //public DbSet<Employee> Employees { get; set; }*/

    }
}
