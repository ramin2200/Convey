using Pacco.Services.Availability.Application;

namespace Ramin.Microservices.Catalog.Infrastructure.Contexts
{
    internal interface IAppContextFactory
    {
        IAppContext Create();
    }
}