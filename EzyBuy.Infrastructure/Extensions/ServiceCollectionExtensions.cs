using EzyBuy.Domain.IRepositories;
using EzyBuy.Infrastructure.Data;
using EzyBuy.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EzyBuy.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
	public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		var connectionString = configuration.GetConnectionString("DevConnection");
		services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(connectionString));

		services.AddScoped<ISeeder, Seeder>();
		services.AddScoped<IBrandRepository, BrandRepository>();
	}
}
