using Builders.Domain.EntranceTestContext.Handlers;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Infra.Context;
using Builders.Infra.Repositories;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Builders.Api
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

            services.Configure<ConfigDB>(
                x =>
                {
                    x.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                    x.DataBase = Configuration.GetSection("MongoConnection:DataBase").Value;
                });
            services.AddControllers();
            registrandoDependencias(services);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Builders.Api", Version = "v1" });
            });

        }
        public void registrandoDependencias(IServiceCollection services)
        {
            #region"Repositórios"
            services.AddScoped<IBinaryRepository, BinaryRepository>();
            #endregion

            #region"Handlers"
            services.AddScoped<BinaryHandler, BinaryHandler>();
            #endregion

            #region"mediator"
            services.AddMediatR(Assembly.GetExecutingAssembly());
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Builders.Api v1"));
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
