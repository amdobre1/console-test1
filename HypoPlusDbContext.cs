using HypoplusToDwhExporter.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwhConsole
{
    internal class HypoPlusDbContext : DbContext
    {

        private readonly string _connString;

        public HypoPlusDbContext(string connString)
        {
            _connString = connString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            options.UseMySQL(_connString);
        }

#pragma warning disable IDE1006 // Naming Styles
        public DbSet<customer> customer { get; set; }
        public DbSet<lead> lead { get; set; }
        public DbSet<customer_status> customer_status { get; set; }
        public DbSet<most_significant_lead> most_significant_lead { get; set; }
        public DbSet<referrer> referrer { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
