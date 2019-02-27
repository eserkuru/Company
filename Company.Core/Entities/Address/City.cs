using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Entities.Address
{
    /// <summary>
    /// Represents a city
    /// </summary>
    public class City : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the city name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the city code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the country code
        /// </summary>
        public string CountryCode { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public virtual Country Country { get; set; }

        #endregion

        #region Status Properties

        /// <summary>
        /// Gets or sets the active status
        /// </summary>
        public bool IsActive { get; set; }

        #endregion

    }
}
