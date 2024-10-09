using Ramin.Microservice.Catelog.Core.Entities;
using Ramin.Microservice.Catelog.Core.ValueObjects;

namespace Ramin.Microservice.Catelog.Core.Events
{
    public class ReservationReleased : IDomainEvent
    {
        public Resource Resource { get; }
        public Reservation Reservation { get; }

        public ReservationReleased(Resource resource, Reservation reservation)
            => (Resource, Reservation) = (resource, reservation);
    }
}