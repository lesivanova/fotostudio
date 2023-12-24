using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Model
{
    class PhotoStudioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=LAPTOP-JK32SL7A\SQLEXPRESS
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-13OO92Q\SQLEXPRESS01; Initial Catalog=photostudiodb; Integrated Security=True"); 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
