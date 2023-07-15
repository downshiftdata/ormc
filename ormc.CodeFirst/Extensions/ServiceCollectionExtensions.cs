using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ormc.CodeFirst.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCodeFirst(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataAccess.Context>(options => options.UseSqlServer(configuration.GetConnectionString("ormc")));
            return services;
        }
    }
}
