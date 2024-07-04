using Convey.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pacco.Services.Ecommerce.Core.Entities;
using Pacco.Services.Ecommerce.Core.ValueObjects;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.models;
using System;

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.Configurations;

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