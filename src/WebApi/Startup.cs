using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Infrastructure;
using WebApi.Interfaces;

namespace WebApi
{
    public class Startup : Interfaces.IStartup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));

            });

            services.AddScoped(typeof(IRepositoryBase<>), typeof(IRepositoryBase<>));
            services.AddScoped<ICarRepository, CarRepository>();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

    }
}
