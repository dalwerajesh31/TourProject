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


            /* 
           *     ____!!!! Data set of Poco Classes !!!_______
           *     
           * public DbSet<Customers> Customers { get; set; }

            //public DbSet<Employee> Employees { get; set; }*/
        }
    }

