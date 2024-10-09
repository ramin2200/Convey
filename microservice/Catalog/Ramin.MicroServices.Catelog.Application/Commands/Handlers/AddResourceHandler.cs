using Convey.CQRS.Commands;
using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.Repositories;
using Ramin.MicroServices.Catelog.Application.Exceptions;
using Ramin.MicroServices.Catelog.Application.Services;
using System.Threading.Tasks;

namespace Ramin.MicroServices.Catelog.Application.Commands.Handlers
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

        public async Task HandleAsync(AddResource command)
        {
            if (await _repository.ExistsAsync(command.ResourceId))
            {
                throw new ResourceAlreadyExistsException(command.ResourceId);
            }

            var resource = Resource.Create(command.ResourceId, command.Tags);
            await _repository.AddAsync(resource);
            await _eventProcessor.ProcessAsync(resource.Events);
        }
    }
}