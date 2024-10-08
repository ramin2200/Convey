using Convey.Domain.Events;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ramin.Services.Products.Application.Services
{
    public interface IEventProcessor
    {
        Task ProcessAsync(IEnumerable<IDomainEvent> events);
    }
}