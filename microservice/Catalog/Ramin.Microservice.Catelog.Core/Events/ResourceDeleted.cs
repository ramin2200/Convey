using Ramin.Microservice.Catelog.Core.Entities;

namespace Ramin.Microservice.Catelog.Core.Events
{
    public class ResourceDeleted : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceDeleted(Resource resource)
            => Resource = resource;
    }
}