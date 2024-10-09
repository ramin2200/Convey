using System;

namespace Ramin.MicroServices.Catelog.Application.DTO
{
    public class CustomerStateDto
    {
        public string State { get; set; }
        public bool IsValid => State.Equals("valid", StringComparison.InvariantCultureIgnoreCase);
    }
}