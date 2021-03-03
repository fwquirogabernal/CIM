using Challenge.IntegraMedia.Persistence.Setup;
using Challenge.IntegraMedia.Queries.Person;
using Challenge.IntegraMedia.Queries.Person.Interfaces;
using Challenge.IntegraMedia.Queries.Products;
using Challenge.IntegraMedia.Queries.Sales;
using Challenge.IntegraMedia.Queries.Sales.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Challenge.IntegraMedia.Api
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

            services.AddControllers();
            InstallDbContext(services);
            InstallCommandsAndQueries(services);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Challenge.IntegraMedia.Api", Version = "v1" });
            });
        }

        private void InstallCommandsAndQueries(IServiceCollection services)
        {
            services.AddScoped<ICustomerQueries, CustomerQueries>();
            services.AddScoped<IEmployeeQueries, EmployeeQueries>();
            services.AddScoped<IProductQueries, ProductQueries>();
            services.AddScoped<ISaleQueries, SalesQueries>();
            services.AddScoped<ISaleLineQueries, SaleLineQueries>();
            services.AddScoped<ICustomerQueries, CustomerQueries>();
        }

        private void InstallDbContext(IServiceCollection services)
        {
            services.AddDbContext<IDataBaseContext, DataBaseContext>(o =>
                            o.UseSqlServer(Configuration.GetConnectionString("AppDatabaseConnection"),
                                           o => o.MigrationsAssembly("Challenge.IntegraMedia.Persistence")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Challenge.IntegraMedia.Api v1"));
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
