

﻿using Microsoft.EntityFrameworkCore;

﻿
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;



using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;


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

        public DbSet<Passanger_Master> passanger_Masters;

        public DbSet<Customer_Master> Customer_Master { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity relationships and mappings here

            // Initialize the repository in the constructor
            

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<BookingHeader> Bookings { get; set; }


// HEAD
        public DbSet<Cost_Master> Cost { get; set; }




        public DbSet<Date_Master> Date { get; set; }


      
// 4e7af376857a3c83558dae30978ac8e6caa5ea36
        /* 
       *     ____!!!! Data set of Poco Classes !!!_______
       *     
       * 

        //public DbSet<Employee> Employees { get; set; }*/

    }
}
