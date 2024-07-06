using Convey.CQRS.Events;
using Convey.Domain.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pacco.Services.Ecommerce.Application.Events;
using Pacco.Services.Ecommerce.Application.Services;
using Pacco.Services.Ecommerce.Core.Events;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Infrastructure.Services
{
    internal sealed class EventProcessorEmpty : IEventProcessor
    {
        public async Task ProcessAsync(IEnumerable<IDomainEvent> events)
        {
            //throw new System.NotImplementedException();

        }
    }
}