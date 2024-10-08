using Convey.Domain.Events;
using Ramin.Services.Products.Core.Entities;

namespace Ramin.Services.Products.Core.Events
{
    public class ResourceDeleted : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceDeleted(Resource resource)
            => Resource = resource;
    }
}