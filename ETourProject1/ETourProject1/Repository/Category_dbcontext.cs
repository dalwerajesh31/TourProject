using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ETourProject1.Repository
{
        public class Category_dbcontext : DbContext
        {
            public Category_dbcontext() { }

            public Category_dbcontext(DbContextOptions<Category_dbcontext> options) : base(options)
            {

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\ProjectModels;Initial Catalog=ETourDB;Integrated Security=True;");
            }
         public DbSet<Category_Master> Category { get; set; }

        public DbSet<Package_master> Packages { get; set; }

        // Add DbSet properties for your entities
        public DbSet<Itinerary_Master> Itinerary_Master { get; set; }

        // Add the repository interface as a property
        public Itinerary_MasterInterface ItineraryMasterRepository { get; set; }


        public DbSet<Customer_Master> Customer_Master { get; set; }


       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity relationships and mappings here

            // Initialize the repository in the constructor


            base.OnModelCreating(modelBuilder);
        }
*/

        public DbSet<BookingHeader> Bookings { get; set; }

        public DbSet<Cost_Master> Cost { get; set; }

        public DbSet<Date_Master> Date { get; set; }


        /* 
       *     ____!!!! Data set of Poco Classes !!!_______
       *     
       * public DbSet<Customers> Customers { get; set; }

        //public DbSet<Employee> Employees { get; set; }*/
    }
    }

