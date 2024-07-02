using Convey.CQRS.Queries;
using Pacco.Services.Ecommerce.Application.DTO;
using System.Collections.Generic;

namespace Pacco.Services.Ecommerce.Application.Queries
{
    public class GetResources : IQuery<IEnumerable<ResourceDto>>
    {
        public IEnumerable<string> Tags { get; set; }
        public bool MatchAllTags { get; set; }
    }
}