using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wishlist.Application.Contracts;
using Wishlist.Application.Mapping;
using Wishlist.Application.Services;
using Wishlist.Domain.Entities;
using Wishlist.Persistence;
using Wishlist.Persistence.ConnectionConfig;
using Wishlist.Persistence.Contexts;
using Wishlist.Persistence.Contracts;
using Wishlist.Persistence.Persistence;

namespace Wishlist.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.Configure<DbOptions>(options =>
            {
                options.Connection = Configuration.GetSection("DatabaseSettings:Connection").Value;
                options.Name = Configuration.GetSection("DatabaseSettings:Name").Value;
            });

            services.AddAutoMapper(typeof(DomainToMappingProfile));

            services.AddScoped<IConnectionConfig, ConnectionConfig>();
            services.AddScoped<IMongoDbContext, MongoDbContext>();
            services.AddScoped<IStaticPersistence<Product>, StaticPersistence<Product>>();
            services.AddScoped<IProductService, ProductService>();
        }

        public void Configure(IApplicationBuilder application, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                application.UseSwagger();
                application.UseSwaggerUI();
            }

            application.UseRouting();
            application.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            application.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
