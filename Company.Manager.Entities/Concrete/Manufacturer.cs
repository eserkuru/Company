using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Entities.Concrete
{
    /// <summary>
    /// Represents a manufacturer
    /// </summary>
    public class Manufacturer : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the manufacturer is active
        /// </summary>
        public bool Active { get; set; }

        #endregion

        #region Navigation Properties

        /// No relation properties

        #endregion

    }
}
