using Convey.CQRS.Events;
using System.Threading;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Application.Events.External.Handlers
{
    public class CustomerCreatedHandler : IEventHandler<CustomerCreated>
    {
        // Customer data could be saved into custom DB depending on the business requirements.
        // Given the asynchronous nature of events, this would result in eventual consistency.
        public Task HandleAsync(CustomerCreated @event, CancellationToken cancellationToken = default)
            => Task.CompletedTask;
    }
}