namespace EmployeeManagementAPI.Repository.Contracts
{
    using EmployeeManagementAPI.Repository.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// The IEmployeeDetailsRepository interface.
    /// </summary>
    public interface IEmployeeDetailsRepository
    {
        /// <summary>
        /// Get the all employees details async.
        /// </summary>
        /// <returns>The <see cref="T:Task{List{EmployeeDetails}}"/>.</returns>
        Task<List<EmployeeDetails>> GetAllEmployeesDetailsAsync(int skipCount, int displayCount);

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
