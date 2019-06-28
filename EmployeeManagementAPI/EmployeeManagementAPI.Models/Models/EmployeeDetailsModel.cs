namespace EmployeeManagementAPI.Models.Models
{
    /// <summary>
    /// The employee details model class.
    /// </summary>
    public class EmployeeDetailsModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>      
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the designatiom.
        /// </summary>
        public string Designatiom { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        public int Salary { get; set; }
    }
}
