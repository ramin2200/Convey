using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using Pacco.Services.Ecommerce.Application.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Application.Events.External.Handlers
{
    public class VehicleDeletedHandler : IEventHandler<VehicleDeleted>
    {
        private readonly ICommandDispatcher _dispatcher;

        public VehicleDeletedHandler(ICommandDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public Task HandleAsync(VehicleDeleted @event, CancellationToken cancellationToken = default) => _dispatcher.SendAsync(new DeleteResource(@event.VehicleId));
    }
}