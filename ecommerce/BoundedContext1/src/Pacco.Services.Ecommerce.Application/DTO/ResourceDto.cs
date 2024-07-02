using System;
using System.Collections.Generic;

namespace Pacco.Services.Ecommerce.Application.DTO
{
    public class ResourceDto
    {
        public Guid Id { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<ReservationDto> Reservations { get; set; }
    }
}