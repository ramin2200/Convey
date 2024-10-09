using Pacco.Services.Availability.Core.Events;
using System.Threading.Tasks;

namespace Ramin.MicroServices.Catelog.Application.Events
{
    public interface IDomainEventHandler<in T> where T : class, IDomainEvent
    {
        Task HandleAsync(T @event);
    }
}