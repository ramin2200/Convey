using System;

namespace Ramin.Services.Products.Core.ValueObjects
{
    public class Reservation : IEquatable<Reservation>
    {
        public DateTime DateTime { get; }
        public int Priority { get; }

        public Reservation()
        {

        }
        public Reservation(DateTime dateTime, int priority)
            => (DateTime, Priority) = (dateTime, priority);

        public bool Equals(Reservation reservation)
            => Priority.Equals(reservation.Priority) && DateTime.Date.Equals(reservation.DateTime.Date);

        public override bool Equals(object obj)
            => obj is Reservation reservation && Equals(reservation);

        public override int GetHashCode()
            => DateTime.Date.GetHashCode();
    }
}