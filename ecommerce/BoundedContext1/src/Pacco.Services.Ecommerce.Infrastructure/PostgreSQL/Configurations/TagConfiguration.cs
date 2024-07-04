using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.models;

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {

    }
}