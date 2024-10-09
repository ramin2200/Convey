using Convey.CQRS.Events;
using Pacco.Services.Availability.Core.Events;
using System.Collections.Generic;

namespace Ramin.MicroServices.Catelog.Application.Services
{
    public interface IEventMapper
    {
        IEvent Map(IDomainEvent @event);
        IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events);
    }
}