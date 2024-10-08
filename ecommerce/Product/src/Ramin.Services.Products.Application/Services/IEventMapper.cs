using Convey.CQRS.Events;
using Convey.Domain.Events;
using System.Collections.Generic;

namespace Ramin.Services.Products.Application.Services
{
    public interface IEventMapper
    {
        IEvent Map(IDomainEvent @event);
        IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events);
    }
}