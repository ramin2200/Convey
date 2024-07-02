using Convey;
using Convey.CQRS.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Pacco.Services.Ecommerce.Infrastructure.Jaeger
{
    internal static class Extensions
    {
        public static IConveyBuilder AddJaegerDecorators(this IConveyBuilder builder)
        {
            builder.Services.TryDecorate(typeof(ICommandHandler<>), typeof(JaegerCommandHandlerDecorator<>));

            return builder;
        }
    }
}