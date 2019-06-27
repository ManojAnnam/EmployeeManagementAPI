using EmployeeManagementAPI.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementAPI.Repository
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterRepositoryDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmployeeManagementContext>(o => o.UseSqlServer(configuration["connectionStrings:EmployeeManagementDBConnectionString"]));
            return services;
        }
    }
}
