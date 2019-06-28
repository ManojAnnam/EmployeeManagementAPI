namespace EmployeeManagementAPI.Controllers
{
    using EmployeeManagementAPI.Business.Contracts;
    using EmployeeManagementAPI.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private readonly IEmployeeDetailsService _employeeDetailsService;
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
    }
}
