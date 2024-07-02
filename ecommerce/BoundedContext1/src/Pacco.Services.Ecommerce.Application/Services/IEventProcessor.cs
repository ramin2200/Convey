using Pacco.Services.Ecommerce.Core.Events;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Application.Services
{
    public interface IEventProcessor
    {
        Task ProcessAsync(IEnumerable<IDomainEvent> events);
    }
}