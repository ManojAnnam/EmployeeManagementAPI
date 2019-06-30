namespace EmployeeManagementAPI.Controllers
{
    using EmployeeManagementAPI.Business.Contracts;
    using EmployeeManagementAPI.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// The employee details controller class.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        /// <summary>
        /// The employee details service (readonly).
        /// </summary>
        private readonly IEmployeeDetailsService _employeeDetailsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDetailsController"/> class.
        /// </summary>
        /// <param name="employeeDetailsService">The employeeDetailsService.</param>
        public EmployeeDetailsController(IEmployeeDetailsService employeeDetailsService)
        {
            _employeeDetailsService = employeeDetailsService;
        }

        /// <summary>
        /// Get the all employees details.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [Route(Constants.GetAllEmployees)]
        [HttpGet]
        public async Task<IActionResult> GetAllEmployeesDetails()
        {
            try
            {
                var employeeDetails = await _employeeDetailsService.GetAllEmployeesDetailsAsync();
                return Ok(employeeDetails);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /// <summary>
        /// Delete the employee.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="T:Task{IActionResult}"/>.</returns>
        [Route(Constants.DeleteEmployee)]
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                bool isEmployeeDeleted = await _employeeDetailsService.DeleteEmployeeAsync(id);
                if (isEmployeeDeleted)
                {
                    return Ok(isEmployeeDeleted);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
