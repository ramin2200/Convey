using Convey.CQRS.Events;
using System;

namespace Conveyor.Services.MY1.Events
{
    public class DeliveryStarted : IEvent
    {
        public Guid DeliveryId { get; }

        public DeliveryStarted(Guid deliveryId)
        {
            DeliveryId = deliveryId;
        }
    }
}