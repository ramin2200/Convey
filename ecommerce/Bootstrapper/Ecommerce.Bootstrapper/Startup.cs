using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using Inflow.Shared.Abstractions.Modules;
//using Inflow.Shared.Infrastructure;
//using Inflow.Shared.Infrastructure.Contracts;
//using Inflow.Shared.Infrastructure.Modules;
using Convey.Module.Monolithic;
using Convey;
using Convey.MessageBrokers.RabbitMQ;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.DBContext;
using Convey.WebApi;
using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Events;

using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using Convey.CQRS.Queries;
using Convey.Discovery.Consul;
using Convey.Docs.Swagger;
using Convey.HTTP;
using Convey.LoadBalancing.Fabio;
using Convey.MessageBrokers;
using Convey.MessageBrokers.CQRS;
using Convey.MessageBrokers.Outbox;
using Convey.MessageBrokers.Outbox.Mongo;
using Convey.MessageBrokers.RabbitMQ;
using Convey.Metrics.AppMetrics;
using Convey.Persistence.MongoDB;
using Convey.Persistence.Redis;
using Convey.persistence.PostgreSQL;
using Convey.Security;
using Convey.Tracing.Jaeger;
using Convey.Tracing.Jaeger.RabbitMQ;
using Convey.WebApi;
using Convey.WebApi.CQRS;
using Convey.WebApi.Security;
using Convey.WebApi.Swagger;
using Elasticsearch.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Pacco.Services.Ecommerce.Application;
using Pacco.Services.Ecommerce.Application.Commands;
using Pacco.Services.Ecommerce.Application.Events;
using Pacco.Services.Ecommerce.Application.Events.External;
using Pacco.Services.Ecommerce.Application.Services;
using Pacco.Services.Ecommerce.Application.Services.Clients;
using Pacco.Services.Ecommerce.Core.Repositories;
using Pacco.Services.Ecommerce.Infrastructure.Contexts;
using Pacco.Services.Ecommerce.Infrastructure.Decorators;
using Pacco.Services.Ecommerce.Infrastructure.Exceptions;
using Pacco.Services.Ecommerce.Infrastructure.Jaeger;
using Pacco.Services.Ecommerce.Infrastructure.Logging;
using Pacco.Services.Ecommerce.Infrastructure.Metrics;
using Pacco.Services.Ecommerce.Infrastructure.Mongo.Documents;
using Pacco.Services.Ecommerce.Infrastructure.Mongo.Repositories;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.DBContext;
using Pacco.Services.Ecommerce.Infrastructure.Services;
using Pacco.Services.Ecommerce.Infrastructure.Services.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.Repositories;
using Monolith.Auth;
using Monolith.Exceptions.Infrastructure;
using Monolith.Context.Infrastructure;
using Monolith.Logging.Logging;

namespace Ecommerce.Bootstrapper;

public class Startup
{
    private readonly IList<Assembly> _assemblies;
    private readonly IList<IModule> _modules;

    public Startup(IConfiguration configuration)
    {
        _assemblies = ModuleLoader.LoadAssemblies(configuration, "Pacco.Services.");
        _modules = ModuleLoader.LoadModules(_assemblies);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        var builder = services.AddConvey();
        builder.AddModuleInfo(_modules)
            .AddAuth(_modules)
            .AddErrorHandling()
            .AddContext()
            .AddCommandHandlers()
            .AddEventHandlers()
            .AddInMemoryCommandDispatcher()
            .AddInMemoryEventDispatcher()
            .AddQueryHandlers()
            .AddInMemoryQueryDispatcher()
            .AddRabbitMq()
            .AddMongo()
            .AddLoggingDecorators();
        
        foreach (var module in _modules)
        {
            module.Register(builder);
        }

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
    {
        logger.LogInformation($"Modules: {string.Join(", ", _modules.Select(x => x.Name))}");
        
        app.UseConvey();
        app.UseErrorHandling();
        app.UseAuth();
        app.UseContext();

        foreach (var module in _modules)
        {
            module.Use(app);
        }
        
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGet("/", context => context.Response.WriteAsync("Ecommerce API"));
            endpoints.MapModuleInfo();
        });

        _assemblies.Clear();
        _modules.Clear();
    }
}