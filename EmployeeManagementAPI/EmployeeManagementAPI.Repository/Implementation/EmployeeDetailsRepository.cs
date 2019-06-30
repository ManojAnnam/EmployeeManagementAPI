using EmployeeManagementAPI.Repository.Contracts;
using EmployeeManagementAPI.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Repository.Implementation
{
    /// <summary>
    /// The employee details repository class.
    /// </summary>
    public class EmployeeDetailsRepository : IEmployeeDetailsRepository
    {

        /// <summary>
        /// The employee management context (readonly).
        /// </summary>
        private readonly EmployeeManagementContext _employeeManagementContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDetailsRepository"/> class.
        /// </summary>
        /// <param name="employeeManagementContext">The employeeManagementContext.</param>
        public EmployeeDetailsRepository(EmployeeManagementContext employeeManagementContext)
        {
            _employeeManagementContext = employeeManagementContext;
        }

        /// <summary>
        /// Get the all employees details async.
        /// </summary>
        /// <returns>The <see cref="T:Task{List{EmployeeDetails}}"/>.</returns>
        public async Task<List<EmployeeDetails>> GetAllEmployeesDetailsAsync()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails = await _employeeManagementContext.EmployeesDetails.Where(i => (i.IsDeleted == false)).ToListAsync();
            return employeeDetails;
        }

        /// <summary>
        /// Add the employee async.
        /// </summary>
        /// <param name="employeeDetails">The employeeDetails.</param>
        /// <returns>The <see cref="T:Task{int}"/>.</returns>
        public async Task<int> AddEmployeeAsync(EmployeeDetails employeeDetails)
        {
            var checkEmployee = _employeeManagementContext.EmployeesDetails
                .Where(i => i.Name == employeeDetails.Name && !i.IsDeleted).FirstOrDefault();
            if (checkEmployee == null)
            {
                _employeeManagementContext.EmployeesDetails.Add(employeeDetails);
                await _employeeManagementContext.SaveChangesAsync();
                return employeeDetails.Id;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Update the employee async.
        /// </summary>
        /// <param name="employeeDetails">The employeeDetails.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        public async Task<bool> UpdateEmployeeAsync(EmployeeDetails employeeDetails)
        {
            var checkEmployee = _employeeManagementContext.EmployeesDetails
                .Where(i => i.Id == employeeDetails.Id && !i.IsDeleted);
            if (checkEmployee != null)
            {
                _employeeManagementContext.EmployeesDetails.Update(employeeDetails);
                await _employeeManagementContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Delete the employee async.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var employee = await _employeeManagementContext.EmployeesDetails.SingleOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            if (employee != null)
            {
                employee.IsDeleted = true;
                await _employeeManagementContext.SaveChangesAsync();
                return true;
            }
            return false;
        }


    }
}
