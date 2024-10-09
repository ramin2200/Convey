using Convey.CQRS.Queries;
using Ramin.MicroServices.Catelog.Application.DTO;
using System.Collections.Generic;

namespace Ramin.MicroServices.Catelog.Application.Queries
{
    public class GetResources : IQuery<IEnumerable<ResourceDto>>
    {
        public IEnumerable<string> Tags { get; set; }
        public bool MatchAllTags { get; set; }
    }
}