using Convey.CQRS.Events;
using System;

namespace Pacco.Services.Ecommerce.Application.Events
{
    [Contract]
    public class ResourceReserved : IEvent
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }

        public ResourceReserved(Guid resourceId, DateTime dateTime)
            => (ResourceId, DateTime) = (resourceId, dateTime);
    }
}