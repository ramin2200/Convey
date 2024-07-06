using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Pacco.Services.Availability.Tests.Unit")]

namespace Pacco.Services.Ecommerce.Application
{
    public static class Extensions
    {
        //public static IConveyBuilder AddApplication(this IConveyBuilder builder)
        //    => builder
        //        .AddCommandHandlers()
        //        .AddEventHandlers()
        //        .AddInMemoryCommandDispatcher()
        //        .AddInMemoryEventDispatcher();
    }
}