﻿namespace EmployeeManagementAPI.Repository.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EmployeeManagementAPI.Repository.Entities;
   
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

        /// <summary>
        /// Add the employee async.
        /// </summary>
        /// <param name="employeeDetails">The employeeDetails.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        Task<int> AddEmployeeAsync(EmployeeDetails employeeDetails);

        /// <summary>
        /// Update the employee async.
        /// </summary>
        /// <param name="employeeDetails">The employeeDetails.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        Task<bool> UpdateEmployeeAsync(EmployeeDetails employeeDetails);

        /// <summary>
        /// Delete the employee async.
        /// </summary>
        /// <param name="Id">The Id.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
