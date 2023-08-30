
﻿using Microsoft.EntityFrameworkCore;

﻿
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

        // Add DbSet properties for your entities
        public DbSet<Itinerary_Master> Itinerary_Master{ get; set; }

        // Add the repository interface as a property
        public Itinerary_MasterInterface ItineraryMasterRepository { get;  set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity relationships and mappings here

            // Initialize the repository in the constructor
            

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Date_Master> Date { get; set; }


        public DbSet<Customer_Master> Customer_Master { get; set; }
        /* 
       *     ____!!!! Data set of Poco Classes !!!_______
       *     
       * 

        //public DbSet<Employee> Employees { get; set; }*/

    }
}
