using Convey.CQRS.Events;
using System;

namespace Pacco.Services.Ecommerce.Application.Events.Rejected
{
    [Contract]
    public class ReleaseResourceRejected : IRejectedEvent
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }
        public string Reason { get; }
        public string Code { get; }

        public ReleaseResourceRejected(Guid resourceId, DateTime dateTime, string reason, string code)
            => (ResourceId, DateTime, Reason, Code) = (resourceId, dateTime, reason, code);
    }
}