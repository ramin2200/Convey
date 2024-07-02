using Convey.CQRS.Events;
using Convey.MessageBrokers;
using System;

namespace Pacco.Services.Ecommerce.Application.Events.External
{
    [Message("vehicles")]
    public class VehicleDeleted : IEvent
    {
        public Guid VehicleId { get; }

        public VehicleDeleted(Guid vehicleId)
            => VehicleId = vehicleId;
    }
}