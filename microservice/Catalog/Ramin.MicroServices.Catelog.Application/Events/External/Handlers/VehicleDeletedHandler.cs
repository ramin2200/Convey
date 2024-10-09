using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using Ramin.MicroServices.Catelog.Application.Commands;
using System.Threading.Tasks;

namespace Ramin.MicroServices.Catelog.Application.Events.External.Handlers
{
    public class VehicleDeletedHandler : IEventHandler<VehicleDeleted>
    {
        private readonly ICommandDispatcher _dispatcher;

        public VehicleDeletedHandler(ICommandDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public Task HandleAsync(VehicleDeleted @event) => _dispatcher.SendAsync(new DeleteResource(@event.VehicleId));
    }
}