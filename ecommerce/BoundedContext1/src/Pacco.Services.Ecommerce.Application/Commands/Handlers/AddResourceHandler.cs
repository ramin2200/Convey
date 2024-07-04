using Convey.CQRS.Commands;
using Pacco.Services.Ecommerce.Core.Entities;
using Pacco.Services.Ecommerce.Core.Repositories;
using Pacco.Services.Ecommerce.Application.Exceptions;
using Pacco.Services.Ecommerce.Application.Services;
using System.Threading.Tasks;
using System.Threading;

namespace Pacco.Services.Ecommerce.Application.Commands.Handlers
{
    internal sealed class AddResourceHandler : ICommandHandler<AddResource>
    {
        private readonly IResourcesRepository _repository;
        private readonly IEventProcessor _eventProcessor;

        public AddResourceHandler(IResourcesRepository repository, IEventProcessor eventProcessor)
        {
            _repository = repository;
            _eventProcessor = eventProcessor;
        }

        public async Task HandleAsync(AddResource command, CancellationToken cancellationToken = default)
        {
            //if (await _repository.ExistsAsync(command.ResourceId))
            //{
            //    throw new ResourceAlreadyExistsException(command.ResourceId);
            //}

            var resource = Resource.Create(command.ResourceId, command.Tags);
            await _repository.AddAsync(resource);
            await _eventProcessor.ProcessAsync(resource.Events);
        }

    }
}