using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pacco.Services.Ecommerce.Core.Entities;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.models;
using System;
using System.Linq;

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.Configurations;

public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
{
    public void Configure(EntityTypeBuilder<Resource> builder)
    {
        builder.Property(u => u.Tags)
               .HasConversion(
                   tags => string.Join(',', tags), // Convert List<string> to a single string
                   tags => tags.Split(',', StringSplitOptions.None).ToList() // Convert string back to List<string>
               );

        builder.Property(a => a.Id)
                .ValueGeneratedNever()
                .HasConversion(new AggregateIdValueConverter());
        //builder.Property(x => x.Description).HasMaxLength(255);


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