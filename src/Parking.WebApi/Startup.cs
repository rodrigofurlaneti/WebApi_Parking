using Parking.Domain.SeedWork;
using Parking.Infrastructure.Repository.Brand;
using Parking.Infrastructure.Repository.Color;
using Parking.Infrastructure.Repository.Model;
using Parking.Infrastructure.Repository.Profile;
using Parking.Infrastructure.Repository.Type;
using Parking.Infrastructure.Repository.User;
using Parking.Service.Service.Brand;
using Parking.Service.Service.Color;
using Parking.Service.Service.Model;
using Parking.Service.Service.Profile;
using Parking.Service.Service.Type;
using Parking.Service.Service.User;

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

            services.AddScoped<IColorRepository, ColorRepository>();

            services.AddScoped<IColorService, ColorService>();

            services.AddScoped<ITypeRepository, TypeRepository>();

            services.AddScoped<ITypeService, TypeService>();

            services.AddScoped<IModelRepository, ModelRepository>();

            services.AddScoped<IModelService, ModelService>();

            services.AddScoped<IProfileRepository, ProfileRepository>();

            services.AddScoped<IProfileService, ProfileService>();

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserService, UserService>();

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