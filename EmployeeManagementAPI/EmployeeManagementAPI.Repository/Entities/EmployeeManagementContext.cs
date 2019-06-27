using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementAPI.Repository.Entities
{
    public class EmployeeManagementContext: DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManagementContext"/> class.
        /// </summary>
        /// <param name="dbContextOptions">The dbContextOptions.</param>
        public EmployeeManagementContext(DbContextOptions<EmployeeManagementContext> dbContextOptions):base(dbContextOptions)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Gets or sets the employees details.
        /// </summary>
        public DbSet<EmployeeDetails> EmployeesDetails { get; set; }

    }
}
