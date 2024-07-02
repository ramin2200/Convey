using Pacco.Services.Availability.Core.Template1hg.Entities;
using Pacco.Services.Availability.Core.Template1hg.ValueObjects;

namespace Pacco.Services.Availability.Core.Template1hg.Events
{
    public class ReservationReleased : IDomainEvent
    {
        public Resource Resource { get; }
        public Reservation Reservation { get; }

        public ReservationReleased(Resource resource, Reservation reservation)
            => (Resource, Reservation) = (resource, reservation);
    }
}