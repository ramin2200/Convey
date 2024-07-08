using System.Threading.Tasks;
using Ecommerce.Bootstrapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Convey.Module.Monolithic;
using Monolith.Logging.Logging;
//using Convey.Logging;
using Convey.Secrets.Vault;


namespace Inflow.Bootstrapper;

public class Program
{
    public static Task Main(string[] args)
        => CreateHostBuilder(args).Build().RunAsync();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            .ConfigureModules()
            .UseLogging();
            //.UseVault();
}

















//using Microsoft.Extensions.Configuration;
//using System.Reflection;
//var builder = WebApplication.CreateBuilder(args);



//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
