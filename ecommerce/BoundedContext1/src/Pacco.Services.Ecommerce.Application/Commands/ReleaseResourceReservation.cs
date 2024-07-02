using Convey.CQRS.Commands;
using System;

namespace Pacco.Services.Ecommerce.Application.Commands
{
    [Contract]
    public class ReleaseResourceReservation : ICommand
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }

        public ReleaseResourceReservation(Guid resourceId, DateTime dateTime)
            => (ResourceId, DateTime) = (resourceId, dateTime);
    }
}