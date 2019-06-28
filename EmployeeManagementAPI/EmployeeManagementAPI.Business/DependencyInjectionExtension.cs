
using EmployeeManagementAPI.Repository;
using EmployeeManagementAPI.Repository.Contracts;
using EmployeeManagementAPI.Repository.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace EmployeeManagementAPI.Business
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterBusinessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DependencyInjectionExtension));
            services.AddScoped<IEmployeeDetailsRepository, EmployeeDetailsRepository>();
            services.RegisterRepositoryDependencies(configuration);
            return services;
        }
    }
}
