/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using Microsoft.EntityFrameworkCore;

namespace ParkingWFP.Model
{
    public class ParkingContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=parkingdb;User Id=postgres;Password=admin");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // modelBuilder.Entity<OrderDetail>()
            // .HasKey(p => new { p.OrderID, p.ProductID });
        }
        
        public DbSet<User> User { get; set; }

        public DbSet<Printer> Printer { get; set; }

        public DbSet<VehicleCategory> VehicleCategory { get; set; }
        public DbSet<VehicleColor> VehicleColor { get; set; }
        public DbSet<VehicleModel> VehicleModel { get; set; }

        //public DbSet<Parking> Parking { get; set; }
    }
}
