using Microsoft.EntityFrameworkCore;
using Pacco.Services.Ecommerce.Core.Entities;
using Pacco.Services.Ecommerce.Core.ValueObjects;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.models;
using System;

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.DBContext
{
    public class AvailabilityContext : DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public AvailabilityContext() : base()
        {
            
        }

        public AvailabilityContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost:5432;Database=demo-db2;Username=postgres;Password=");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AvailabilityContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}
