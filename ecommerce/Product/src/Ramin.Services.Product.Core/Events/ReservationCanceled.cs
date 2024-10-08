using Convey.Domain.Events;
using Ramin.Services.Products.Core.Entities;
using Ramin.Services.Products.Core.ValueObjects;

namespace Ramin.Services.Products.Core.Events
{
    public class ReservationCanceled : IDomainEvent
    {
        public Resource Resource { get; }
        public Reservation Reservation { get; }

        public ReservationCanceled(Resource resource, Reservation reservation)
            => (Resource, Reservation) = (resource, reservation);
    }
}