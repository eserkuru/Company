using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a category
    /// </summary>
    public class Category : BaseEntity
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

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the parent category identifier
        /// </summary>

        public Category ParentCategory { get; set; }

        #endregion

    }
}
