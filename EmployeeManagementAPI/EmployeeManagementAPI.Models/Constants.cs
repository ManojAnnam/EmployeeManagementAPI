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
        /// The add employee (const). Value: "AddEmployee".
        /// </summary>
        public const string AddEmployee = "AddEmployee";

        /// <summary>
        /// The update employee (const). Value: "UpdateEmployee".
        /// </summary>
        public const string UpdateEmployee = "UpdateEmployee";

        /// <summary>
        /// The delete employee (const). Value: "DeleteEmployee/{id}".
        /// </summary>
        public const string DeleteEmployee = "DeleteEmployee/{id}";
    }
}
