using Microsoft.EntityFrameworkCore;
using Ramin.Services.Products.Core.Domain.Products;
using System;

namespace Ramin.Services.Products.Infrastructure.PostgreSQL.DBContext
{
    public class ProductContext : DbContext
    {
        public DbSet<Ramin.Services.Products.Core.Domain.Products.Product> Products { get; set; }


        public ProductContext() : base()
        {

        }

        public ProductContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost:5432;Database=demo-db2;Username=postgres;Password=");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("products");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}
