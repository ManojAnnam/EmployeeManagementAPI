using EmployeeManagementAPI.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Business.Contracts
{
    public interface IEmployeeDetailsService
    {
        /// <summary>
        /// Get the all employees details async.
        /// </summary>
        /// <returns>The <see cref="T:Task{List{EmployeeDetailsModel}}"/>.</returns>
        Task<List<EmployeeDetailsModel>> GetAllEmployeesDetailsAsync();
    }
}
