using Company.Core.Entities;
using Company.Core.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Abstract
{

    /// <summary>
    /// Represents an address
    /// </summary>
    public abstract class Address : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the address description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the postal code
        /// </summary>
        public string PostalCode { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Gets or sets the town
        /// </summary>
        public Town Town { get; set; }

        #endregion

        /// <summary>
        /// Gets or sets the primary
        /// </summary>
        public bool Primary { get; set; }
    }
}
