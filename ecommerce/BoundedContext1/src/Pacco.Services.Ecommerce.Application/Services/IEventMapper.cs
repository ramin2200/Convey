using Convey.CQRS.Events;
using Pacco.Services.Ecommerce.Core.Events;
using System.Collections.Generic;

namespace Pacco.Services.Ecommerce.Application.Services
{
    public interface IEventMapper
    {
        IEvent Map(IDomainEvent @event);
        IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events);
    }
}