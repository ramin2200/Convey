using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;



namespace Convey.Module.Monolithic
{
    public interface IModule
    {
        string Name { get; }
        IEnumerable<string> Policies => null;
        void Register(IConveyBuilder services);
        void Use(IApplicationBuilder app);
    }
}
