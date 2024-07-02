using Convey.CQRS.Events;
using System;

namespace Pacco.Services.Ecommerce.Application.Events
{
    [Contract]
    public class ResourceAdded : IEvent
    {
        public Guid ResourceId { get; }

        public ResourceAdded(Guid resourceId)
            => ResourceId = resourceId;
    }
}