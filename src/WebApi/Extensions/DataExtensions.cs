using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Infrastructure;
using WebApi.Interfaces;

namespace WebApi.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));

            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<ICarRepository, CarRepository>();

            return services;
        }
    }
}
