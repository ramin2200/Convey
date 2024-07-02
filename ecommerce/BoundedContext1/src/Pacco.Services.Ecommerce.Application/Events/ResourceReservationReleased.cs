using Convey.CQRS.Events;
using System;

namespace Pacco.Services.Ecommerce.Application.Events
{
    [Contract]
    public class ResourceReservationReleased : IEvent
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }

        public ResourceReservationReleased(Guid resourceId, DateTime dateTime)
            => (ResourceId, DateTime) = (resourceId, dateTime);
    }
}