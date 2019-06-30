//// <copyright file="EmployeeDetails.cs" company="GGK Tech">
//// Copyright (c) 2019 All Right Reserved
//// </copyright>
//// <author>GGK Tech</author>
//// <email></email>
//// <date>27-06-2019</date>
//// <summary>The Employee Details class.</summary>
namespace EmployeeManagementAPI.Repository.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The employee details class.
    /// </summary>
    public class EmployeeDetails
    {

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the designatiom.
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}
