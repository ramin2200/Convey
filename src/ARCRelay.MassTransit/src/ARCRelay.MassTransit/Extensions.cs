using Convey;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
//using Pacco.Services.Ecommerce.Library.API.mass;
using System.Reflection;

namespace ARCRelay.MassTransit;

public static class Extensions
{
    //private const string AccessTokenCookieName = "__access-token";
    //private const string AuthorizationHeader = "authorization";

    public static IConveyBuilder AddMassTransit(this IConveyBuilder builder)
    {
        //var options = builder.GetOptions<AuthOptions>("masstransit");
        builder.Services.AddOptions<SqlTransportOptions>().Configure(options =>
        {
            options.Host = "localhost";
            options.Database = "postgres";
            options.Schema = "transport";
            //options.Role = "transport";
            options.Username = "postgres";
            options.Password = "root";

            // credentials to run migrations
            //options.AdminUsername = "migration-user";
            //options.AdminPassword = "H4rderTooGu3ss!!";
        });
        // MassTransit will run the migrations on start up
        builder.Services.AddPostgresMigrationHostedService();
        builder.Services.AddMassTransit(x =>
        {
            Assembly applicationAssembly = Assembly.Load("Pacco.Services.Ecommerce.Library.API");
            // elided...
            x.AddConsumers(applicationAssembly);
            x.UsingPostgres((context, cfg) =>
            {
                cfg.ConfigureEndpoints(context);
            });
        });

        //services.AddHostedService<Worker>();

        return builder;
    }

    
}