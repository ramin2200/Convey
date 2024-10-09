using Ramin.Microservice.Catelog.Core.Entities;

namespace Ramin.Microservice.Catelog.Core.Events
{
    public class ResourceCreated : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceCreated(Resource resource)
            => Resource = resource;
    }
}