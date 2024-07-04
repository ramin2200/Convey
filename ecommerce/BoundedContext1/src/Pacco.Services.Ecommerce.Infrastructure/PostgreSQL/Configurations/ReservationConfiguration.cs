using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pacco.Services.Ecommerce.Core.Entities;
using Pacco.Services.Ecommerce.Core.ValueObjects;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.models;

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.Configurations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {

        //builder.Property(x => x.Description).HasMaxLength(255);
        builder.Property<int>("Id")
               .ValueGeneratedOnAdd(); // Automa
        //builder.HasKey(u => "Id");
        
        
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