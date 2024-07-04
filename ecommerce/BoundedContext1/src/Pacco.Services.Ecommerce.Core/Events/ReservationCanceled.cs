using Convey.Domain.Events;
using Pacco.Services.Ecommerce.Core.Entities;
using Pacco.Services.Ecommerce.Core.ValueObjects;

namespace Pacco.Services.Ecommerce.Core.Events
{
    public class ReservationCanceled : IDomainEvent
    {
        public Resource Resource { get; }
        public Reservation Reservation { get; }

        public ReservationCanceled(Resource resource, Reservation reservation)
            => (Resource, Reservation) = (resource, reservation);
    }
}