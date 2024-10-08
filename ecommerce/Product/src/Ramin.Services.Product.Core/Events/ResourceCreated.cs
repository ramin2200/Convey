using Convey.Domain.Events;
using Ramin.Services.Products.Core.Entities;

namespace Ramin.Services.Products.Core.Events
{
    public class ResourceCreated : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceCreated(Resource resource)
            => Resource = resource;
    }
}