using Convey.CQRS.Commands;
using Pacco.Services.Ecommerce.Core.Repositories;
using Pacco.Services.Ecommerce.Application.Exceptions;
using Pacco.Services.Ecommerce.Application.Services;
using System.Threading.Tasks;
using System.Threading;

namespace Pacco.Services.Ecommerce.Application.Commands.Handlers
{
    internal sealed class DeleteResourceHandler : ICommandHandler<DeleteResource>
    {
        private readonly IResourcesRepository _repository;
        private readonly IEventProcessor _eventProcessor;

        public DeleteResourceHandler(IResourcesRepository repository, IEventProcessor eventProcessor)
        {
            _repository = repository;
            _eventProcessor = eventProcessor;
        }

        public async Task HandleAsync(DeleteResource command, CancellationToken cancellationToken = default)
        {
            var resource = await _repository.GetAsync(command.ResourceId);

            if (resource is null)
            {
                throw new ResourceNotFoundException(command.ResourceId);
            }

            resource.Delete();
            await _repository.DeleteAsync(resource.Id);
            await _eventProcessor.ProcessAsync(resource.Events);
        }
    }
}