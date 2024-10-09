using Pacco.Services.Availability.Core.Events;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ramin.MicroServices.Catelog.Application.Services
{
    public interface IEventProcessor
    {
        Task ProcessAsync(IEnumerable<IDomainEvent> events);
    }
}