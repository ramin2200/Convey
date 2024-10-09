using Ramin.Microservice.Catelog.Core.Entities;
using Ramin.Microservice.Catelog.Core.ValueObjects;

namespace Ramin.Microservice.Catelog.Core.Events
{
    public class ReservationCanceled : IDomainEvent
    {
        public Resource Resource { get; }
        public Reservation Reservation { get; }

        public ReservationCanceled(Resource resource, Reservation reservation)
            => (Resource, Reservation) = (resource, reservation);
    }
}