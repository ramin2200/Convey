using Convey.CQRS.Events;
using System;

namespace Pacco.Services.Ecommerce.Application.Events.Rejected
{
    [Contract]
    public class DeleteResourceRejected : IRejectedEvent
    {
        public Guid ResourceId { get; }
        public string Reason { get; }
        public string Code { get; }

        public DeleteResourceRejected(Guid resourceId, string reason, string code)
            => (ResourceId, Reason, Code) = (resourceId, reason, code);
    }
}