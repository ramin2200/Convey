using Convey.CQRS.Events;
using Convey.MessageBrokers;
using System;

namespace Conveyor.Services.MY1.Events.External
{
    [Message("orders")]
    public class OrderCreated : IEvent
    {
        public Guid OrderId { get; }

        public OrderCreated(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}