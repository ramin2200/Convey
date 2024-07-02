using Pacco.Services.Ecommerce.Core.Entities;

namespace Pacco.Services.Ecommerce.Core.Events
{
    public class ResourceCreated : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceCreated(Resource resource)
            => Resource = resource;
    }
}