using AutoMapper;
using EmployeeManagementAPI.Business.Contracts;
using EmployeeManagementAPI.Models.Models;
using EmployeeManagementAPI.Repository.Contracts;
using EmployeeManagementAPI.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Business.Implementation
{
    /// <summary>
    /// The employee details service class.
    /// </summary>
    public class EmployeeDetailsService : IEmployeeDetailsService
    {
        /// <summary>
        /// The employee details repository (readonly).
        /// </summary>
        private readonly IEmployeeDetailsRepository _employeeDetailsRepository;

        /// <summary>
        /// The mapper (readonly).
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDetailsService"/> class.
        /// </summary>
        /// <param name="employeeDetailsRepository">The employeeDetailsRepository.</param>
        /// <param name="mapper">The mapper.</param>
        public EmployeeDetailsService(IEmployeeDetailsRepository employeeDetailsRepository, IMapper mapper)
        {
            _employeeDetailsRepository = employeeDetailsRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get the all employees details async.
        /// </summary>
        /// <returns>The <see cref="T:Task{List{EmployeeDetailsModel}}"/>.</returns>
        public async Task<List<EmployeeDetailsModel>> GetAllEmployeesDetailsAsync(int skipCount, int displayCount)
        {
            List<EmployeeDetailsModel> employeeDetailsModels = new List<EmployeeDetailsModel>();
            var employees = await _employeeDetailsRepository.GetAllEmployeesDetailsAsync(skipCount, displayCount);
            if (employees != null && employees.Count > 0)
            {
                employeeDetailsModels = _mapper.Map<List<EmployeeDetailsModel>>(employees);
            }

            return employeeDetailsModels;
        }

        /// <summary>
        /// Add the employee async.
        /// </summary>
        /// <param name="employeeDetailsModel">The employeeDetailsModel.</param>
        /// <returns>The <see cref="T:Task{int}"/>.</returns>
        public async Task<int> AddEmployeeAsync(EmployeeDetailsModel employeeDetailsModel)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails = _mapper.Map<EmployeeDetails>(employeeDetailsModel);
            return await _employeeDetailsRepository.AddEmployeeAsync(employeeDetails);
        }

        /// <summary>
        /// Update the employee async.
        /// </summary>
        /// <param name="employeeDetailsModel">The employeeDetailsModel.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        public async Task<bool> UpdateEmployeeAsync(EmployeeDetailsModel employeeDetailsModel)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails = _mapper.Map<EmployeeDetails>(employeeDetailsModel);
            return await _employeeDetailsRepository.UpdateEmployeeAsync(employeeDetails);
        }

        /// <summary>
        /// Delete the employee async.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="T:Task{bool}"/>.</returns>
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            return await _employeeDetailsRepository.DeleteEmployeeAsync(id);
        }
    }
}
