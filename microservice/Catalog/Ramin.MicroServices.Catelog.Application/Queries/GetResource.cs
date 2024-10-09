using Convey.CQRS.Queries;
using Ramin.MicroServices.Catelog.Application.DTO;
using System;

namespace Ramin.MicroServices.Catelog.Application.Queries
{
    public class GetResource : IQuery<ResourceDto>
    {
        public Guid ResourceId { get; set; }
    }
}