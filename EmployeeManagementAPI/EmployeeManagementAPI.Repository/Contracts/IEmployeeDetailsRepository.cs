using EmployeeManagementAPI.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Repository.Contracts
{
    /// <summary>
    /// The IEmployeeDetailsRepository interface.
    /// </summary>
    public interface IEmployeeDetailsRepository
    {
        /// <summary>
        /// Get the all employees details async.
        /// </summary>
        /// <returns>The <see cref="T:Task{List{EmployeeDetails}}"/>.</returns>
        Task<List<EmployeeDetails>> GetAllEmployeesDetailsAsync();
    }
}
