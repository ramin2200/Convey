namespace Pacco.Services.Ecommerce.Library.API.mass;

using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;

public class GettingStartedConsumer :
    IConsumer<GettingStarted>
{
    readonly ILogger<GettingStartedConsumer> _logger;

    public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger)
    {
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<GettingStarted> context)
    {
        _logger.LogInformation("Received Text: {Text}", context.Message.Value);
        await Task.Delay(TimeSpan.FromSeconds(10));
        //return Task.CompletedTask;
    }
}
