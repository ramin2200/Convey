using Convey.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace Ramin.Services.Products.Infrastructure.PostgreSQL.Configurations
{
    public class AggregateIdValueConverter : ValueConverter<AggregateId, Guid>
    {
        public AggregateIdValueConverter(ConverterMappingHints mappingHints = null)
            : base(
                id => id.Value,
                value => new AggregateId(value),
                mappingHints
            )
        { }
    }
}