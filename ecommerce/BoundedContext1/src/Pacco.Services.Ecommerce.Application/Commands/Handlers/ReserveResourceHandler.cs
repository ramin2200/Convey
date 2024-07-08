using Convey.CQRS.Commands;
using Pacco.Services.Ecommerce.Core.Repositories;
using Pacco.Services.Ecommerce.Core.ValueObjects;
using Pacco.Services.Ecommerce.Application.Exceptions;
using Pacco.Services.Ecommerce.Application.Services;
using Pacco.Services.Ecommerce.Application.Services.Clients;
using System.Threading.Tasks;
using System.Threading;

namespace Pacco.Services.Ecommerce.Application.Commands.Handlers
{
    internal sealed class ReserveResourceHandler : ICommandHandler<ReserveResource>
    {
        private readonly IResourcesRepository _repository;
        //private readonly ICustomersServiceClient _customersServiceClient;
        private readonly IEventProcessor _eventProcessor;
        private readonly IAppContext _appContext;

        public ReserveResourceHandler(IResourcesRepository repository, 
            IEventProcessor eventProcessor, IAppContext appContext)
        {
            _repository = repository;
            //_customersServiceClient = customersServiceClient;
            _eventProcessor = eventProcessor;
            _appContext = appContext;
        }

        public async Task HandleAsync(ReserveResource command, CancellationToken cancellationToken = default)
        {
            var identity = _appContext.Identity;
            if (identity.IsAuthenticated && identity.Id != command.CustomerId && !identity.IsAdmin)
            {
                throw new UnauthorizedResourceAccessException(command.ResourceId, identity.Id);
            }

            var resource = await _repository.GetAsync(command.ResourceId);
            if (resource is null)
            {
                throw new ResourceNotFoundException(command.ResourceId);
            }

            //var customerState = await _customersServiceClient.GetStateAsync(command.CustomerId);
            //if (customerState is null)
            //{
            //    throw new CustomerNotFoundException(command.CustomerId);
            //}

            //if (!customerState.IsValid)
            //{
            //    throw new InvalidCustomerStateException(command.ResourceId, customerState?.State);
            //}

            var reservation = new Reservation(command.DateTime, command.Priority);
            resource.AddReservation(reservation);
            await _repository.UpdateAsync(resource);
            await _eventProcessor.ProcessAsync(resource.Events);
        }
    }
}