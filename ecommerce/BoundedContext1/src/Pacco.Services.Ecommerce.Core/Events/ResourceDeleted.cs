using Pacco.Services.Ecommerce.Core.Entities;

namespace Pacco.Services.Ecommerce.Core.Events
{
    public class ResourceDeleted : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceDeleted(Resource resource)
            => Resource = resource;
    }
}