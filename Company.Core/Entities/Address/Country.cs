using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Company.Core.Entities.Address
{
    /// <summary>
    /// Represents a country
    /// </summary>
    public class Country : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the country name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country code
        /// </summary>
        public string Code { get; set; }

        #endregion

        #region Navigation Properties

        // No relation properties

        #endregion

        #region Status Properties

        /// <summary>
        /// Gets or sets the active status
        /// </summary>
        public bool IsActive { get; set; }

        #endregion
    }
}
