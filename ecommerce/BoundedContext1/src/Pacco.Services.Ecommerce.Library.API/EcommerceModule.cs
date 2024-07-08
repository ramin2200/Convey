using Microsoft.AspNetCore.Builder;
using Convey.Module.Monolithic;
using Convey;
using Pacco.Services.Ecommerce.Application;
using Pacco.Services.Ecommerce.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Convey.WebApi;

namespace Pacco.Services.Ecommerce.Library.API;

internal class EcommerceModule : IModule
{
    public string Name { get; } = "Ecommerce";

    public IEnumerable<string> Policies { get; } = new[]
    {
        "transfers", "wallets"
    };

    public void Register(IConveyBuilder builder)
    {
        builder.AddInfrastructure();
        builder.Services.AddControllers();
    }

    public void Use(IApplicationBuilder app)
    {
        app.UseInfrastructure();
        app.UseRouting();
    }
}