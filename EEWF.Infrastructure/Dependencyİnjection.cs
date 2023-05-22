using EEWF.Application.Interfaces;
using EEWF.Infrastructure.Data;
using EEWF.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Infrastructure
{
	public static class Dependencyİnjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(option =>
			{
				option.UseSqlServer(configuration["Database"]);
			});
			services.AddTransient<ICaruselService, CaruselService>();
				return services;
		}
	}
}
