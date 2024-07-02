using Pacco.Services.Availability.Core.Template1hg.Entities;

namespace Pacco.Services.Availability.Core.Template1hg.Events
{
    public class ResourceCreated : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceCreated(Resource resource)
            => Resource = resource;
    }
}