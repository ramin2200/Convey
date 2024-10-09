using Convey.CQRS.Events;
using System;

namespace Ramin.MicroServices.Catelog.Application.Events
{
    [Contract]
    public class ResourceDeleted : IEvent
    {
        public Guid ResourceId { get; }

        public ResourceDeleted(Guid resourceId)
            => ResourceId = resourceId;
    }
}