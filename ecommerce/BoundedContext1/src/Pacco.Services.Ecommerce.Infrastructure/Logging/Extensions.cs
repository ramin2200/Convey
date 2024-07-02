using Convey;
using Convey.Logging.CQRS;
using Microsoft.Extensions.DependencyInjection;
using Pacco.Services.Ecommerce.Application.Commands;

namespace Pacco.Services.Ecommerce.Infrastructure.Logging
{
    internal static class Extensions
    {
        public static IConveyBuilder AddHandlersLogging(this IConveyBuilder builder)
        {
            var assembly = typeof(AddResource).Assembly;

            builder.Services.AddSingleton<IMessageToLogTemplateMapper>(new MessageToLogTemplateMapper());

            return builder
                .AddCommandHandlersLogging(assembly)
                .AddEventHandlersLogging(assembly);
        }
    }
}