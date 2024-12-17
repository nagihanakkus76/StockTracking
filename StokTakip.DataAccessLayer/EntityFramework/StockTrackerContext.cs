using Microsoft.EntityFrameworkCore;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.EntityFramework
{
    public class StockTrackerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0P2BI1D;initial catalog=StockTrackerDb;integrated Security=true;TrustServerCertificate=true");
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Processes> Processes { get; set; }
        public DbSet<ProcessType> ProcessTypes { get; set; }

    }
}
