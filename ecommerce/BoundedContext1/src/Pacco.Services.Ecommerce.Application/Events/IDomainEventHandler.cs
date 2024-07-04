using Convey.Domain.Events;
using Pacco.Services.Ecommerce.Core.Events;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Application.Events
{
    public interface IDomainEventHandler<in T> where T : class, IDomainEvent
    {
        Task HandleAsync(T @event);
    }
}