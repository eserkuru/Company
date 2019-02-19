using Company.Core.Entities;
using Company.Project.Entities.Concrete.ClientManagment;
using System;

namespace Company.Project.Entities.Concrete.HumanResources
{
    /// <summary>
    /// Represents a employee
    /// </summary>
    public class Employee : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Represents a first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents a last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents a nationality identifier
        /// </summary>
        public string NationalityId { get; set; }

        /// <summary>
        /// Represents a fixed salary
        /// </summary>public string Title { get; set; }
        public string FixedSalary { get; set; }

        /// <summary>
        /// Represents a contract start date
        /// </summary>
        public DateTime ContractStartDate { get; set; }

        /// <summary>
        /// Represents a contract end date
        /// </summary>
        public DateTime ContractEndDate { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Represents a curency
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Represents a organisation
        /// </summary>
        public Organisation Organisation { get; set; }

        /// <summary>
        /// Represents a branch
        /// </summary>
        public Branch Branch { get; set; }

        /// <summary>
        /// Represents a unit
        /// </summary>
        public Unit Units { get; set; }

        #endregion
    }
}
