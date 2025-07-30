using Microsoft.Extensions.DependencyInjection;
using PetShop.Application.Features.Customer.Interfaces;
using PetShop.Application.Features.Customer.Services;
using PetShop.Application.Mappers;

namespace PetShop.Application;

public static class ApplicationRegistrationServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddTransient<ICustomerMapper, CustomerMapper>();
        return services;
    }
    
}