using Pacco.Services.Availability.Core.Template1hg.Entities;

namespace Pacco.Services.Availability.Core.Template1hg.Events
{
    public class ResourceDeleted : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceDeleted(Resource resource)
            => Resource = resource;
    }
}