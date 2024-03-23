using Parking.Domain.SeedWork;
using Parking.Infrastructure.Repository.Brand;
using Parking.Service.Service.Brand;

namespace Parking.WebApi
{
    public class Startup : IStartup
    {
        private readonly string _allowPolicy = "_AllowPolicy";
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: _allowPolicy, builder => builder.WithOrigins("*")
                                                                    .AllowAnyMethod()
                .AllowAnyHeader());
            });

            services.AddScoped<Domain.SeedWork.ILogger, Logger>();

            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddScoped<IBrandService, BrandService>();

            services.AddControllers();

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();
        }

        public void Configure(WebApplication webApplication, IWebHostEnvironment webHostEnvironment)
        {
            if (webApplication.Environment.IsDevelopment() || webApplication.Environment.IsProduction())
            {
                webApplication.UseDeveloperExceptionPage();

                webApplication.UseSwagger();

                webApplication.UseSwaggerUI();

                webApplication.MapSwagger();
            }

            webApplication.UseHttpsRedirection();

            webApplication.UseCors(_allowPolicy);

            webApplication.UseAuthorization();

            webApplication.MapControllers();

            webApplication.Run();
        }

    }
}