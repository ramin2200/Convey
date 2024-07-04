using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Convey.persistence.PostgreSQL
{
    public static class Extention
    {
        public static IConveyBuilder AddPostgreSQL<TContext>(this IConveyBuilder builder) where TContext : DbContext
        {
            builder.Services.AddDbContext<TContext>(options =>
                options.UseNpgsql("Host=localhost:5432;Database=demo-db2;Username=mylogin;Password=mypass"));
            return builder;
        }

    }
}