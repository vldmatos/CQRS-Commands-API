using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Commads.API
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMediatR(Assembly.GetExecutingAssembly());
			services.AddControllers();
			services.AddSwaggerGen(configuration =>
			{
				configuration.SwaggerDoc("v1", new OpenApiInfo { Title = "Commads_API", Version = "v1" });
			});
		}

		public void Configure(IApplicationBuilder application, IWebHostEnvironment environment)
		{
			if (environment.IsDevelopment())
			{
				application.UseDeveloperExceptionPage();
				application.UseSwagger();
				application.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Commads_API v1"));
			}

			application.UseHttpsRedirection();
			application.UseRouting();
			application.UseAuthorization();

			application.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
