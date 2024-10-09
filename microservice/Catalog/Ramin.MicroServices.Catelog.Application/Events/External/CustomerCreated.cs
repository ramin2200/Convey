using Convey.CQRS.Events;
using Convey.MessageBrokers;
using System;

namespace Ramin.MicroServices.Catelog.Application.Events.External
{
    [Message("customers")]
    public class CustomerCreated : IEvent
    {
        public Guid CustomerId { get; }

        public CustomerCreated(Guid customerId)
            => CustomerId = customerId;
    }
}