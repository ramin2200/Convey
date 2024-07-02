using Convey.CQRS.Queries;
using Pacco.Services.Ecommerce.Application.DTO;
using System;

namespace Pacco.Services.Ecommerce.Application.Queries
{
    public class GetResource : IQuery<ResourceDto>
    {
        public Guid ResourceId { get; set; }
    }
}