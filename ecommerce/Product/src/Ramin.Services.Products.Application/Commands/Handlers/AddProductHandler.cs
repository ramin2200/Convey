using Convey.CQRS.Commands;
using System.Threading.Tasks;
using System.Threading;
using Ramin.Services.Products.Application.Services;
using Ramin.Services.Products.Core.Domain.Products;

namespace Ramin.Services.Products.Application.Commands.Handlers
{
    internal sealed class AddProductHandler : ICommandHandler<AddProductCommand>
    {
        private readonly IProductRepository _repository;
        private readonly IEventProcessor _eventProcessor;

        public AddProductHandler(IProductRepository repository, IEventProcessor eventProcessor)
        {
            _repository = repository;
            _eventProcessor = eventProcessor;
        }

        public async Task HandleAsync(AddProductCommand command, CancellationToken cancellationToken = default)
        {
            //if (await _repository.ExistsAsync(command.ResourceId))
            //{
            //    throw new ResourceAlreadyExistsException(command.ResourceId);
            //}

            var resource = Product.Create(command.Title);
            await _repository.AddAsync(resource);
            await _eventProcessor.ProcessAsync(resource.Events);
        }

    }
}