
using EmployeeManagementAPI.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementAPI.Business
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterBusinessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterRepositoryDependencies(configuration);
            return services;
        }
    }
}
