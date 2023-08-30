using ETourProject1.Repository;

using Microsoft.EntityFrameworkCore;
using System;

using ETourProject1.Repository;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

using ETourProject1.Repository;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddTransient<IBookingHeaderRepository, BookingHeaderRepository>();

            // Add services to the container.
            builder.Services.AddDbContext<Appdbcontext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("ETourDbString")));


            builder.Services.AddDbContext<Appdbcontext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("Cost_Master")));

            builder.Services.AddDbContext<Appdbcontext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("Customer_Master")));

            builder.Services.AddDbContext<Category_dbcontext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("Categorydb")));

            builder.Services.AddControllers();

            // Configure DbContext and Repository
            builder.Services.AddDbContext<Appdbcontext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            /*builder.Services.AddScoped<IItineraryMasterRepository, ItineraryMasterRepository>();
            builder.Services.AddScoped<IItineraryMasterService, ItineraryMasterService>();*/

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
