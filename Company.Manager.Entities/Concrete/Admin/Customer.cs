using Company.Core.Entities;
using Company.Core.Entities.Address;
using Company.Manager.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Manager.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a customer
    /// </summary>
    public class Customer : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the customer type
        /// </summary>
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Gets or sets the customer name (First and last name or Company name)
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the company
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets the tax number
        /// </summary>
        public string TaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the tax office
        /// </summary>
        public string TaxOffice { get; set; }

        /// <summary>
        /// Gets or sets the nationality identifier
        /// </summary>
        public string NationalityId { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the nationality
        /// </summary>
        public Country Country { get; set; }

        // => User

        #endregion

        #region Status Properties

        /// <summary>
        /// Gets or sets a value indicating whether the customer is active
        /// </summary>
        public bool Active { get; set; }

        #endregion

        #region Custom Properties



        #endregion
    }
}
