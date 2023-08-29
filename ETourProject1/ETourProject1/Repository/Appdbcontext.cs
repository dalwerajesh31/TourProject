
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;

namespace ETourProject1.Repository

{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext() { }

        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\ProjectModels;Initial Catalog=ETourDB;Integrated Security=True;");
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