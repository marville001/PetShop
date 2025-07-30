
using Microsoft.Extensions.DependencyInjection;
using PetShop.Domain.Interfaces;
using PetShop.Infrastructure.Repositories;

namespace PetShop.Infrastructure;

public static class InfrastructureRegistrationServices
{
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
	{
		// Register your services here
		services.AddScoped<ICustomerRepository, CustomerRepository>();
		
		return services;
	}
}