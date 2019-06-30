using System;

namespace EmployeeManagementAPI.Models
{
    /// <summary>
    /// The constants class.
    /// </summary>
    public static class Constants
    {
        /*Routes*/

        /// <summary>
        /// The get all employees (const). Value: "GetAllEmployees".
        /// </summary>
        public const string GetAllEmployees = "GetAllEmployees";

        /// <summary>
        /// The delete employee (const). Value: "DeleteEmployee/{id}".
        /// </summary>
        public const string DeleteEmployee = "DeleteEmployee/{id}";
    }
}
