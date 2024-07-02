using Convey.Types;
using System;
using System.Collections.Generic;

namespace Pacco.Services.Ecommerce.Infrastructure.Mongo.Documents
{
    internal sealed class ResourceDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<ReservationDocument> Reservations { get; set; }
    }
}