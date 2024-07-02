using Convey.CQRS.Queries;
using MongoDB.Driver;
using Pacco.Services.Ecommerce.Application.DTO;
using Pacco.Services.Ecommerce.Application.Queries;
using Pacco.Services.Ecommerce.Infrastructure.Mongo.Documents;
using System.Threading;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Infrastructure.Mongo.Queries.Handlers
{
    internal sealed class GetResourceHandler : IQueryHandler<GetResource, ResourceDto>
    {
        private readonly IMongoDatabase _database;

        public GetResourceHandler(IMongoDatabase database)
        {
            _database = database;
        }

        public async Task<ResourceDto> HandleAsync(GetResource query, CancellationToken cancellationToken = default)
        {
            var document = await _database.GetCollection<ResourceDocument>("resources")
                .Find(r => r.Id == query.ResourceId)
                .SingleOrDefaultAsync();

            return document?.AsDto();
        }

    }
}