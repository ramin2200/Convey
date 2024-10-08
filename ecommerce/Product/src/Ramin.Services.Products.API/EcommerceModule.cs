using Convey;
using Convey.Module.Monolithic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ramin.Services.Products.Infrastructure;

namespace Ramin.Services.Products.API
{
    internal class ProductModule : IModule
    {
        public string Name { get; } = "Product";

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
}