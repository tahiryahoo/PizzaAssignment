using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Repository;
using InventoryService.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace InventoryService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options=> {
                options.AddPolicy(
                    name: "AllowOrigin",
                    builder=> {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();

                    });
            });
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IInventoryService, InventoryServices>();
            services.AddScoped<IRepository<ProductDomainModel>, ProductRepository<ProductDomainModel>>();
            services.AddScoped<IRepository<InventoryDomainModel>, InventoryRepository<InventoryDomainModel>>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {

            app.UseCors("AllowOrigin");
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Inventory API V1");
            });

             
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
    }
}
