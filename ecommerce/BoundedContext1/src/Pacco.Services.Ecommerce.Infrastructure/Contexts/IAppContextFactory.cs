using Pacco.Services.Ecommerce.Application;

namespace Pacco.Services.Ecommerce.Infrastructure.Contexts
{
    internal interface IAppContextFactory
    {
        IAppContext Create();
    }
}