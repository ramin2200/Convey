﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ramin.Services.Products.Core.Domain.Products;

namespace Ramin.Services.Products.Infrastructure.PostgreSQL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever()
                    .HasConversion(new AggregateIdValueConverter());
            builder.Property(x => x.Title).HasMaxLength(255);


            //builder.HasIndex(x => new { x.OwnerId, x.Currency }).IsUnique();
            //builder.Property(x => x.Version).IsConcurrencyToken();
            //builder.Ignore(x => x.Events);
            //builder.HasOne<Owner>().WithMany().HasForeignKey(x => x.OwnerId);

            //builder.Property(x => x.Id)
            //    .HasConversion(x => x.Value, x => new WalletId(x));

            //builder.Property(x => x.OwnerId)
            //    .IsRequired()
            //    .HasConversion(x => x.Value, x => new OwnerId(x));

            //builder.Property(x => x.Currency)
            //    .IsRequired()
            //    .HasConversion(x => x.Value, x => new Currency(x));
        }
    }
}