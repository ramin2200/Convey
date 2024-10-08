using Convey;
using Convey.MessageBrokers;
using Convey.persistence.PostgreSQL;
using Elasticsearch.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Ramin.Services.Products.Infrastructure.PostgreSQL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ramin.Services.Products.Infrastructure
{
    public static class Extensions
    {
        public static IConveyBuilder AddInfrastructure(this IConveyBuilder builder)
        {
            //builder.Services.AddSingleton<IEventMapper, EventMapper>();
            ////builder.Services.AddTransient<IMessageBroker, MessageBroker>();
            //builder.Services.AddTransient<IResourcesRepository, ResourcesRepository>();
            ////builder.Services.AddTransient<ICustomersServiceClient, CustomersServiceClient>();
            //builder.Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            //builder.Services.AddTransient<IAppContextFactory, AppContextFactory>();
            ////builder.Services.AddTransient<IEventProcessor, EventProcessor>();
            //builder.Services.AddTransient<IEventProcessor, EventProcessorEmpty>();
            //builder.Services.AddTransient(ctx => ctx.GetRequiredService<IAppContextFactory>().Create());
            ////builder.Services.AddHostedService<MetricsJob>();
            ////builder.Services.AddSingleton<CustomMetricsMiddleware>();
            ////builder.Services.TryDecorate(typeof(ICommandHandler<>), typeof(OutboxCommandHandlerDecorator<>));
            ////builder.Services.TryDecorate(typeof(IEventHandler<>), typeof(OutboxEventHandlerDecorator<>));
            //builder.Services.Scan(s => s.FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
            //    .AddClasses(c => c.AssignableTo(typeof(IDomainEventHandler<>)))
            //    .AsImplementedInterfaces()
            //    .WithTransientLifetime());
            //builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            return builder
                .AddPostgreSQL<ProductContext>();
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            return app;
        }

        //internal static CorrelationContext GetCorrelationContext(this IHttpContextAccessor accessor)
        //    => accessor.HttpContext?.Request.Headers.TryGetValue("Correlation-Context", out var json) is true
        //        ? JsonConvert.DeserializeObject<CorrelationContext>(json.FirstOrDefault())
        //        : null;

        internal static IDictionary<string, object> GetHeadersToForward(this IMessageProperties messageProperties)
        {
            const string sagaHeader = "Saga";
            if (messageProperties?.Headers is null || !messageProperties.Headers.TryGetValue(sagaHeader, out var saga))
            {
                return null;
            }

            return saga is null
                ? null
                : new Dictionary<string, object>
                {
                    [sagaHeader] = saga
                };
        }

        internal static string GetSpanContext(this IMessageProperties messageProperties, string header)
        {
            if (messageProperties is null)
            {
                return string.Empty;
            }

            if (messageProperties.Headers.TryGetValue(header, out var span) && span is byte[] spanBytes)
            {
                return Encoding.UTF8.GetString(spanBytes);
            }

            return string.Empty;
        }
    }
}