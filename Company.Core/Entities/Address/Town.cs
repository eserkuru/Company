using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Entities.Address
{
    /// <summary>
    /// Represents a town
    /// </summary>
    public class Town : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the town name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the town code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the city code
        /// </summary>
        public string CityCode { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public virtual City City { get; set; }

        #endregion

        #region Status Properties

        /// <summary>
        /// Gets or sets the active status
        /// </summary>
        public bool IsActive { get; set; }

        #endregion

    }
}
