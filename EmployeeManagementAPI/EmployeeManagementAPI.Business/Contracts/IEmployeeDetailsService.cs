namespace EmployeeManagementAPI.Business.Contracts
{
    using EmployeeManagementAPI.Models.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// The IEmployeeDetailsService interface.
    /// </summary>
    public interface IEmployeeDetailsService
    {
        /// <summary>
        /// Get the all employees details async.
        /// </summary>
        /// <returns>The <see cref="T:Task{List{EmployeeDetailsModel}}"/>.</returns>
        Task<List<EmployeeDetailsModel>> GetAllEmployeesDetailsAsync();

        /// <summary>
        /// Delete the employee async.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
