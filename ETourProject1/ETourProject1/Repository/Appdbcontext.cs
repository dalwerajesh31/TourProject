<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
=======
﻿
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;
>>>>>>> 3002bae84acf9cdd945bbdcc84d0f83f38727188
using ETourProject1.Models;

namespace ETourProject1.Repository
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {

        }

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
=======
        public DbSet<Date_Master> Date { get; set; }


        public DbSet<Customer_Master> Customer_Master { get; set; }
        /* 
       *     ____!!!! Data set of Poco Classes !!!_______
       *     
       * 

        //public DbSet<Employee> Employees { get; set; }*/
>>>>>>> 3002bae84acf9cdd945bbdcc84d0f83f38727188
    }
}
